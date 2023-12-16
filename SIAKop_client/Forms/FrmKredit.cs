using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using SIAKop_client.Class;
using System.Globalization;
using System.Threading;
using FontAwesome.Sharp;

namespace SIAKop_client.Forms {
    public partial class FrmKredit : Form {
        AnggotaService ang = new AnggotaService();
        KreditService kre = new KreditService();
        AlamatService alm = new AlamatService();
        PekerjaanService pek = new PekerjaanService();
        KontakService kon = new KontakService();
        AgunanService agun = new AgunanService();
        KolektabilitasService kol = new KolektabilitasService();
        private string noAgnEdit = "";
        private int noAgn = 1;
        private int rowAgn = 0;
        private string tglKondisi = "";
        private string tglSebab = "";

        private string noKolekEdit = "";
        private int noKolek = 1;
        private int rowKolek = 0;
        private string tglKolek = "";

        public bool actAng = false;
        public string idAnggota;
        private string idKredit;
        DataTable DtAng = new DataTable();

        public string passConfirm;

        public FrmKredit() {
            InitializeComponent();
            CultureInfo ci = new CultureInfo("id-ID");
            Thread.CurrentThread.CurrentCulture = ci;
            Thread.CurrentThread.CurrentUICulture = ci;
        }

        private void FrmKredit_Load(object sender, EventArgs e) {
            ComboBoxValue();
            DataDummy();
        }

        public void SearchAnggota() {
            DtAng = ang.SearchAnggotaById(idAnggota);

            DateTime tglL = DateTime.Parse(DtAng.Rows[0][3].ToString());
            string jnsK = DtAng.Rows[0][4].ToString();

            TxtNama.Invoke(new MethodInvoker(delegate { TxtNama.Text = DtAng.Rows[0][1].ToString(); }));
            TxtTempatLahir.Invoke(new MethodInvoker(delegate { TxtTempatLahir.Text = DtAng.Rows[0][2].ToString(); }));
            DtpTglLahir.Invoke(new MethodInvoker(delegate { DtpTglLahir.Value = tglL; }));
            if (jnsK == "Laki-laki")
                RbLaki.Invoke(new MethodInvoker(delegate { RbLaki.Checked = true; }));
            else if (jnsK == "Perempuan")
                RbPerempuan.Invoke(new MethodInvoker(delegate { RbPerempuan.Checked = true; }));
            TxtKtp.Invoke(new MethodInvoker(delegate { TxtKtp.Text = DtAng.Rows[0][5].ToString(); }));
            TxtNpwp.Invoke(new MethodInvoker(delegate { TxtNpwp.Text = DtAng.Rows[0][6].ToString(); }));
            TxtPaspor.Invoke(new MethodInvoker(delegate { TxtPaspor.Text = DtAng.Rows[0][7].ToString(); }));
            TxtNama.Invoke(new MethodInvoker(delegate { TxtAlias.Text = DtAng.Rows[0][8].ToString(); }));
            TxtAlias.Invoke(new MethodInvoker(delegate { TxtIbu.Text = DtAng.Rows[0][9].ToString(); }));

            TxtTelp.Invoke(new MethodInvoker(delegate { TxtTelp.Text = DtAng.Rows[0][10].ToString(); }));
            TxtEmail.Invoke(new MethodInvoker(delegate { TxtEmail.Text = DtAng.Rows[0][11].ToString(); }));

            TxtAlm.Invoke(new MethodInvoker(delegate { TxtAlm.Text = DtAng.Rows[0][12].ToString(); }));
            TxtKel.Invoke(new MethodInvoker(delegate { TxtKel.Text = DtAng.Rows[0][13].ToString(); }));
            TxtKec.Invoke(new MethodInvoker(delegate { TxtKec.Text = DtAng.Rows[0][14].ToString(); }));
            TxtDati.Invoke(new MethodInvoker(delegate { TxtDati.Text = DtAng.Rows[0][15].ToString(); }));
            TxtKodePos.Invoke(new MethodInvoker(delegate { TxtKodePos.Text = DtAng.Rows[0][16].ToString(); }));
            if (DtAng.Rows[0][17].ToString() == "ID")
                CmbNegara.Invoke(new MethodInvoker(delegate { CmbNegara.SelectedIndex = 1; }));

            TxtKerja.Invoke(new MethodInvoker(delegate { TxtKerja.Text = DtAng.Rows[0][18].ToString(); }));
            TxtTempatKerja.Invoke(new MethodInvoker(delegate { TxtTempatKerja.Text = DtAng.Rows[0][19].ToString(); }));
            TxtBidUsaha.Invoke(new MethodInvoker(delegate { TxtBidUsaha.Text = DtAng.Rows[0][20].ToString(); }));
        }

        private void DataDummy() {
            TxtKtp.Text = "123";
            TxtNama.Text = "Jono";
            TxtAlias.Text = "Jono";
            TxtTempatLahir.Text = "Cilacap";
            DtpTglLahir.Text = "1987/05/03";
            RbLaki.Checked = true;
            TxtNpwp.Text = "-";
            TxtPaspor.Text = "-";
            TxtIbu.Text = "Jamilah";
            TxtTelp.Text = "085444111222";
            TxtEmail.Text = "joni@mail.com";
            TxtAlm.Text = "Jl Muria";
            TxtKel.Text = "Sidanegara";
            TxtKec.Text = "Cilacap Tengah";
            TxtDati.Text = "Cilacap";
            TxtKodePos.Text = "53223";
            CmbNegara.SelectedIndex = 1;
            TxtKerja.Text = "Konsultan";
            TxtTempatKerja.Text = "PT ABC";
            TxtBidUsaha.Text = "Bidang ABC";

            CmbSifat.SelectedIndex = 2;
            TxtBunga.Text = "12.5";
            TxtPlafon.Text = "25000000";
            TxtDebet.Text = "6500000";
            TxtPokok.Text = "0";
            TxtFrekPokok.Text = "0";
            TxtFrekBunga.Text = "0";
            CmbSektor.SelectedIndex = 2;
            CmbJenis.SelectedIndex = 1;
            CmbKondisi.SelectedIndex = 1;
            DtpKondisi.Text = "2017/09/06";
            CmbSebab.SelectedIndex = 3;
            DtpSebab.Text = "2020/05/06";
            CmbBaruPerpanjang.SelectedIndex = 1;
            DtpAkad.Text = "2017/09/06";
            DtpJatuh.Text = "2022/09/06";

            DgvKolek.Rows.Add("1", "LANCAR", "0", "06/10/2017");

            DgvAgunan.Rows.Add("1", "22500000", "225000000", "22000000", "02/09/2017", "Ani", "TIDAK", "Anwar", "BPKB", "Jl Muria", "Cilacap", "TIDAK");
            DgvAgunan.Rows.Add("2", "22500000", "225000000", "22000000", "02/09/2017", "Warsan", "TIDAK", "Ganjar", "BPKB", "Jl Muria", "Cilacap", "TIDAK");
            DgvAgunan.Rows.Add("3", "22500000", "225000000", "22000000", "02/09/2017", "Tumiran", "TIDAK", "Bawor", "BPKB", "Jl Muria", "Cilacap", "TIDAK");
            DgvAgunan.Rows.Add("4", "22500000", "225000000", "22000000", "02/09/2017", "Jatmiko", "TIDAK", "Siwar", "BPKB", "Jl Muria", "Cilacap", "TIDAK");
        }

        private void ComboBoxValue() {
            TxtValuta.Text = "IDR";
            TxtValuta.Enabled = false;

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

            Dictionary<string, string> BaruCombo = new Dictionary<string, string>();
            BaruCombo.Add("", "--- SILAHKAN PILIH ---");
            BaruCombo.Add("0", "FASILITAS BARU");
            BaruCombo.Add("1", "FASILITAS DIPERPANJANG 1 KALI");
            BaruCombo.Add("2", "FASILITAS DIPERPANJANG 2 KALI");
            CmbBaruPerpanjang.DataSource = new BindingSource(BaruCombo, null);
            CmbBaruPerpanjang.DisplayMember = "Value";
            CmbBaruPerpanjang.ValueMember = "Key";

            Dictionary<string, string> SektorCombo = new Dictionary<string, string>();
            SektorCombo.Add("", "--- SILAHKAN PILIH ---");
            SektorCombo.Add("1", "PEGAWAI NEGERI");
            SektorCombo.Add("2", "PEGAWAI SWASTA");
            SektorCombo.Add("3", "WIRASWASTA");
            SektorCombo.Add("9", "LAIN-LAIN");
            CmbSektor.DataSource = new BindingSource(SektorCombo, null);
            CmbSektor.DisplayMember = "Value";
            CmbSektor.ValueMember = "Key";

            Dictionary<string, string> JenisCombo = new Dictionary<string, string>();
            JenisCombo.Add("", "--- SILAHKAN PILIH ---");
            JenisCombo.Add("0", "KREDIT KONSUMSI");
            JenisCombo.Add("1", "MODAL KERJA");
            JenisCombo.Add("2", "INVESTASI");
            CmbJenis.DataSource = new BindingSource(JenisCombo, null);
            CmbJenis.DisplayMember = "Value";
            CmbJenis.ValueMember = "Key";

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

            Dictionary<string, string> SifatCombo = new Dictionary<string, string>();
            SifatCombo.Add("", "--- SILAHKAN PILIH ---");
            SifatCombo.Add("1", "KREDIT/PEMBIAYAAN YANG DIRESTRUKTURISASI");
            SifatCombo.Add("2", "PENGAMBILALIHAN KREDIT/PEMBIAYAAN");
            SifatCombo.Add("3", "KREDIT/PEMBIAYAAN SUBORDINASI");
            SifatCombo.Add("9", "LAINNYA");
            CmbSifat.DataSource = new BindingSource(SifatCombo, null);
            CmbSifat.DisplayMember = "Value";
            CmbSifat.ValueMember = "Key";

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

            Dictionary<string, string> NegaraCombo = new Dictionary<string, string>();
            NegaraCombo.Add("", "--- SILAHKAN PILIH ---");
            NegaraCombo.Add("ID", "INDONESIA");
            CmbNegara.DataSource = new BindingSource(NegaraCombo, null);
            CmbNegara.DisplayMember = "Value";
            CmbNegara.ValueMember = "Key";

            BtnEditKolek.Visible = false;
            BtnEditAgn.Visible = false;
        }

        // CLEAR
        private void Reset() {
            idAnggota = "";
            actAng = false;
            TxtKtp.Text = "";
            TxtNama.Text = "";
            TxtTempatLahir.Text = "";
            RbLaki.Checked = false;
            RbPerempuan.Checked = false;
            TxtNpwp.Text = "";
            TxtPaspor.Text = "";
            TxtAlias.Text = "";
            TxtIbu.Text = "";
            TxtTelp.Text = "";
            TxtEmail.Text = "";
            TxtAlm.Text = "";
            TxtKel.Text = "";
            TxtKec.Text = "";
            TxtDati.Text = "";
            TxtKodePos.Text = "";
            CmbNegara.SelectedIndex = 0;
            TxtKerja.Text = "";
            TxtTempatKerja.Text = "";
            TxtBidUsaha.Text = "";

            CmbSifat.SelectedIndex = 0;
            TxtBunga.Text = "";
            TxtPlafon.Text = "";
            TxtDebet.Text = "";
            TxtPokok.Text = "";
            TxtFrekPokok.Text = "";
            TxtFrekBunga.Text = "";
            CmbSektor.SelectedIndex = 0;
            CmbJenis.SelectedIndex = 0;
            CmbKondisi.Text = "";
            DtpKondisi.CustomFormat = " ";
            tglKondisi = "";
            DtpSebab.CustomFormat = " ";
            tglSebab = "";
            CmbBaruPerpanjang.SelectedIndex = 0;

            DgvKolek.Rows.Clear();
            DgvAgunan.Rows.Clear();
        }

        private void ClearAgn() {
            TxtBank.Text = "";
            TxtIndependen.Text = "";
            TxtNjop.Text = "";
            DtpPenilaian.Value = DateTime.Now;
            TxtPenilai.Text = "";
            TxtPemilik.Text = "";
            TxtAlmAgunan.Text = "";
            TxtDatiAgunan.Text = "";
            CmbParipasu.SelectedIndex = 0;
            CmbKepemilikan.SelectedIndex = 0;
            CmbAsuransi.SelectedIndex = 0;
        }

        private void ClearKolek() {
            CmbKolek.SelectedIndex = 0;
            TxtHariKolek.Text = "";
            DtpKolek.CustomFormat = " ";
            tglKolek = "";
        }

        private void ClearData() {
            idAnggota = "";
            idKredit = "";
            actAng = false;
            TxtKtp.Invoke(new MethodInvoker(delegate { TxtKtp.Text = ""; }));
            TxtNama.Invoke(new MethodInvoker(delegate { TxtNama.Text = ""; }));
            TxtTempatLahir.Invoke(new MethodInvoker(delegate { TxtTempatLahir.Text = ""; }));
            RbLaki.Invoke(new MethodInvoker(delegate { RbLaki.Checked = false; }));
            RbPerempuan.Invoke(new MethodInvoker(delegate { RbPerempuan.Checked = false; }));
            TxtNpwp.Invoke(new MethodInvoker(delegate { TxtNpwp.Text = ""; }));
            TxtPaspor.Invoke(new MethodInvoker(delegate { TxtPaspor.Text = ""; }));
            TxtAlias.Invoke(new MethodInvoker(delegate { TxtAlias.Text = ""; }));
            TxtIbu.Invoke(new MethodInvoker(delegate { TxtIbu.Text = ""; }));
            TxtTelp.Invoke(new MethodInvoker(delegate { TxtTelp.Text = ""; }));
            TxtEmail.Invoke(new MethodInvoker(delegate { TxtEmail.Text = ""; }));
            TxtAlm.Invoke(new MethodInvoker(delegate { TxtAlm.Text = ""; }));
            TxtKel.Invoke(new MethodInvoker(delegate { TxtKel.Text = ""; }));
            TxtKec.Invoke(new MethodInvoker(delegate { TxtKec.Text = ""; }));
            TxtDati.Invoke(new MethodInvoker(delegate { TxtDati.Text = ""; }));
            TxtKodePos.Invoke(new MethodInvoker(delegate { TxtKodePos.Text = ""; }));
            CmbNegara.Invoke(new MethodInvoker(delegate { CmbNegara.SelectedIndex = 0; }));
            TxtKerja.Invoke(new MethodInvoker(delegate { TxtKerja.Text = ""; }));
            TxtTempatKerja.Invoke(new MethodInvoker(delegate { TxtTempatKerja.Text = ""; }));
            TxtBidUsaha.Invoke(new MethodInvoker(delegate { TxtBidUsaha.Text = ""; }));

            CmbSifat.Invoke(new MethodInvoker(delegate { CmbSifat.SelectedIndex = 0; }));
            CmbSektor.Invoke(new MethodInvoker(delegate { CmbSektor.SelectedIndex = 0; }));
            CmbJenis.Invoke(new MethodInvoker(delegate { CmbJenis.SelectedIndex = 0; }));
            CmbKondisi.Invoke(new MethodInvoker(delegate { CmbKondisi.SelectedIndex = 0; }));
            CmbSebab.Invoke(new MethodInvoker(delegate { CmbSebab.SelectedIndex = 0; }));
            CmbBaruPerpanjang.Invoke(new MethodInvoker(delegate { CmbBaruPerpanjang.SelectedIndex = 0; }));
            TxtBunga.Invoke(new MethodInvoker(delegate { TxtBunga.Text = ""; }));
            TxtPlafon.Invoke(new MethodInvoker(delegate { TxtPlafon.Text = ""; }));
            TxtDebet.Invoke(new MethodInvoker(delegate { TxtDebet.Text = ""; }));
            TxtPokok.Invoke(new MethodInvoker(delegate { TxtPokok.Text = ""; }));
            TxtFrekPokok.Invoke(new MethodInvoker(delegate { TxtFrekPokok.Text = ""; }));
            TxtFrekBunga.Invoke(new MethodInvoker(delegate { TxtFrekBunga.Text = ""; }));

            DgvKolek.Invoke(new MethodInvoker(delegate { DgvKolek.Rows.Clear(); }));
            DgvAgunan.Invoke(new MethodInvoker(delegate { DgvAgunan.Rows.Clear(); }));

            TabControl.Invoke(new MethodInvoker(delegate { TabControl.SelectedIndex = 0; }));
            TxtKtp.Invoke(new MethodInvoker(delegate { TxtKtp.Focus(); }));
        }
        // END CLEAR

        // DATAGRID BUTTON
        private void BtnAddAgn_Click(object sender, EventArgs e) {
            if (TxtBank.Text.Trim() == "") {
                MessageBox.Show("Kolom Nilai Bank Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtBank.Focus();
            } else if (((KeyValuePair<string, string>)CmbParipasu.SelectedItem).Key == "") {
                MessageBox.Show("Kolom Paripasu Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbParipasu.Focus();
            } else if (TxtPemilik.Text.Trim() == "") {
                MessageBox.Show("Kolom Nama Pemilik Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtPemilik.Focus();
            } else if (((KeyValuePair<string, string>)CmbKepemilikan.SelectedItem).Key == "") {
                MessageBox.Show("Kolom Bukti Kepemilikan Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbKepemilikan.Focus();
            } else if (TxtAlmAgunan.Text.Trim() == "") {
                MessageBox.Show("Kolom Alamat Jaminan Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtAlmAgunan.Focus();
            } else if (TxtDatiAgunan.Text.Trim() == "") {
                MessageBox.Show("Kolom Dati II Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtDatiAgunan.Focus();
            } else if (((KeyValuePair<string, string>)CmbAsuransi.SelectedItem).Key == "") {
                MessageBox.Show("Kolom Asuransi Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbAsuransi.Focus();
            } else {
                DgvAgunan.Rows.Add(noAgn, TxtBank.Text, TxtIndependen.Text, TxtNjop.Text, DtpPenilaian.Value.ToString("dd/MM/yyyy"), TxtPenilai.Text, CmbParipasu.Text, TxtPemilik.Text, CmbKepemilikan.Text, TxtAlmAgunan.Text, TxtDatiAgunan.Text, CmbAsuransi.Text);
                noAgn = noAgn + 1;
                ClearAgn();
            }
        }

        private void BtnEditAgn_Click(object sender, EventArgs e) {
            if (TxtBank.Text.Trim() == "") {
                MessageBox.Show("Kolom Nilai Bank Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtBank.Focus();
            } else if (CmbParipasu.Text == "") {
                MessageBox.Show("Kolom Paripasu Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbParipasu.Focus();
            } else if (TxtPemilik.Text.Trim() == "") {
                MessageBox.Show("Kolom Nama Pemilik Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtPemilik.Focus();
            } else if (CmbKepemilikan.Text == "") {
                MessageBox.Show("Kolom Bukti Kepemilikan Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbKepemilikan.Focus();
            } else if (TxtAlmAgunan.Text.Trim() == "") {
                MessageBox.Show("Kolom Alamat Jaminan Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtAlmAgunan.Focus();
            } else if (TxtDatiAgunan.Text.Trim() == "") {
                MessageBox.Show("Kolom Dati II Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtDatiAgunan.Focus();
            } else if (CmbAsuransi.Text == "") {
                MessageBox.Show("Kolom Asuransi Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbAsuransi.Focus();
            } else {
                DgvAgunan.Rows[rowAgn].SetValues(noAgnEdit, TxtBank.Text, TxtIndependen.Text, TxtNjop.Text, DtpPenilaian.Value.ToString("dd/MM/yyyy"), TxtPenilai.Text, CmbParipasu.Text, TxtPemilik.Text, CmbKepemilikan.Text, TxtAlmAgunan.Text, TxtDatiAgunan.Text, CmbAsuransi.Text);
                BtnEditAgn.Visible = false;
                BtnAddAgn.Visible = true;
                ClearAgn();
            }
        }

        private void FindMonth(String month, String year) {
            String conMonth = "";
            if(month == "01") {
                conMonth = "Januari";
            }else if (month == "02") {
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

        private void BtnAddKolek_Click(object sender, EventArgs e) {
            if (((KeyValuePair<string, string>)CmbKolek.SelectedItem).Key == "") {
                MessageBox.Show("Kolom Tingkat Kolektabilitas Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbKolek.Focus();
            } else if (TxtHariKolek.Text.Trim() == "") {
                MessageBox.Show("Kolom Tunggakan Hari Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtHariKolek.Focus();
            } else if (tglKolek == "") {
                MessageBox.Show("Kolom Tanggal Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DtpKolek.Focus();
            } else {
                bool check = false;
                foreach (DataGridViewRow row in DgvKolek.Rows) {
                    DateTime tglGrid = DateTime.Parse(row.Cells["tgl_kolek"].Value.ToString());
                    string conTglGrid = tglGrid.ToString("yyyy-MM-dd");
                    if (tglKolek.Substring(5, 2) == conTglGrid.Substring(5, 2) && tglKolek.Substring(0, 4) == conTglGrid.Substring(0, 4)) {
                        check = true;
                    }
                }

                if (check == true) {
                    FindMonth(tglKolek.Substring(5, 2), tglKolek.Substring(0, 4));
                } else {
                    DgvKolek.Rows.Add(noKolek, CmbKolek.Text, TxtHariKolek.Text, DtpKolek.Value.ToString("dd/MM/yyyy"));
                    noKolek = noKolek + 1;
                    ClearKolek();
                }
            }
        }

        private void BtnEditKolek_Click(object sender, EventArgs e) {
            if (((KeyValuePair<string, string>)CmbKolek.SelectedItem).Key == "") {
                MessageBox.Show("Kolom Tingkat Kolektabilitas Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CmbKolek.Focus();
            } else if (TxtHariKolek.Text.Trim() == "") {
                MessageBox.Show("Kolom Tunggakan Hari Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TxtHariKolek.Focus();
            } else if (tglKolek == "") {
                MessageBox.Show("Kolom Tanggal Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DtpKolek.Focus();
            } else {
                bool check = false;
                int i = 0;
                foreach (DataGridViewRow row in DgvKolek.Rows) {
                    DateTime tglGrid = DateTime.Parse(row.Cells["tgl_kolek"].Value.ToString());
                    string conTglGrid = tglGrid.ToString("yyyy-MM-dd");
                    if (tglKolek.Substring(5, 2) == conTglGrid.Substring(5, 2) && tglKolek.Substring(0, 4) == conTglGrid.Substring(0, 4)) {
                        if (rowKolek != i) {
                            check = true;
                        }
                    }
                    i++;
                }

                if (check == true) {
                    FindMonth(tglKolek.Substring(5, 2), tglKolek.Substring(0, 4));
                } else {
                    DgvKolek.Rows[rowKolek].SetValues(noKolekEdit, CmbKolek.Text, TxtHariKolek.Text, DtpKolek.Value.ToString("dd/MM/yyyy"));
                    BtnEditKolek.Visible = false;
                    BtnAddKolek.Visible = true;
                    ClearKolek();
                }
            }
        }
        // END DATAGRID BUTTON

        // DATAGRID CONTENT CELL CLICK
        private void DgvAgunan_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (DgvAgunan.Columns[e.ColumnIndex].Name == "hapus") {
                DataGridViewRow row = this.DgvAgunan.Rows[e.RowIndex];
                DgvAgunan.Rows.Remove(DgvAgunan.Rows[e.RowIndex]);
            }

            if (DgvAgunan.Columns[e.ColumnIndex].Name == "edit") {
                DataGridViewRow row = this.DgvAgunan.Rows[e.RowIndex];

                if (row.Cells["paripasu"].Value.ToString() == "YA") {
                    CmbParipasu.SelectedIndex = 1;
                } else if (row.Cells["paripasu"].Value.ToString() == "TIDAK") {
                    CmbParipasu.SelectedIndex = 2;
                }

                if (row.Cells["bukti"].Value.ToString() == "BPKB") {
                    CmbKepemilikan.SelectedIndex = 1;
                } else if (row.Cells["bukti"].Value.ToString() == "SHM") {
                    CmbKepemilikan.SelectedIndex = 2;
                } else if (row.Cells["bukti"].Value.ToString() == "SHGB") {
                    CmbKepemilikan.SelectedIndex = 3;
                } else if (row.Cells["bukti"].Value.ToString() == "LAINNYA") {
                    CmbKepemilikan.SelectedIndex = 4;
                }

                if (row.Cells["asuransi_agn"].Value.ToString() == "YA") {
                    CmbAsuransi.SelectedIndex = 1;
                } else if (row.Cells["asuransi_agn"].Value.ToString() == "TIDAK") {
                    CmbAsuransi.SelectedIndex = 2;
                }

                noAgnEdit = row.Cells["no"].Value.ToString();
                TxtBank.Text = row.Cells["bank"].Value.ToString();
                TxtIndependen.Text = row.Cells["independen"].Value.ToString();
                TxtNjop.Text = row.Cells["njop"].Value.ToString();
                DtpPenilaian.Text = row.Cells["tgl_penilaian"].Value.ToString();
                TxtPenilai.Text = row.Cells["penilai"].Value.ToString();
                TxtPemilik.Text = row.Cells["pemilik"].Value.ToString();
                TxtAlmAgunan.Text = row.Cells["alm_agunan"].Value.ToString();
                TxtDatiAgunan.Text = row.Cells["dati_agunan"].Value.ToString();
                rowAgn = e.RowIndex;
                BtnEditAgn.Visible = true;
                BtnAddAgn.Visible = false;
            }
        }

        private void DgvKolek_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (DgvKolek.Columns[e.ColumnIndex].Name == "hapus_kolek") {
                DataGridViewRow row = this.DgvKolek.Rows[e.RowIndex];
                DgvKolek.Rows.Remove(DgvKolek.Rows[e.RowIndex]);
            }

            if (DgvKolek.Columns[e.ColumnIndex].Name == "edit_kolek") {
                DataGridViewRow row = this.DgvKolek.Rows[e.RowIndex];

                if (row.Cells["tingkat_kolek"].Value.ToString() == "LANCAR") {
                    CmbKolek.SelectedIndex = 1;
                } else if (row.Cells["tingkat_kolek"].Value.ToString() == "DALAM PERHATIAN KHUSUS") {
                    CmbKolek.SelectedIndex = 2;
                } else if (row.Cells["tingkat_kolek"].Value.ToString() == "KURANG LANCAR") {
                    CmbKolek.SelectedIndex = 3;
                } else if (row.Cells["tingkat_kolek"].Value.ToString() == "DIRAGUKAN") {
                    CmbKolek.SelectedIndex = 4;
                } else if (row.Cells["tingkat_kolek"].Value.ToString() == "MACET") {
                    CmbKolek.SelectedIndex = 5;
                }

                noKolekEdit = row.Cells["no_kolek"].Value.ToString();
                TxtHariKolek.Text = row.Cells["hari_kolek"].Value.ToString();
                tglKolek= row.Cells["tgl_kolek"].Value.ToString();
                DtpKolek.CustomFormat = "dd/MM/yyyy";
                DtpKolek.Text = tglKolek;
                rowKolek = e.RowIndex;
                BtnEditKolek.Visible = true;
                BtnAddKolek.Visible = false;
            }
        }
        // END DATAGRID CONTENT CELL CLICK

        //DATEPICKER
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
        // END DATEPICKER

        // STORE DATA
        private void ValidateSave() {
            if (TxtKtp.Text.Trim() == "") {
                MessageBox.Show("Kolom Nomor KTP Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TabControl.SelectTab("TabDebitur");
                TxtKtp.Focus();
            } else if (TxtNama.Text.Trim() == "") {
                MessageBox.Show("Kolom Nama Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TabControl.SelectTab("TabDebitur");
                TxtNama.Focus();
            } else if (TxtTempatLahir.Text.Trim() == "") {
                MessageBox.Show("Kolom Tempat Lahir Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TabControl.SelectTab("TabDebitur");
                TxtTempatLahir.Focus();
            } else if (TxtIbu.Text.Trim() == "") {
                MessageBox.Show("Kolom Nama Ibu Kandung Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TabControl.SelectTab("TabDebitur");
                TxtIbu.Focus();
            } else if (TxtTelp.Text.Trim() == "") {
                MessageBox.Show("Kolom Nomor Telepon Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TabControl.SelectTab("TabDebitur");
                TxtTelp.Focus();
            } else if (TxtAlm.Text.Trim() == "") {
                MessageBox.Show("Kolom Alamat Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TabControl.SelectTab("TabDebitur"); 
                TxtAlm.Focus();
            } else if (TxtKel.Text.Trim() == "") {
                MessageBox.Show("Kolom Kelurahan Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TabControl.SelectTab("TabDebitur"); 
                TxtKel.Focus();
            } else if (TxtKec.Text.Trim() == "") {
                MessageBox.Show("Kolom Kecamatan Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TabControl.SelectTab("TabDebitur"); 
                TxtKec.Focus();
            } else if (TxtDati.Text.Trim() == "") {
                MessageBox.Show("Kolom Dati II Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TabControl.SelectTab("TabDebitur"); 
                TxtDati.Focus();
            } else if (TxtKodePos.Text.Trim() == "") {
                MessageBox.Show("Kolom Kode Pos Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TabControl.SelectTab("TabDebitur"); 
                TxtKodePos.Focus();
            } else if (((KeyValuePair<string, string>)CmbNegara.SelectedItem).Key == "") {
                MessageBox.Show("Kolom Negara Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TabControl.SelectTab("TabDebitur"); 
                CmbNegara.Focus();
            } else if (TxtKerja.Text.Trim() == "") {
                MessageBox.Show("Kolom Pekerjaan Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TabControl.SelectTab("TabDebitur"); 
                TxtKerja.Focus();
            } else if (((KeyValuePair<string, string>)CmbSifat.SelectedItem).Key == "") {
                MessageBox.Show("Kolom Sifat Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TabControl.SelectTab("TabKredit"); 
                CmbSifat.Focus();
            } else if (TxtBunga.Text.Trim() == "") {
                MessageBox.Show("Kolom Bunga Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TabControl.SelectTab("TabKredit"); 
                TxtBunga.Focus();
            } else if (TxtDebet.Text.Trim() == "") {
                MessageBox.Show("Kolom Baki Debet Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TabControl.SelectTab("TabKredit"); 
                TxtDebet.Focus();
            } else if (TxtPokok.Text.Trim() == "") {
                MessageBox.Show("Kolom Tunggakan Pokok Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TabControl.SelectTab("TabKredit"); 
                TxtPokok.Focus();
            } else if (TxtFrekPokok.Text.Trim() == "") {
                MessageBox.Show("Kolom Jumlah Tunggakan Pokok / Bunga (Bulan) KTP Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TabControl.SelectTab("TabKredit");
                TxtFrekPokok.Focus();
            } else if (CmbSektor.Text.Trim() == "") {
                MessageBox.Show("Kolom Sektor Ekonomi Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TabControl.SelectTab("TabKredit"); 
                CmbSektor.Focus();
            } else if (CmbJenis.Text.Trim() == "") {
                MessageBox.Show("Kolom Jenis Kredit Wajib Diisi!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TabControl.SelectTab("TabKredit"); 
                CmbJenis.Focus();
            } else {
                FrmConfirmKredit frm = new FrmConfirmKredit(this);
                if (actAng == false) {
                    if (ang.CekKtp(TxtKtp.Text.Trim()) == "") {
                        if (MessageBox.Show("Apakah Anda Yakin Akan Menyimpan Data Tersebut?", "Pesan", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                            frm.ShowDialog();
                        }
                    } else {
                        MessageBox.Show("Nomor KTP Sudah Digunakan!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else {
                    if (MessageBox.Show("Apakah Anda Yakin Akan Menyimpan Data Tersebut?", "Pesan", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                        frm.ShowDialog();
                    }
                }
            }
        }

        private void SaveData() {
            if(actAng == false)
                idAnggota = ang.Kodegen();
            idKredit = kre.Kodegen();

            string negara = "";
            string sifat = "";
            string sektor = "";
            string jenis = "";
            string kondisi = "";
            string macet = "";
            string perpanjangan = "";

            if (actAng == false) {
                ang.IDANG = idAnggota;
                ang.NAMA = TxtNama.Text.Trim();
                ang.TEMPAT = TxtTempatLahir.Text.Trim();
                ang.TANGGAL = DtpTglLahir.Value.ToString("yyyy-MM-dd");
                if (RbLaki.Checked == true)
                    ang.JENIS = RbLaki.Text;
                if (RbPerempuan.Checked == true)
                    ang.JENIS = RbPerempuan.Text;
                ang.KTP = TxtKtp.Text.Trim();
                ang.NPWP = TxtNpwp.Text.Trim();
                ang.PASPOR = TxtPaspor.Text.Trim();
                ang.ALIAS = TxtAlias.Text.Trim();
                ang.IBU = TxtIbu.Text.Trim();
                ang.CREATED = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                ang.UPDATED = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                ang.Add();
                string act = "Input data debitur #" + idAnggota;
                ActivityHistory(act);
            } else {
                DateTime tgl = DateTime.Parse(DtAng.Rows[0][3].ToString());
                string jnsK = "";
                if (RbLaki.Checked == true)
                    jnsK = RbLaki.Text;
                else if (RbPerempuan.Checked == true)
                    jnsK = RbPerempuan.Text;
                if (DtAng.Rows[0][1].ToString() != TxtNama.Text.Trim() || DtAng.Rows[0][2].ToString() != TxtTempatLahir.Text.Trim()
                    || tgl.ToString("yyyy-MM-dd") != DtpTglLahir.Value.ToString("yyyy-MM-dd") || DtAng.Rows[0][4].ToString() != jnsK
                    || DtAng.Rows[0][5].ToString() != TxtKtp.Text.Trim() || DtAng.Rows[0][6].ToString() != TxtNpwp.Text.Trim()
                    || DtAng.Rows[0][7].ToString() != TxtPaspor.Text.Trim() || DtAng.Rows[0][8].ToString() != TxtAlias.Text.Trim()
                    || DtAng.Rows[0][9].ToString() != TxtIbu.Text.Trim()) {
                    ang.NAMA = TxtNama.Text.Trim();
                    ang.TEMPAT = TxtTempatLahir.Text.Trim();
                    ang.TANGGAL = DtpTglLahir.Value.ToString("yyyy-MM-dd");
                    if (RbLaki.Checked == true)
                        ang.JENIS = RbLaki.Text;
                    if (RbPerempuan.Checked == true)
                        ang.JENIS = RbPerempuan.Text;
                    ang.KTP = TxtKtp.Text.Trim();
                    ang.NPWP = TxtNpwp.Text.Trim();
                    ang.PASPOR = TxtPaspor.Text.Trim();
                    ang.ALIAS = TxtAlias.Text.Trim();
                    ang.IBU = TxtIbu.Text.Trim();
                    ang.UPDATED = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    ang.Edit(idAnggota);
                    string act = "Edit data debitur #" + idAnggota;
                    ActivityHistory(act);
                }
            }

            if (actAng == false) {
                kon.ID = idAnggota;
                kon.TELP = TxtTelp.Text;
                kon.EMAIL = TxtEmail.Text;
                kon.CREATED = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                kon.UPDATED = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                kon.Add();
            } else {
                if (DtAng.Rows[0][10].ToString() != TxtTelp.Text.Trim() || DtAng.Rows[0][11].ToString() != TxtEmail.Text.Trim()) {
                    kon.TELP = TxtTelp.Text;
                    kon.EMAIL = TxtEmail.Text;
                    kon.UPDATED = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    kon.Edit(idAnggota);
                    string act = "Edit data kontak debitur #" + idAnggota;
                    ActivityHistory(act);
                }
            }

            CmbNegara.Invoke(new MethodInvoker(delegate { negara = ((KeyValuePair<string, string>)CmbNegara.SelectedItem).Key; }));
            if (actAng == false) {
                alm.ID = idAnggota;
                alm.ALM = TxtAlm.Text.Trim();
                alm.KEL = TxtKel.Text.Trim();
                alm.KEC = TxtKec.Text.Trim();
                alm.DATI2 = TxtDati.Text.Trim();
                alm.KODEPOS = TxtKodePos.Text.Trim();
                alm.NEGARA = negara;
                alm.CREATED = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                alm.UPDATED = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                alm.Add();
            } else {
                if (DtAng.Rows[0][12].ToString() != TxtAlm.Text.Trim() || DtAng.Rows[0][13].ToString() != TxtKel.Text.Trim()
                    || DtAng.Rows[0][14].ToString() != TxtKec.Text.Trim() || DtAng.Rows[0][15].ToString() != TxtDati.Text.Trim()
                    || DtAng.Rows[0][16].ToString() != TxtKodePos.Text.Trim() || DtAng.Rows[0][17].ToString() != negara) {
                    alm.ALM = TxtAlm.Text.Trim();
                    alm.KEL = TxtKel.Text.Trim();
                    alm.KEC = TxtKec.Text.Trim();
                    alm.DATI2 = TxtDati.Text.Trim();
                    alm.KODEPOS = TxtKodePos.Text.Trim();
                    alm.NEGARA = negara;
                    alm.UPDATED = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    alm.Edit(idAnggota);
                    string act = "Edit data alamat debitur #" + idAnggota;
                    ActivityHistory(act);
                }
            }

            if (actAng == false) {
                pek.ID = idAnggota;
                pek.KERJAAN = TxtKerja.Text.Trim();
                pek.TEMPATBEKERJA = TxtTempatKerja.Text.Trim();
                pek.BIDUSAHA = TxtBidUsaha.Text.Trim();
                pek.CREATED = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                pek.UPDATED = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                pek.Add();
            } else {
                if (DtAng.Rows[0][18].ToString() != TxtKerja.Text.Trim() || DtAng.Rows[0][19].ToString() != TxtTempatKerja.Text.Trim()
                    || DtAng.Rows[0][20].ToString() != TxtBidUsaha.Text.Trim()) {
                    pek.KERJAAN = TxtKerja.Text.Trim();
                    pek.TEMPATBEKERJA = TxtTempatKerja.Text.Trim();
                    pek.BIDUSAHA = TxtBidUsaha.Text.Trim();
                    pek.UPDATED = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    pek.Edit(idAnggota);
                    string act = "Edit data pekerjaan debitur #" + idAnggota;
                    ActivityHistory(act);
                }
            }

            kre.IDKREDIT = idKredit;
            kre.IDANG = idAnggota;
            kre.IDUSER = AppSession._id_user;
            CmbSifat.Invoke(new MethodInvoker(delegate { sifat = ((KeyValuePair<string, string>)CmbSifat.SelectedItem).Key; }));
            kre.SIFAT = sifat;
            kre.VALUTA = TxtValuta.Text.Trim();
            kre.BUNGA = TxtBunga.Text.Trim();
            kre.PLAFON = TxtPlafon.Text.Trim();
            kre.BAKIDEBET = TxtDebet.Text.Trim();
            kre.POKOK = TxtPokok.Text.Trim();
            kre.FREKPOKOK = TxtFrekPokok.Text.Trim();
            kre.FREKBUNGA = TxtFrekBunga.Text.Trim();
            CmbSektor.Invoke(new MethodInvoker(delegate { sektor = ((KeyValuePair<string, string>)CmbSektor.SelectedItem).Key; }));
            kre.SEKTOR = sektor;
            CmbJenis.Invoke(new MethodInvoker(delegate { jenis = ((KeyValuePair<string, string>)CmbJenis.SelectedItem).Key; }));
            kre.JENIS = jenis;
            CmbKondisi.Invoke(new MethodInvoker(delegate { kondisi = ((KeyValuePair<string, string>)CmbKondisi.SelectedItem).Key; }));
            kre.KONDISI = kondisi;
            kre.TGLKONDISI = tglKondisi;
            CmbSebab.Invoke(new MethodInvoker(delegate { macet = ((KeyValuePair<string, string>)CmbSebab.SelectedItem).Key; }));
            kre.MACET = macet;
            kre.TGLMACET = tglSebab;
            kre.AKAD = DtpAkad.Value.ToString("yyyy-MM-dd");
            kre.JTHTEMPO = DtpJatuh.Value.ToString("yyyy-MM-dd");
            CmbBaruPerpanjang.Invoke(new MethodInvoker(delegate { perpanjangan = ((KeyValuePair<string, string>)CmbBaruPerpanjang.SelectedItem).Key; }));
            kre.PERPANJANGAN = perpanjangan;
            kre.CREATED = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            kre.UPDATED = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            kre.Add();
            string actK = "Input data kredit #" + idKredit;
            ActivityHistory(actK);

            SaveKolek();
            SaveAgunan();
            ClearData();
        }

        private void SaveAgunan() {
            if (DgvAgunan.Rows.Count > 0) {
                string act = "Input data agunan #" + idKredit;
                agun.IDKREDIT = idKredit;
                agun.CREATED = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                agun.UPDATED = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                agun.IDUSER = AppSession._id_user;

                foreach (DataGridViewRow row in DgvAgunan.Rows) {
                    String buktiAgn = "";
                    String paripasuAgn = "";
                    String asuransiAgn = "";

                    if (row.Cells["paripasu"].Value.ToString() == "YA") {
                        paripasuAgn = "1";
                    } else if (row.Cells["paripasu"].Value.ToString() == "TIDAK") {
                        paripasuAgn = "2";
                    }

                    if (row.Cells["bukti"].Value.ToString() == "BPKB") {
                        buktiAgn = "1";
                    } else if (row.Cells["bukti"].Value.ToString() == "SHM") {
                        buktiAgn = "2";
                    } else if (row.Cells["bukti"].Value.ToString() == "SHGB") {
                        buktiAgn = "3";
                    } else if (row.Cells["bukti"].Value.ToString() == "LAINNYA") {
                        buktiAgn = "9";
                    }

                    if (row.Cells["asuransi_agn"].Value.ToString() == "YA") {
                        asuransiAgn = "1";
                    } else if (row.Cells["asuransi_agn"].Value.ToString() == "TIDAK") {
                        asuransiAgn = "2";
                    }

                    DateTime penilaianTgl = DateTime.Parse(row.Cells["tgl_penilaian"].Value.ToString());

                    agun.IDAGN = agun.Kodegen(idKredit);
                    agun.BANK = row.Cells["bank"].Value.ToString();
                    agun.INDEPENDEN = row.Cells["independen"].Value.ToString();
                    agun.NJOP = row.Cells["njop"].Value.ToString();
                    agun.TGLPENILAIAN = penilaianTgl.ToString("yyyy-MM-dd");
                    agun.PENILAI = row.Cells["penilai"].Value.ToString();
                    agun.PARIPASU = paripasuAgn;
                    agun.PEMILIK = row.Cells["pemilik"].Value.ToString();
                    agun.BUKTI = buktiAgn;
                    agun.ALAMAT = row.Cells["alm_agunan"].Value.ToString();
                    agun.DATI2 = row.Cells["dati_agunan"].Value.ToString();
                    agun.ASURANSI = asuransiAgn;
                    agun.Add();
                }
                ActivityHistory(act);
            }
        }

        private void SaveKolek() {
            if (DgvKolek.Rows.Count > 0) {
                string act = "Input data kolektibilitas #" + idKredit;
                kol.IDKREDIT = idKredit;
                kol.CREATED = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                kol.UPDATED = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                kol.IDUSER = AppSession._id_user;

                foreach (DataGridViewRow row in DgvKolek.Rows) {
                    String tingkatKolek = "";

                    if (row.Cells["tingkat_kolek"].Value.ToString() == "LANCAR") {
                        tingkatKolek = "1";
                    } else if (row.Cells["tingkat_kolek"].Value.ToString() == "DALAM PERHATIAN KHUSUS") {
                        tingkatKolek = "2";
                    } else if (row.Cells["tingkat_kolek"].Value.ToString() == "KURANG LANCAR") {
                        tingkatKolek = "3";
                    } else if (row.Cells["tingkat_kolek"].Value.ToString() == "DIRAGUKAN") {
                        tingkatKolek = "4";
                    } else if (row.Cells["tingkat_kolek"].Value.ToString() == "MACET") {
                        tingkatKolek = "5";
                    }

                    DateTime kolekTgl = DateTime.Parse(row.Cells["tgl_kolek"].Value.ToString());

                    kol.IDKOLEK = kol.Kodegen(idKredit);
                    kol.TINGKAT = tingkatKolek;
                    kol.HARI = row.Cells["hari_kolek"].Value.ToString();
                    kol.TGL = kolekTgl.ToString("yyyy-MM-dd");
                    kol.Add();
                }
                ActivityHistory(act);
            }
        }
        // STORE DATA

        public void ConfirmSave() {
            if(BgWorker.IsBusy != true) {
                BgWorker.RunWorkerAsync();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e) {
            ValidateSave();
        }

        private void ActivityHistory(string act) {
            HistoryService his = new HistoryService();
            his.ID = AppSession._id_user;
            his.ACT = act;
            his.TIME = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            his.Add();
        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e) {
            using (FrmWait frm = new FrmWait(SaveData)) {
                frm.ShowDialog();
            }
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            MessageBox.Show("Data Berhasil Disimpan", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnSearch_Click(object sender, EventArgs e) {
            FrmModalAnggota frm = new FrmModalAnggota(this);
            frm.ShowDialog();
        }

        private void BtnReset_Click(object sender, EventArgs e) {
            Reset();
        }

        
    }
}
