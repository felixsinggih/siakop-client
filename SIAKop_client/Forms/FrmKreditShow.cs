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
    public partial class FrmKreditShow : Form {
        private string noPar = "";
        private bool search = false;
        private int limit = 25;
        private int offset = 0;
        private string rowsCount;
        private string pageCount;
        private int pageNow = 0;
        KreditService kre = new KreditService();

        public FrmKreditShow() {
            InitializeComponent();
        }

        private void FrmKreditShow_Load(object sender, EventArgs e) {
            using (FrmWait frm = new FrmWait(RefreshKre)) {
                frm.ShowDialog();
            }
        }

        private void LoadPage() {
            offset = 0;
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

        public void RefreshKre() {
            TxtCari.Invoke(new MethodInvoker(delegate { TxtCari.Text = ""; }));
            search = false;
            rowsCount = kre.Count(noPar);
            ShowKredit(noPar);
            LoadPage();
        }

        private void Search() {
            search = true;
            rowsCount = kre.Count(TxtCari.Text);
            ShowKredit(TxtCari.Text);
            LoadPage();
        }

        private void PrevData() {
            offset = offset - limit;
            pageNow = pageNow - 1;
            if (search == false) {
                ShowKredit(noPar);
            } else {
                ShowKredit(TxtCari.Text);
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
                ShowKredit(noPar);
            } else {
                ShowKredit(TxtCari.Text);
            }
            LblPage.Invoke(new MethodInvoker(delegate { LblPage.Text = string.Format("Page {0}/{1}", pageNow, pageCount); }));
            if (offset != 0)
                BtnPrev.Invoke(new MethodInvoker(delegate { BtnPrev.Enabled = true; }));
            if (pageNow.ToString() == pageCount)
                BtnNext.Invoke(new MethodInvoker(delegate { BtnNext.Enabled = false; }));
        }

        private void ShowKredit(string par) {
            DgvKredit.Invoke(new MethodInvoker(delegate { DgvKredit.DataSource = kre.Search(par, limit, offset); }));
            foreach (DataGridViewRow row in DgvKredit.Rows) {
                row.Cells["plafon"].Value = int.Parse(row.Cells["plafon"].Value.ToString()).ToRupiah();
                row.Cells["baki_debet"].Value = int.Parse(row.Cells["baki_debet"].Value.ToString()).ToRupiah();
                //if (row.Cells["kode_kondisi"].Value.ToString() == "00")
                //    row.Cells["kode_kondisi"].Value = "FASILITAS AKTIF";
                //else if (row.Cells["kode_kondisi"].Value.ToString() == "01")
                //    row.Cells["kode_kondisi"].Value = "DIBATALKAN";
                //else if (row.Cells["kode_kondisi"].Value.ToString() == "02")
                //    row.Cells["kode_kondisi"].Value = "LUNAS";
                //else if (row.Cells["kode_kondisi"].Value.ToString() == "03")
                //    row.Cells["kode_kondisi"].Value = "DIHAPUSBUKUKAN";
                //else if (row.Cells["kode_kondisi"].Value.ToString() == "04")
                //    row.Cells["kode_kondisi"].Value = "HAPUS TAGIH";
                //else if (row.Cells["kode_kondisi"].Value.ToString() == "05")
                //    row.Cells["kode_kondisi"].Value = "LUNAS KARENA PENGAMBILALIHAN AGUNAN";
                //else if (row.Cells["kode_kondisi"].Value.ToString() == "06")
                //    row.Cells["kode_kondisi"].Value = "LUNAS KARENA DISELESAIKAN MELALUI PENGADILAN";
                //else if (row.Cells["kode_kondisi"].Value.ToString() == "07")
                //    row.Cells["kode_kondisi"].Value = "DIALIHKAN KE PELAPOR LAIN";
                //else if (row.Cells["kode_kondisi"].Value.ToString() == "08")
                //    row.Cells["kode_kondisi"].Value = "DIALIHKAN KE FASILITAS LAIN";
                //else if (row.Cells["kode_kondisi"].Value.ToString() == "09")
                //    row.Cells["kode_kondisi"].Value = "DIALIHKAN/DIJUAL KEPADA PIHAK NON PELAPOR";
                //else if (row.Cells["kode_kondisi"].Value.ToString() == "10")
                //    row.Cells["kode_kondisi"].Value = "DISEKURITISASI (KREDITUR ASAL SEBAGAI SERVICER)";
                //else if (row.Cells["kode_kondisi"].Value.ToString() == "11")
                //    row.Cells["kode_kondisi"].Value = "DISEKURITISASI (KREDITUR ASAL TIDAK SEBAGAI SERVICER)";
                //else if (row.Cells["kode_kondisi"].Value.ToString() == "12")
                //    row.Cells["kode_kondisi"].Value = "LUNAS DENGAN DISKON";
                //else if (row.Cells["kode_kondisi"].Value.ToString() == "13")
                //    row.Cells["kode_kondisi"].Value = "DIBLOKIR SEMENTARA";
                //else if (row.Cells["kode_kondisi"].Value.ToString() == "14")
                //    row.Cells["kode_kondisi"].Value = "BERHENTI DARI KEANGGOTAAN KREDIT JOIN";
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e) {
            using (FrmWait frm = new FrmWait(RefreshKre)) {
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

        private string idKreditEdit = "";

        public void EditKredit() {
            FrmKreditEdit edit = new FrmKreditEdit(this);
            edit.idKredit = idKreditEdit;
            edit.ShowDialog();
        }

        private void DgvKredit_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            FrmKreditDetail frm = new FrmKreditDetail();
            if (DgvKredit.Columns[e.ColumnIndex].Name == "detail") {
                DataGridViewRow row = this.DgvKredit.Rows[e.RowIndex];
                frm.idKredit = row.Cells["id_kredit"].Value.ToString();
                frm.ShowDialog();
            }
            
            if (DgvKredit.Columns[e.ColumnIndex].Name == "edit") {
                DataGridViewRow row = this.DgvKredit.Rows[e.RowIndex];
                idKreditEdit = row.Cells["id_kredit"].Value.ToString();

                FrmConfirmEdit conEdit = new FrmConfirmEdit(this);
                conEdit.ShowDialog();
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
