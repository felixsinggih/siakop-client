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
    public partial class FrmMenus : Form {
        private Form currentChildForm;

        public FrmMenus() {
            InitializeComponent();
        }

        private void FrmMenus_Load(object sender, EventArgs e) {
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        protected override void OnFormClosing(FormClosingEventArgs e) {
            base.OnFormClosing(e);
            if(PreClosingConfirmation() == System.Windows.Forms.DialogResult.Yes) {
                Dispose(true);
                string act = "Logout";
                ActivityHistory(act);
                Application.Exit();
            } else {
                e.Cancel = true;
            }
        }

        private DialogResult PreClosingConfirmation() {
            DialogResult re = System.Windows.Forms.MessageBox.Show("Apakah Anda Yakin Akan Keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return re;
        }

        private void ActivityHistory(string act) {
            HistoryService his = new HistoryService();
            his.ID = AppSession._id_user;
            his.ACT = act;
            his.TIME = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            his.Add();
        }

        public void OpenChildForm(Form childForm) {
            if (currentChildForm != null) {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            PnlContainer.Controls.Add(childForm);
            PnlContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BtnDebitur_Click(object sender, EventArgs e) {
            OpenChildForm(new FrmAnggota());
        }

        private void BtnKredit_Click(object sender, EventArgs e) {
            OpenChildForm(new FrmKreditShow());
        }

        private void BtnKreditAdd_Click(object sender, EventArgs e) {
            OpenChildForm(new FrmKredit());
        }

        private void BtnHistory_Click(object sender, EventArgs e) {
            OpenChildForm(new FrmHistory());
        }
    }
}
