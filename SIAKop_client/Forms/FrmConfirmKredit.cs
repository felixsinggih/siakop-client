using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using SIAKop_client.Class;

namespace SIAKop_client.Forms {
    public partial class FrmConfirmKredit : Form {
        FrmKredit confirm;
        public FrmConfirmKredit(FrmKredit con) {
            InitializeComponent();
            this.confirm = con;
            TxtPass.Focus();
        }

        private void Confirmation() {
            ConfirmService conf = new ConfirmService();
            if (conf.ConfrimSave(AppSession._username, TxtPass.Text.Trim()) == true) {
                this.Close();
                confirm.ConfirmSave();
            } else {
                MessageBox.Show("Maaf, Password Salah!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtPass.Focus();
            }
        }

        private void TxtPass_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                Confirmation();
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e) {
            Confirmation();
        }
    }
}
