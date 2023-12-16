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
    public partial class FrmConfirmEditSave : Form {
        FrmKreditEdit edit;

        public FrmConfirmEditSave(FrmKreditEdit ed) {
            InitializeComponent();
            this.edit = ed;
            TxtPass.Focus();
        }

        private void Confirmation() {
            ConfirmService conf = new ConfirmService();
            DataTable userMan = conf.CheckMan();
            if (conf.ConfrimSave(userMan.Rows[0][2].ToString(), TxtPass.Text.Trim()) == true) {
                this.Close();
                edit.ConfirmSave();
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
