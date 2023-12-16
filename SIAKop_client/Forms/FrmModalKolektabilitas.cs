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

namespace SIAKop_client.Forms {
    public partial class FrmModalKolektabilitas : Form {
        public string noKolek = "";
        public string idKolek = "";
        public string tingkatKolek = "";
        private string tglKolek = "";
        FrmKreditEdit edit;

        public FrmModalKolektabilitas(FrmKreditEdit ed) {
            InitializeComponent();
            this.edit = ed;
        }

        private void FrmModalKolektabilitas_Load(object sender, EventArgs e) {
            ComboBoxValue();
            LblNo.Text = ": " + noKolek;
            if (tingkatKolek == "LANCAR")
                CmbKolek.SelectedIndex = 1;
            else if (tingkatKolek == "DALAM PERHATIAN KHUSUS")
                CmbKolek.SelectedIndex = 2;
            else if (tingkatKolek == "KURANG LANCAR")
                CmbKolek.SelectedIndex = 3;
            else if (tingkatKolek == "DIRAGUKAN")
                CmbKolek.SelectedIndex = 4;
            else if (tingkatKolek == "MACET")
                CmbKolek.SelectedIndex = 5;
        }

        private void ComboBoxValue() {
            Dictionary<string, string> KolekCombo = new Dictionary<string, string>();
            KolekCombo.Add("", "--- SILAHKAN PILIH ---");
            KolekCombo.Add("1", "LANCAR");
            KolekCombo.Add("2", "DALAM PERHATIAN KHUSUS");
            KolekCombo.Add("3", "KURANG LANCAR");
            KolekCombo.Add("4", "DIRAGUKAN");
            KolekCombo.Add("5", "MACET");
            CmbKolek.DataSource = new BindingSource(KolekCombo, null);
            CmbKolek.DisplayMember = "Value";
            CmbKolek.ValueMember = "Key";
        }

        private void DtpKolek_ValueChanged(object sender, EventArgs e) {
            DtpKolek.CustomFormat = "dd/MM/yyyy";
            tglKolek = DtpKolek.Value.ToString("yyyy-MM-dd");
        }

        private void DtpKolek_KeyDown(object sender, KeyEventArgs e) {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete)) {
                DtpKolek.CustomFormat = " ";
                tglKolek = "";
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e) {
            bool check = false;
            foreach (DataGridViewRow row in edit.DgvKolek.Rows) {
                DateTime tglGrid = DateTime.Parse(row.Cells["tgl_kolek"].Value.ToString());
                if (row.Cells["no_kolek"].Value.ToString() == noKolek && row.Cells["tingkat_kolek"].Value.ToString() == CmbKolek.Text
                    && row.Cells["hari_kolek"].Value.ToString() == TxtHariKolek.Text.Trim() && tglGrid.ToString("yyyy-MM-dd") == DtpKolek.Value.ToString("yyyy-MM-dd")) {
                    check = true;
                }
            }

            if (check == true) {
                MessageBox.Show("Tidak Ada Perubahan Data Dari Data Sumber", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                edit.DgvKolekEdit.Rows.Add(noKolek, idKolek, CmbKolek.Text, TxtHariKolek.Text.Trim(), DtpKolek.Value.ToString("dd/MM/yyyy"));
                this.Close();
            }
        }
    }
}
