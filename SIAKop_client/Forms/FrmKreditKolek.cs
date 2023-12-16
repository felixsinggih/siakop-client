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
    public partial class FrmKreditKolek : Form {
        KreditService kre = new KreditService();
        KolektabilitasService kol = new KolektabilitasService();
        public string idKredit;
        DataTable DetKre = new DataTable();
        DataTable DetKol = new DataTable();
        private string tglKondisi = "";
        private string tglSebab = "";
        private string tglKolek = "";
        FrmKreditDetail detail;

        public FrmKreditKolek(FrmKreditDetail det) {
            InitializeComponent();
            this.detail = det;
        }

        private void FrmKreditKolek_Load(object sender, EventArgs e) {
            ComboBoxValue();
            DisableElement();
            using (FrmWait frm = new FrmWait(DataKolek)) {
                frm.ShowDialog();
            }
        }

        private void ComboBoxValue() {
            Dictionary<string, string> KondisiCombo = new Dictionary<string, string>();
            KondisiCombo.Add("", "--- SILAHKAN PILIH ---");
            KondisiCombo.Add("00", "FASILITAS AKTIF");
            KondisiCombo.Add("01", "DIBATALKAN");
            KondisiCombo.Add("02", "LUNAS");
            KondisiCombo.Add("03", "DIHAPUSBUKUKAN");
            KondisiCombo.Add("04", "HAPUS TAGIH");
            KondisiCombo.Add("05", "LUNAS KARENA PENGAMBILALIHAN AGUNAN");
            KondisiCombo.Add("06", "LUNAS KARENA DISELESAIKAN MELALUI PENGADILAN");
            KondisiCombo.Add("07", "DIALIHKAN KE PELAPOR LAIN");
            KondisiCombo.Add("08", "DIALIHKAN KE FASILITAS LAIN");
            KondisiCombo.Add("09", "DIALIHKAN/DIJUAL KEPADA PIHAK NON PELAPOR");
            KondisiCombo.Add("10", "DISEKURITISASI (KREDITUR ASAL SEBAGAI SERVICER)");
            KondisiCombo.Add("11", "DISEKURITISASI (KREDITUR ASAL TIDAK SEBAGAI SERVICER)");
            KondisiCombo.Add("12", "LUNAS DENGAN DISKON");
            KondisiCombo.Add("13", "DIBLOKIR SEMENTARA");
            KondisiCombo.Add("14", "BERHENTI DARI KEANGGOTAAN KREDIT JOIN");
            CmbKondisi.DataSource = new BindingSource(KondisiCombo, null);
            CmbKondisi.DisplayMember = "Value";
            CmbKondisi.ValueMember = "Key";

            Dictionary<string, string> SebabCombo = new Dictionary<string, string>();
            SebabCombo.Add("", "--- SILAHKAN PILIH ---");
            SebabCombo.Add("01", "KESULITAN PEMASARAN");
            SebabCombo.Add("02", "KESULITAN MANAJEMEN DAN PERMASALAHAN TENAGA KERJA");
            SebabCombo.Add("03", "PERUSAHAAN GRUP/AFILIASI YANG SANGAT MERUGIKAN DEBITUR");
            SebabCombo.Add("04", "PERMASALAHAN TERKAIT PENGELOAAN LINGKUNGAN HIDUP");
            SebabCombo.Add("05", "PENGGUNAAN DANA TIDAK SESUAI SESUAI DENGAN PERJANJIAN");
            SebabCombo.Add("06", "KELEMAHAN DALAM ANALISA");
            SebabCombo.Add("07", "FLUKTUASI NILAI TUKAR");
            SebabCombo.Add("08", "ITIKAD TIDAK BAIK");
            SebabCombo.Add("09", "FORCE MAJEUR");
            SebabCombo.Add("10", "PAILIT");
            SebabCombo.Add("11", "UNIFORM CALSSIFICATION");
            SebabCombo.Add("12", "LAINNYA");
            CmbSebab.DataSource = new BindingSource(SebabCombo, null);
            CmbSebab.DisplayMember = "Value";
            CmbSebab.ValueMember = "Key";

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

        private void DisableElement() {
            TxtIdKredit.Enabled = false;
            TxtIdKredit.BackColor = Color.White;
            TxtSifat.Enabled = false;
            TxtSifat.BackColor = Color.White;
            TxtValuta.Enabled = false;
            TxtValuta.BackColor = Color.White;
            TxtBunga.Enabled = false;
            TxtBunga.BackColor = Color.White;
            TxtPlafon.Enabled = false;
            TxtPlafon.BackColor = Color.White;
            TxtSektor.Enabled = false;
            TxtSektor.BackColor = Color.White;
            TxtJenis.Enabled = false;
            TxtJenis.BackColor = Color.White;
            TxtAkad.Enabled = false;
            TxtAkad.BackColor = Color.White;
            TxtJatuh.Enabled = false;
            TxtJatuh.BackColor = Color.White;
            TxtPerpanjangan.Enabled = false;
            TxtPerpanjangan.BackColor = Color.White;
        }

        private void DataKolek() {
            DetKre = kre.SearchKreditById(idKredit);
            DetKol = kol.SearchByIdKredit(idKredit);

            DateTime tglLhr = DateTime.Parse(DetKre.Rows[0][3].ToString());
            DateTime tglAkad = DateTime.Parse(DetKre.Rows[0][35].ToString());
            DateTime tglJatuh = DateTime.Parse(DetKre.Rows[0][36].ToString());

            if (DetKre.Rows[0][32].ToString() != "") {
                DateTime Kondisi = DateTime.Parse(DetKre.Rows[0][32].ToString());
                DtpKondisi.Invoke(new MethodInvoker(delegate { DtpKondisi.CustomFormat = "dd/MM/yyyy"; }));
                DtpKondisi.Invoke(new MethodInvoker(delegate { DtpKondisi.Text = Kondisi.ToString("dd/MM/yyyy"); }));
            } 
            if (DetKre.Rows[0][34].ToString() != "") {
                DateTime Sebab = DateTime.Parse(DetKre.Rows[0][34].ToString());
                DtpSebab.Invoke(new MethodInvoker(delegate { DtpSebab.CustomFormat = "dd/MM/yyyy"; }));
                DtpSebab.Invoke(new MethodInvoker(delegate { DtpSebab.Text = Sebab.ToString("dd/MM/yyyy"); }));
            } 

            string Sifat = "";
            string Sektor = "";
            string Jenis = "";
            string Perpanjangan = "";

            if (DetKre.Rows[0][21].ToString() == "1")
                Sifat = "KREDIT/PEMBIAYAAN YANG DIRESTRUKTURISASI";
            else if (DetKre.Rows[0][21].ToString() == "2")
                Sifat = "PENGAMBILALIHAN KREDIT/PEMBIAYAAN";
            else if (DetKre.Rows[0][21].ToString() == "3")
                Sifat = "KREDIT/PEMBIAYAAN SUBORDINASI";
            else if (DetKre.Rows[0][21].ToString() == "9")
                Sifat = "LAINNYA";

            if (DetKre.Rows[0][29].ToString() == "1")
                Sektor = "PEGAWAI NEGERI";
            else if (DetKre.Rows[0][29].ToString() == "2")
                Sektor = "PEGAWAI SWASTA";
            else if (DetKre.Rows[0][29].ToString() == "3")
                Sektor = "WIRASWASTA";
            else if (DetKre.Rows[0][29].ToString() == "9")
                Sektor = "LAIN-LAIN";

            if (DetKre.Rows[0][29].ToString() == "0")
                Jenis = "KREDIT KONSUMSI";
            else if (DetKre.Rows[0][29].ToString() == "1")
                Jenis = "MODAL KERJA";
            else if (DetKre.Rows[0][29].ToString() == "2")
                Jenis = "INVESTASI";

            if (DetKre.Rows[0][37].ToString() == "0")
                Perpanjangan = "FASILITAS BARU";
            else if (DetKre.Rows[0][37].ToString() == "1")
                Perpanjangan = "FASILITAS DIPERPANJANG 1 KALI";
            else if (DetKre.Rows[0][37].ToString() == "2")
                Perpanjangan = "FASILITAS DIPERPANJANG 2 KALI";

            if (DetKre.Rows[0][31].ToString() == "00")
                CmbKondisi.Invoke(new MethodInvoker(delegate { CmbKondisi.SelectedIndex = 1; }));
            else if (DetKre.Rows[0][31].ToString() == "01")
                CmbKondisi.Invoke(new MethodInvoker(delegate { CmbKondisi.SelectedIndex = 2; }));
            else if (DetKre.Rows[0][31].ToString() == "02")
                CmbKondisi.Invoke(new MethodInvoker(delegate { CmbKondisi.SelectedIndex = 3; }));
            else if (DetKre.Rows[0][31].ToString() == "03")
                CmbKondisi.Invoke(new MethodInvoker(delegate { CmbKondisi.SelectedIndex = 4; }));
            else if (DetKre.Rows[0][31].ToString() == "04")
                CmbKondisi.Invoke(new MethodInvoker(delegate { CmbKondisi.SelectedIndex = 5; }));
            else if (DetKre.Rows[0][31].ToString() == "05")
                CmbKondisi.Invoke(new MethodInvoker(delegate { CmbKondisi.SelectedIndex = 6; }));
            else if (DetKre.Rows[0][31].ToString() == "06")
                CmbKondisi.Invoke(new MethodInvoker(delegate { CmbKondisi.SelectedIndex = 7; }));
            else if (DetKre.Rows[0][31].ToString() == "07")
                CmbKondisi.Invoke(new MethodInvoker(delegate { CmbKondisi.SelectedIndex = 8; }));
            else if (DetKre.Rows[0][31].ToString() == "08")
                CmbKondisi.Invoke(new MethodInvoker(delegate { CmbKondisi.SelectedIndex = 9; }));
            else if (DetKre.Rows[0][31].ToString() == "09")
                CmbKondisi.Invoke(new MethodInvoker(delegate { CmbKondisi.SelectedIndex = 10; }));
            else if (DetKre.Rows[0][31].ToString() == "10")
                CmbKondisi.Invoke(new MethodInvoker(delegate { CmbKondisi.SelectedIndex = 11; }));
            else if (DetKre.Rows[0][31].ToString() == "11")
                CmbKondisi.Invoke(new MethodInvoker(delegate { CmbKondisi.SelectedIndex = 12; }));
            else if (DetKre.Rows[0][31].ToString() == "12")
                CmbKondisi.Invoke(new MethodInvoker(delegate { CmbKondisi.SelectedIndex = 13; }));
            else if (DetKre.Rows[0][31].ToString() == "13")
                CmbKondisi.Invoke(new MethodInvoker(delegate { CmbKondisi.SelectedIndex = 14; }));
            else if (DetKre.Rows[0][31].ToString() == "14")
                CmbKondisi.Invoke(new MethodInvoker(delegate { CmbKondisi.SelectedIndex = 15; }));
            else
                CmbKondisi.Invoke(new MethodInvoker(delegate { CmbKondisi.SelectedIndex = 0; }));

            if (DetKre.Rows[0][33].ToString() == "01")
                CmbSebab.Invoke(new MethodInvoker(delegate { CmbSebab.SelectedIndex = 1; }));
            else if (DetKre.Rows[0][33].ToString() == "02")
                CmbSebab.Invoke(new MethodInvoker(delegate { CmbSebab.SelectedIndex = 2; }));
            else if (DetKre.Rows[0][33].ToString() == "03")
                CmbSebab.Invoke(new MethodInvoker(delegate { CmbSebab.SelectedIndex = 3; }));
            else if (DetKre.Rows[0][33].ToString() == "04")
                CmbSebab.Invoke(new MethodInvoker(delegate { CmbSebab.SelectedIndex = 4; }));
            else if (DetKre.Rows[0][33].ToString() == "05")
                CmbSebab.Invoke(new MethodInvoker(delegate { CmbSebab.SelectedIndex = 5; }));
            else if (DetKre.Rows[0][33].ToString() == "06")
                CmbSebab.Invoke(new MethodInvoker(delegate { CmbSebab.SelectedIndex = 6; }));
            else if (DetKre.Rows[0][33].ToString() == "07")
                CmbSebab.Invoke(new MethodInvoker(delegate { CmbSebab.SelectedIndex = 7; }));
            else if (DetKre.Rows[0][33].ToString() == "08")
                CmbSebab.Invoke(new MethodInvoker(delegate { CmbSebab.SelectedIndex = 8; }));
            else if (DetKre.Rows[0][33].ToString() == "09")
                CmbSebab.Invoke(new MethodInvoker(delegate { CmbSebab.SelectedIndex = 9; }));
            else if (DetKre.Rows[0][33].ToString() == "10")
                CmbSebab.Invoke(new MethodInvoker(delegate { CmbSebab.SelectedIndex = 10; }));
            else if (DetKre.Rows[0][33].ToString() == "11")
                CmbSebab.Invoke(new MethodInvoker(delegate { CmbSebab.SelectedIndex = 11; }));
            else if (DetKre.Rows[0][33].ToString() == "12")
                CmbSebab.Invoke(new MethodInvoker(delegate { CmbSebab.SelectedIndex = 12; }));
            else
                CmbSebab.Invoke(new MethodInvoker(delegate { CmbSebab.SelectedIndex = 0; }));

            LblDin.Invoke(new MethodInvoker(delegate { LblDin.Text = ": " + DetKre.Rows[0][0].ToString(); }));
            LblKtp.Invoke(new MethodInvoker(delegate { LblKtp.Text = ": " + DetKre.Rows[0][5].ToString(); }));
            LblNama.Invoke(new MethodInvoker(delegate { LblNama.Text = ": " + DetKre.Rows[0][1].ToString(); }));
            LblTempatLahir.Invoke(new MethodInvoker(delegate { LblTempatLahir.Text = ": " + DetKre.Rows[0][2].ToString() + "," + string.Format("{0 : dd MMMM yyyy}", tglLhr); }));
            LblAlias.Invoke(new MethodInvoker(delegate { LblAlias.Text = ": " + DetKre.Rows[0][8].ToString(); }));

            TxtIdKredit.Invoke(new MethodInvoker(delegate { TxtIdKredit.Text = DetKre.Rows[0][20].ToString(); }));
            TxtSifat.Invoke(new MethodInvoker(delegate { TxtSifat.Text = Sifat; }));
            TxtValuta.Invoke(new MethodInvoker(delegate { TxtValuta.Text = DetKre.Rows[0][22].ToString(); }));
            TxtBunga.Invoke(new MethodInvoker(delegate { TxtBunga.Text = DetKre.Rows[0][23].ToString(); }));
            TxtPlafon.Invoke(new MethodInvoker(delegate { TxtPlafon.Text = DetKre.Rows[0][24].ToString(); }));
            TxtDebet.Invoke(new MethodInvoker(delegate { TxtDebet.Text = DetKre.Rows[0][25].ToString(); }));
            TxtPokok.Invoke(new MethodInvoker(delegate { TxtPokok.Text = DetKre.Rows[0][26].ToString(); }));
            TxtFrekPokok.Invoke(new MethodInvoker(delegate { TxtFrekPokok.Text = DetKre.Rows[0][27].ToString(); }));
            TxtFrekBunga.Invoke(new MethodInvoker(delegate { TxtFrekBunga.Text = DetKre.Rows[0][28].ToString(); }));
            TxtSektor.Invoke(new MethodInvoker(delegate { TxtSektor.Text = Sektor; }));
            TxtJenis.Invoke(new MethodInvoker(delegate { TxtJenis.Text = Jenis; }));
            TxtAkad.Invoke(new MethodInvoker(delegate { TxtAkad.Text = tglAkad.ToString("dd/MM/yyyy"); }));
            TxtJatuh.Invoke(new MethodInvoker(delegate { TxtJatuh.Text = tglJatuh.ToString("dd/MM/yyyy"); }));
            TxtPerpanjangan.Invoke(new MethodInvoker(delegate { TxtPerpanjangan.Text = Perpanjangan; }));

        }

        private void DtpKondisi_ValueChanged(object sender, EventArgs e) {
            DtpKondisi.CustomFormat = "dd/MM/yyyy";
            tglKondisi = DtpKondisi.Value.ToString("yyyy-MM-dd");
        }

        private void DtpSebab_ValueChanged(object sender, EventArgs e) {
            DtpSebab.CustomFormat = "dd/MM/yyyy";
            tglSebab = DtpSebab.Value.ToString("yyyy-MM-dd");
        }

        private void DtpKolek_ValueChanged(object sender, EventArgs e) {
            DtpKolek.CustomFormat = "dd/MM/yyyy";
            tglKolek = DtpKolek.Value.ToString("yyyy-MM-dd");
        }

        private void DtpKondisi_KeyDown(object sender, KeyEventArgs e) {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete)) {
                DtpKondisi.CustomFormat = " ";
                tglKondisi = "";
            }
        }

        private void DtpSebab_KeyDown(object sender, KeyEventArgs e) {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete)) {
                DtpSebab.CustomFormat = " ";
                tglSebab = "";
            }
        }

        private void DtpKolek_KeyDown(object sender, KeyEventArgs e) {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete)) {
                DtpKolek.CustomFormat = " ";
                tglKolek = "";
            }
        }

        private void EditKredit() {
            string kondisi = "";
            string sebab = "";
            CmbKondisi.Invoke(new MethodInvoker(delegate { kondisi = ((KeyValuePair<string, string>)CmbKondisi.SelectedItem).Key; }));
            CmbSebab.Invoke(new MethodInvoker(delegate { sebab = ((KeyValuePair<string, string>)CmbSebab.SelectedItem).Key; }));
            string tglK = "";
            string tglS = "";
            if(DetKre.Rows[0][32].ToString() != "")
                tglK = DateTime.Parse(DetKre.Rows[0][32].ToString()).ToString("yyyy-MM-dd");
            if (DetKre.Rows[0][34].ToString() != "")
                tglS = DateTime.Parse(DetKre.Rows[0][34].ToString()).ToString("yyyy-MM-dd");

            if (DetKre.Rows[0][25].ToString() != TxtDebet.Text || DetKre.Rows[0][26].ToString() != TxtPokok.Text || DetKre.Rows[0][27].ToString() != TxtFrekPokok.Text 
                || DetKre.Rows[0][28].ToString() != TxtFrekBunga.Text || DetKre.Rows[0][31].ToString() != kondisi || tglK != tglKondisi 
                || DetKre.Rows[0][33].ToString() != sebab || tglS != tglSebab) {
                kre.BAKIDEBET = TxtDebet.Text.Trim();
                kre.POKOK = TxtPokok.Text.Trim();
                kre.FREKPOKOK = TxtFrekPokok.Text.Trim();
                kre.FREKBUNGA = TxtFrekBunga.Text.Trim();
                kre.KONDISI = kondisi;
                kre.TGLKONDISI = tglKondisi;
                kre.MACET = sebab;
                kre.TGLMACET = tglSebab;
                kre.UPDATED = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                kre.EditKolek(idKredit);

                string act = "Edit data kredit #" + idKredit;
                ActivityHistory(act);
            }

        }

        private void ActivityHistory(string act) {
            HistoryService his = new HistoryService();
            his.ID = AppSession._id_user;
            his.ACT = act;
            his.TIME = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            his.Add();
        }

        private void SaveKolek() {
            EditKredit();

            string tingkat = "";
            string act = "Input data kolektibilitas #" + idKredit;
            kol.IDKREDIT = idKredit;
            kol.IDUSER = AppSession._id_user;
            kol.IDKOLEK = kol.Kodegen(idKredit);
            CmbKolek.Invoke(new MethodInvoker(delegate { tingkat = ((KeyValuePair<string, string>)CmbKolek.SelectedItem).Key; }));
            kol.TINGKAT = tingkat;
            kol.HARI = TxtHariKolek.Text;
            kol.TGL = tglKolek;
            kol.CREATED = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            kol.UPDATED = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            kol.Add();
            ActivityHistory(act);
        }

        public void ConfirmSave() {
            if (BgWorker.IsBusy != true) {
                BgWorker.RunWorkerAsync();
            }
        }

        private void FindMonth(String month, String year) {
            String conMonth = "";
            if (month == "01") {
                conMonth = "Januari";
            } else if (month == "02") {
                conMonth = "Februari";
            } else if (month == "03") {
                conMonth = "Maret";
            } else if (month == "02") {
                conMonth = "Februari";
            } else if (month == "04") {
                conMonth = "April";
            } else if (month == "05") {
                conMonth = "Mei";
            } else if (month == "06") {
                conMonth = "Juni";
            } else if (month == "07") {
                conMonth = "Juli";
            } else if (month == "08") {
                conMonth = "Agustus";
            } else if (month == "09") {
                conMonth = "September";
            } else if (month == "10") {
                conMonth = "Oktober";
            } else if (month == "11") {
                conMonth = "November";
            } else if (month == "12") {
                conMonth = "Desember";
            }

            MessageBox.Show("Kolektibilitas Bulan " + conMonth + " " + year + " Sudah Ada Dalam Tabel Kolektibilitas!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DtpKolek.Focus();
        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e) {
            using (FrmWait frm = new FrmWait(SaveKolek)) {
                frm.ShowDialog();
            }
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            MessageBox.Show("Data Kolektabilitas Berhasil Disimpan", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            detail.RefreshKolek();
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e) {
            if (CmbKolek.SelectedIndex == 0) {
                MessageBox.Show("Kolom Tingkat Kolektabilitas Wajib Diisi", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbKolek.Focus();
            } else if (TxtHariKolek.Text.Trim() == "") {
                MessageBox.Show("Kolom Tunggakan Hari Wajib Diisi", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtHariKolek.Focus();
            } else if (tglKolek == "") {
                MessageBox.Show("Kolom Tanggal Wajib Diisi", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DtpKolek.Focus();
            } else {
                bool check = false;
                foreach (DataRow row in DetKol.Rows) {
                    DateTime tglGrid = DateTime.Parse(row[4].ToString());
                    string conTglGrid = tglGrid.ToString("yyyy-MM-dd");
                    if (tglKolek.Substring(5, 2) == conTglGrid.Substring(5, 2) && tglKolek.Substring(0, 4) == conTglGrid.Substring(0, 4)) {
                        check = true;
                    }
                }

                if (check == true) {
                    FindMonth(tglKolek.Substring(5, 2), tglKolek.Substring(0, 4));
                } else {
                    FrmConfirmKolek frm = new FrmConfirmKolek(this);
                    frm.ShowDialog();
                }
            }
        }
    }
}
