using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIAKop_client.Class;

namespace SIAKop_client.Forms {
    public partial class FrmHistory : Form {
        private int limit = 25;
        private int offset = 0;
        private string rowsCount;
        private string pageCount;
        private int pageNow = 0;
        HistoryService his = new HistoryService();

        public FrmHistory() {
            InitializeComponent();
        }

        private void FrmHistory_Load(object sender, EventArgs e) {
            using (FrmWait frm = new FrmWait(RefreshData)) {
                frm.ShowDialog();
            }
        }

        private void RefreshData() {
            offset = 0;
            pageNow = 0;
            rowsCount = his.Count();
            if (rowsCount != "0")
                pageNow = 1;
            pageCount = (Math.Ceiling(System.Convert.ToDecimal(rowsCount) / System.Convert.ToDecimal(limit))).ToString();
            BtnPrev.Invoke(new MethodInvoker(delegate { BtnPrev.Visible = true; }));
            BtnNext.Invoke(new MethodInvoker(delegate { BtnNext.Visible = true; }));
            LblRowsCount.Invoke(new MethodInvoker(delegate { LblRowsCount.Text = string.Format("Total : {0}", rowsCount); }));
            LblPage.Invoke(new MethodInvoker(delegate { LblPage.Text = string.Format("Page {0}/{1}", pageNow, pageCount); }));
            DgvHistory.Invoke(new MethodInvoker(delegate { DgvHistory.DataSource = his.ShowHistory(limit, offset); }));
            if (offset == 0)
                BtnPrev.Invoke(new MethodInvoker(delegate { BtnPrev.Enabled = false; }));
            else
                BtnPrev.Invoke(new MethodInvoker(delegate { BtnPrev.Enabled = true; }));

            if (pageNow.ToString() == pageCount)
                BtnNext.Invoke(new MethodInvoker(delegate { BtnNext.Enabled = false; }));
            else
                BtnNext.Invoke(new MethodInvoker(delegate { BtnNext.Enabled = true; }));
            LblTampil.Invoke(new MethodInvoker(delegate { LblTampil.Visible = true; }));
        }

        private void PrevData() {
            offset = offset - limit;
            pageNow = pageNow - 1;
            DgvHistory.Invoke(new MethodInvoker(delegate { DgvHistory.DataSource = his.ShowHistory(limit, offset); }));
            LblPage.Invoke(new MethodInvoker(delegate { LblPage.Text = string.Format("Page {0}/{1}", pageNow, pageCount); }));
            if (offset == 0)
                BtnPrev.Invoke(new MethodInvoker(delegate { BtnPrev.Enabled = false; }));
            if (pageNow.ToString() != pageCount)
                BtnNext.Invoke(new MethodInvoker(delegate { BtnNext.Enabled = true; }));
        }

        private void NextData() {
            offset = offset + limit;
            pageNow = pageNow + 1;
            DgvHistory.Invoke(new MethodInvoker(delegate { DgvHistory.DataSource = his.ShowHistory(limit, offset); }));
            LblPage.Invoke(new MethodInvoker(delegate { LblPage.Text = string.Format("Page {0}/{1}", pageNow, pageCount); }));
            if (offset != 0)
                BtnPrev.Invoke(new MethodInvoker(delegate { BtnPrev.Enabled = true; }));
            if (pageNow.ToString() == pageCount)
                BtnNext.Invoke(new MethodInvoker(delegate { BtnNext.Enabled = false; }));
        }

        private void BtnRefresh_Click(object sender, EventArgs e) {
            using (FrmWait frm = new FrmWait(RefreshData)) {
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
    }
}
