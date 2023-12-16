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
    public partial class FrmConfirmEdit : Form {
        FrmKreditShow kredit;

        public FrmConfirmEdit(FrmKreditShow kre) {
            InitializeComponent();
            this.kredit = kre;
            TxtPass.Focus();
        }

        private void Confirmation() {
            ConfirmService conf = new ConfirmService();
            DataTable userMan = conf.CheckMan();
            if (conf.ConfrimSave(userMan.Rows[0][2].ToString(), TxtPass.Text.Trim()) == true) {
                this.Close();
                kredit.EditKredit();
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

        private void BtnConfirm_Click_1(object sender, EventArgs e) {
            Confirmation();
        }
    }
}
