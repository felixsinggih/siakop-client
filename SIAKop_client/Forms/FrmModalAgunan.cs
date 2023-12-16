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
    public partial class FrmModalAgunan : Form {
        public string noAgun = "";
        public string idAgun = "";
        public string paripasu = "";
        public string bukti = "";
        public string asuransi = "";
        FrmKreditEdit edit;

        public FrmModalAgunan(FrmKreditEdit ed) {
            InitializeComponent();
            this.edit = ed;
        }

        private void FrmModalAgunan_Load(object sender, EventArgs e) {
            ComboBoxValue();
            LblNo.Text = ": " + noAgun;
            if (paripasu == "YA")
                CmbParipasu.SelectedIndex = 1;
            else if (paripasu == "TIDAK")
                CmbParipasu.SelectedIndex = 2;

            if (asuransi == "YA")
                CmbAsuransi.SelectedIndex = 1;
            else if (asuransi == "TIDAK")
                CmbAsuransi.SelectedIndex = 2;

            if (bukti == "BPKB")
                CmbKepemilikan.SelectedIndex = 1;
            else if (bukti == "SHM")
                CmbKepemilikan.SelectedIndex = 2;
            else if(bukti == "SHGB")
                CmbKepemilikan.SelectedIndex = 3;
            else if (bukti == "LAINNYA")
                CmbKepemilikan.SelectedIndex = 4;
        }

        private void ComboBoxValue() {
            Dictionary<string, string> ParipasuCombo = new Dictionary<string, string>();
            ParipasuCombo.Add("", "--- SILAHKAN PILIH ---");
            ParipasuCombo.Add("1", "YA");
            ParipasuCombo.Add("2", "TIDAK");
            CmbParipasu.DataSource = new BindingSource(ParipasuCombo, null);
            CmbParipasu.DisplayMember = "Value";
            CmbParipasu.ValueMember = "Key";

            Dictionary<string, string> AsuransiCombo = new Dictionary<string, string>();
            AsuransiCombo.Add("", "--- SILAHKAN PILIH ---");
            AsuransiCombo.Add("1", "YA");
            AsuransiCombo.Add("2", "TIDAK");
            CmbAsuransi.DataSource = new BindingSource(AsuransiCombo, null);
            CmbAsuransi.DisplayMember = "Value";
            CmbAsuransi.ValueMember = "Key";

            Dictionary<string, string> BuktiCombo = new Dictionary<string, string>();
            BuktiCombo.Add("", "--- SILAHKAN PILIH ---");
            BuktiCombo.Add("1", "BPKB");
            BuktiCombo.Add("2", "SHM");
            BuktiCombo.Add("3", "SHGB");
            BuktiCombo.Add("9", "LAINNYA");
            CmbKepemilikan.DataSource = new BindingSource(BuktiCombo, null);
            CmbKepemilikan.DisplayMember = "Value";
            CmbKepemilikan.ValueMember = "Key";
        }

        private void BtnEdit_Click(object sender, EventArgs e) {
            bool check = false;
            foreach (DataGridViewRow row in edit.DgvAgunan.Rows) {
                DateTime tglGrid = DateTime.Parse(row.Cells["tgl_penilaian"].Value.ToString());
                if (row.Cells["no"].Value.ToString() == noAgun && row.Cells["bank"].Value.ToString() == TxtBank.Text.Trim()
                    && row.Cells["independen"].Value.ToString() == TxtIndependen.Text.Trim() && row.Cells["njop"].Value.ToString() == TxtNjop.Text.Trim()
                    && tglGrid.ToString("yyyy-MM-dd") == DtpPenilaian.Value.ToString("yyyy-MM-dd") && row.Cells["penilai"].Value.ToString() == TxtPenilai.Text.Trim()
                    && row.Cells["paripasu_agun"].Value.ToString() == CmbParipasu.Text && row.Cells["pemilik"].Value.ToString() == TxtPemilik.Text.Trim()
                    && row.Cells["bukti"].Value.ToString() == CmbKepemilikan.Text && row.Cells["alm_agun"].Value.ToString() == TxtAlmAgunan.Text.Trim()
                    && row.Cells["dati_agun"].Value.ToString() == TxtDatiAgunan.Text.Trim() && row.Cells["asuransi_agun"].Value.ToString() == CmbAsuransi.Text) {
                    check = true;
                }
            }

            if (check == true) {
                MessageBox.Show("Tidak Ada Perubahan Data Dari Data Sumber", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                edit.DgvAgunanEdit.Rows.Add(noAgun, idAgun, TxtBank.Text.Trim(), TxtIndependen.Text.Trim(), TxtNjop.Text.Trim(), DtpPenilaian.Value.ToString("dd/MM/yyyy"),
                TxtPenilai.Text.Trim(), CmbParipasu.Text, TxtPemilik.Text.Trim(), CmbKepemilikan.Text, TxtAlmAgunan.Text.Trim(), TxtDatiAgunan.Text.Trim(),
                CmbAsuransi.Text);
                this.Close();
            }
        }
    }
}
