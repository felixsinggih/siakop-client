using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FontAwesome.Sharp;
using SIAKop_client.Class;

namespace SIAKop_client.Forms {
    public partial class FrmAnggota : Form {
        private string noPar = "";
        private bool search = false;
        private int limit = 25;
        private int offset = 0;
        private string rowsCount;
        private string pageCount;
        private int pageNow = 0;
        AnggotaService ang = new AnggotaService();

        public FrmAnggota() {
            InitializeComponent();
        }

        private void FrmAnggota_Load(object sender, EventArgs e) {
            using (FrmWait frm = new FrmWait(RefreshAng)) {
                frm.ShowDialog();
            }
        }

        private void LoadPage() {
            offset = 0;
            pageNow = 0;
            if (rowsCount != "0")
                pageNow = 1;
            pageCount = (Math.Ceiling(System.Convert.ToDecimal(rowsCount) / System.Convert.ToDecimal(limit))).ToString();
            LblRowsCount.Invoke(new MethodInvoker(delegate { LblRowsCount.Text = string.Format("Total Data : {0}", rowsCount); }));
            LblPage.Invoke(new MethodInvoker(delegate { LblPage.Text = string.Format("Page {0}/{1}", pageNow, pageCount); }));
            if (offset == 0)
                BtnPrev.Invoke(new MethodInvoker(delegate { BtnPrev.Enabled = false; }));
            else
                BtnPrev.Invoke(new MethodInvoker(delegate { BtnPrev.Enabled = true; }));

            if (pageNow.ToString() == pageCount)
                BtnNext.Invoke(new MethodInvoker(delegate { BtnNext.Enabled = false; }));
            else
                BtnNext.Invoke(new MethodInvoker(delegate { BtnNext.Enabled = true; }));
        }
        private void RefreshAng() {
            TxtCari.Invoke(new MethodInvoker(delegate { TxtCari.Text = ""; }));
            search = false;
            rowsCount = ang.Count(noPar);
            ShowAnggota(noPar);
            LoadPage();
        }

        private void Search() {
            search = true;
            rowsCount = ang.Count(TxtCari.Text);
            ShowAnggota(TxtCari.Text);
            LoadPage();
        }

        private void PrevData() {
            offset = offset - limit;
            pageNow = pageNow - 1;
            if (search == false) {
                ShowAnggota(noPar);
            } else {
                ShowAnggota(TxtCari.Text);
            }
            LblPage.Invoke(new MethodInvoker(delegate { LblPage.Text = string.Format("Page {0}/{1}", pageNow, pageCount); }));
            if (offset == 0)
                BtnPrev.Invoke(new MethodInvoker(delegate { BtnPrev.Enabled = false; }));
            if (pageNow.ToString() != pageCount)
                BtnNext.Invoke(new MethodInvoker(delegate { BtnNext.Enabled = true; }));
        }

        private void NextData() {
            offset = offset + limit;
            pageNow = pageNow + 1;
            if (search == false) {
                ShowAnggota(noPar);
            } else {
                ShowAnggota(TxtCari.Text);
            }
            LblPage.Invoke(new MethodInvoker(delegate { LblPage.Text = string.Format("Page {0}/{1}", pageNow, pageCount); }));
            if (offset != 0)
                BtnPrev.Invoke(new MethodInvoker(delegate { BtnPrev.Enabled = true; }));
            if (pageNow.ToString() == pageCount)
                BtnNext.Invoke(new MethodInvoker(delegate { BtnNext.Enabled = false; }));
        }

        private void ShowAnggota(string par) {
            DgvAnggota.Invoke(new MethodInvoker(delegate { DgvAnggota.DataSource = ang.Search(par, limit, offset); }));
        }

        private void BtnRefresh_Click(object sender, EventArgs e) {
            using (FrmWait frm = new FrmWait(RefreshAng)) {
                frm.ShowDialog();
            }
        }

        private void BtnPrev_Click(object sender, EventArgs e) {
            using (FrmWait frm = new FrmWait(PrevData)) {
                frm.ShowDialog();
            }
        }

        private void BtnNext_Click(object sender, EventArgs e) {
            using (FrmWait frm = new FrmWait(NextData)) {
                frm.ShowDialog();
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e) {
            using (FrmWait frm = new FrmWait(Search)) {
                frm.ShowDialog();
            }
        }

        private void DgvAnggota_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            FrmAnggotaDetail frm =new FrmAnggotaDetail();
            if (DgvAnggota.Columns[e.ColumnIndex].Name == "detail") { 
                DataGridViewRow row = this.DgvAnggota.Rows[e.RowIndex];
                frm.idAnggota = row.Cells["din"].Value.ToString();
                frm.ShowDialog();
            }
        }

        private void TxtCari_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                using (FrmWait frm = new FrmWait(Search)) {
                    frm.ShowDialog();
                }
            }
        }
    }
}
