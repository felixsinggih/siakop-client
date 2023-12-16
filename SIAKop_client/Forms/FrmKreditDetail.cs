using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SIAKop_client.Class;
using FontAwesome.Sharp;

namespace SIAKop_client.Forms {
    public partial class FrmKreditDetail : Form {
        KreditService kre = new KreditService();
        AgunanService agun = new AgunanService();
        KolektabilitasService kol = new KolektabilitasService();
        public string idKredit;

        public FrmKreditDetail() {
            InitializeComponent();
        }

        private void FrmKreditDetail_Load(object sender, EventArgs e) {
            using (FrmWait frm = new FrmWait(DataKredit)) {
                frm.ShowDialog();
            }
        }

        private void DataKredit() {
            DataTable DetKre = new DataTable();
            DetKre = kre.SearchKreditById(idKredit);
            DateTime tglLhr = DateTime.Parse(DetKre.Rows[0][3].ToString());
            DateTime tglAkad = DateTime.Parse(DetKre.Rows[0][35].ToString());
            DateTime tglJatuh = DateTime.Parse(DetKre.Rows[0][36].ToString());
            string tglKondisi = "";
            string tglSebab = "";
            if (DetKre.Rows[0][32].ToString() != "") {
                DateTime Kondisi = DateTime.Parse(DetKre.Rows[0][32].ToString());
                tglKondisi = string.Format("{0 : dd MMMM yyyy}", Kondisi);
            }
            if (DetKre.Rows[0][34].ToString() != "") {
                DateTime Sebab = DateTime.Parse(DetKre.Rows[0][34].ToString());
                tglSebab = string.Format("{0 : dd MMMM yyyy}", Sebab);
            }
            string Negara = "";
            string Sifat = "";
            string Sektor = "";
            string Jenis = "";
            string KondisiText = "";
            string SebabTxt = "";
            string Perpanjangan = "";
            if (DetKre.Rows[0][16].ToString() == "ID")
                Negara = "Indonesia";

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

            if (DetKre.Rows[0][30].ToString() == "0")
                Jenis = "KREDIT KONSUMSI";
            else if (DetKre.Rows[0][30].ToString() == "1")
                Jenis = "MODAL KERJA";
            else if (DetKre.Rows[0][30].ToString() == "2")
                Jenis = "INVESTASI";

            if (DetKre.Rows[0][31].ToString() == "00")
                KondisiText = "FASILITAS AKTIF";
            else if (DetKre.Rows[0][31].ToString() == "01")
                KondisiText = "DIBATALKAN";
            else if (DetKre.Rows[0][31].ToString() == "02")
                KondisiText = "LUNAS";
            else if (DetKre.Rows[0][31].ToString() == "03")
                KondisiText = "DIHAPUSBUKUKAN";
            else if (DetKre.Rows[0][31].ToString() == "04")
                KondisiText = "HAPUS TAGIH";
            else if (DetKre.Rows[0][31].ToString() == "05")
                KondisiText = "LUNAS KARENA PENGAMBILALIHAN AGUNAN";
            else if (DetKre.Rows[0][31].ToString() == "06")
                KondisiText = "LUNAS KARENA DISELESAIKAN MELALUI PENGADILAN";
            else if (DetKre.Rows[0][31].ToString() == "07")
                KondisiText = "DIALIHKAN KE PELAPOR LAIN";
            else if (DetKre.Rows[0][31].ToString() == "08")
                KondisiText = "DIALIHKAN KE FASILITAS LAIN";
            else if (DetKre.Rows[0][31].ToString() == "09")
                KondisiText = "DIALIHKAN/DIJUAL KEPADA PIHAK NON PELAPOR";
            else if (DetKre.Rows[0][31].ToString() == "10")
                KondisiText = "DISEKURITISASI (KREDITUR ASAL SEBAGAI SERVICER)";
            else if (DetKre.Rows[0][31].ToString() == "11")
                KondisiText = "DISEKURITISASI (KREDITUR ASAL TIDAK SEBAGAI SERVICER)";
            else if (DetKre.Rows[0][31].ToString() == "12")
                KondisiText = "LUNAS DENGAN DISKON";
            else if (DetKre.Rows[0][31].ToString() == "13")
                KondisiText = "DIBLOKIR SEMENTARA";
            else if (DetKre.Rows[0][31].ToString() == "14")
                KondisiText = "BERHENTI DARI KEANGGOTAAN KREDIT JOIN";

            if (DetKre.Rows[0][33].ToString() == "01")
                SebabTxt = "KESULITAN PEMASARAN";
            else if (DetKre.Rows[0][33].ToString() == "02")
                SebabTxt = "KESULITAN MANAJEMEN DAN PERMASALAHAN TENAGA KERJA";
            else if (DetKre.Rows[0][33].ToString() == "03")
                SebabTxt = "PERUSAHAAN GRUP/AFILIASI YANG SANGAT MERUGIKAN DEBITUR";
            else if (DetKre.Rows[0][33].ToString() == "04")
                SebabTxt = "PERMASALAHAN TERKAIT PENGELOAAN LINGKUNGAN HIDUP";
            else if (DetKre.Rows[0][33].ToString() == "05")
                SebabTxt = "PENGGUNAAN DANA TIDAK SESUAI SESUAI DENGAN PERJANJIAN";
            else if (DetKre.Rows[0][33].ToString() == "06")
                SebabTxt = "KELEMAHAN DALAM ANALISA";
            else if (DetKre.Rows[0][33].ToString() == "07")
                SebabTxt = "FLUKTUASI NILAI TUKAR";
            else if (DetKre.Rows[0][33].ToString() == "08")
                SebabTxt = "ITIKAD TIDAK BAIK";
            else if (DetKre.Rows[0][33].ToString() == "09")
                SebabTxt = "FORCE MAJEUR";
            else if (DetKre.Rows[0][33].ToString() == "10")
                SebabTxt = "PAILIT";
            else if (DetKre.Rows[0][33].ToString() == "11")
                SebabTxt = "UNIFORM CALSSIFICATION";
            else if (DetKre.Rows[0][33].ToString() == "12")
                SebabTxt = "LAINNYA";

            if (DetKre.Rows[0][37].ToString() == "0")
                Perpanjangan = "FASILITAS BARU";
            else if (DetKre.Rows[0][37].ToString() == "1")
                Perpanjangan = "FASILITAS DIPERPANJANG 1 KALI";
            else if (DetKre.Rows[0][37].ToString() == "2")
                Perpanjangan = "FASILITAS DIPERPANJANG 2 KALI";

            LblDin.Invoke(new MethodInvoker(delegate { LblDin.Text = ": " + DetKre.Rows[0][0].ToString(); }));
            LblKtp.Invoke(new MethodInvoker(delegate { LblKtp.Text = ": " + DetKre.Rows[0][5].ToString(); }));
            LblNama.Invoke(new MethodInvoker(delegate { LblNama.Text = ": " + DetKre.Rows[0][1].ToString(); }));
            LblTempatLahir.Invoke(new MethodInvoker(delegate { LblTempatLahir.Text = ": " + DetKre.Rows[0][2].ToString() + "," + string.Format("{0 : dd MMMM yyyy}", tglLhr); }));
            LblJenisK.Invoke(new MethodInvoker(delegate { LblJenisK.Text = ": " + DetKre.Rows[0][4].ToString(); }));
            LblNpwp.Invoke(new MethodInvoker(delegate { LblNpwp.Text = ": " + DetKre.Rows[0][6].ToString(); }));
            LblPaspor.Invoke(new MethodInvoker(delegate { LblPaspor.Text = ": " + DetKre.Rows[0][7].ToString(); }));
            LblAlias.Invoke(new MethodInvoker(delegate { LblAlias.Text = ": " + DetKre.Rows[0][8].ToString(); }));
            LblNamaIbu.Invoke(new MethodInvoker(delegate { LblNamaIbu.Text = ": " + DetKre.Rows[0][9].ToString(); }));
            LblTelp.Invoke(new MethodInvoker(delegate { LblTelp.Text = ": " + DetKre.Rows[0][10].ToString(); }));
            LblEmail.Invoke(new MethodInvoker(delegate { LblEmail.Text = ": " + DetKre.Rows[0][38].ToString(); }));
            LblAlamat.Invoke(new MethodInvoker(delegate { LblAlamat.Text = ": " + DetKre.Rows[0][11].ToString() + ", " + DetKre.Rows[0][12].ToString() + ", " + DetKre.Rows[0][13].ToString() + ", \r\n  " + DetKre.Rows[0][14].ToString() + ", " + DetKre.Rows[0][15].ToString() + ", " + Negara; }));
            LblPekerjaan.Invoke(new MethodInvoker(delegate { LblPekerjaan.Text = ": " + DetKre.Rows[0][17].ToString(); }));
            LblTempatBekerja.Invoke(new MethodInvoker(delegate { LblTempatBekerja.Text = ": " + DetKre.Rows[0][18].ToString(); }));
            LblBidUsaha.Invoke(new MethodInvoker(delegate { LblBidUsaha.Text = ": " + DetKre.Rows[0][19].ToString(); }));

            LblIdKredit.Invoke(new MethodInvoker(delegate { LblIdKredit.Text = ": " + DetKre.Rows[0][20].ToString(); }));
            LblSifat.Invoke(new MethodInvoker(delegate { LblSifat.Text = ": " + Sifat; }));
            LblValuta.Invoke(new MethodInvoker(delegate { LblValuta.Text = ": " + DetKre.Rows[0][22].ToString(); }));
            LblBunga.Invoke(new MethodInvoker(delegate { LblBunga.Text = ": " + DetKre.Rows[0][23].ToString(); }));
            LblPlafon.Invoke(new MethodInvoker(delegate { LblPlafon.Text = ": " + int.Parse(DetKre.Rows[0][24].ToString()).ToRupiah(); }));
            LblDebet.Invoke(new MethodInvoker(delegate { LblDebet.Text = ": " + int.Parse(DetKre.Rows[0][25].ToString()).ToRupiah(); }));
            LblPokok.Invoke(new MethodInvoker(delegate { LblPokok.Text = ": " + DetKre.Rows[0][26].ToString(); }));
            LblFrek.Invoke(new MethodInvoker(delegate { LblFrek.Text = ": " + DetKre.Rows[0][27].ToString() + " / " + DetKre.Rows[0][28].ToString(); }));
            LblSektor.Invoke(new MethodInvoker(delegate { LblSektor.Text = ": " + Sektor; }));
            LblJenis.Invoke(new MethodInvoker(delegate { LblJenis.Text = ": " + Jenis; }));
            LblKondisi.Invoke(new MethodInvoker(delegate { LblKondisi.Text = ": " + KondisiText; }));
            LblTglKondisi.Invoke(new MethodInvoker(delegate { LblTglKondisi.Text = ":" + tglKondisi; }));
            LblSebab.Invoke(new MethodInvoker(delegate { LblSebab.Text = ": " + SebabTxt; }));
            LblTglSebab.Invoke(new MethodInvoker(delegate { LblTglSebab.Text = ":" + tglSebab; }));
            LblAkad.Invoke(new MethodInvoker(delegate { LblAkad.Text = ": " + string.Format("{0 : dd MMMM yyyy}", tglAkad); }));
            LblJatuh.Invoke(new MethodInvoker(delegate { LblJatuh.Text = ": " + string.Format("{0 : dd MMMM yyyy}", tglJatuh); }));
            LblPerpanjangan.Invoke(new MethodInvoker(delegate { LblPerpanjangan.Text = ": " + Perpanjangan; }));

            DgvAgunan.Invoke(new MethodInvoker(delegate { DgvAgunan.DataSource = agun.SearchAgunanById(idKredit); }));
            foreach (DataGridViewRow row in DgvAgunan.Rows) {
                if (row.Cells["paripasu"].Value.ToString() == "1") {
                    row.Cells["paripasu"].Value = "YA";
                } else if (row.Cells["paripasu"].Value.ToString() == "2") {
                    row.Cells["paripasu"].Value = "TIDAK";
                }

                if (row.Cells["bukti"].Value.ToString() == "1") {
                    row.Cells["bukti"].Value = "BPKB";
                } else if (row.Cells["bukti"].Value.ToString() == "2") {
                    row.Cells["bukti"].Value = "SHM";
                } else if (row.Cells["bukti"].Value.ToString() == "3") {
                    row.Cells["bukti"].Value = "SHGB";
                } else if (row.Cells["bukti"].Value.ToString() == "9") {
                    row.Cells["bukti"].Value = "LAINNYA";
                }

                if (row.Cells["asuransi"].Value.ToString() == "1") {
                    row.Cells["asuransi"].Value = "YA";
                } else if (row.Cells["asuransi"].Value.ToString() == "2") {
                    row.Cells["asuransi"].Value = "TIDAK";
                }
            }

            RefreshKolek();
        }

        public void RefreshKolek() {
            DgvKolek.Invoke(new MethodInvoker(delegate { DgvKolek.DataSource = kol.SearchByIdKredit(idKredit); }));
            foreach (DataGridViewRow row in DgvKolek.Rows) {
                if (row.Cells["tingkat_kolek"].Value.ToString() == "1") {
                    row.Cells["tingkat_kolek"].Value = "LANCAR";
                } else if (row.Cells["tingkat_kolek"].Value.ToString() == "2") {
                    row.Cells["tingkat_kolek"].Value = "DALAM PERHATIAN KHUSUS";
                } else if (row.Cells["tingkat_kolek"].Value.ToString() == "3") {
                    row.Cells["tingkat_kolek"].Value = "KURANG LANCAR";
                } else if (row.Cells["tingkat_kolek"].Value.ToString() == "4") {
                    row.Cells["tingkat_kolek"].Value = "DIRAGUKAN";
                } else if (row.Cells["tingkat_kolek"].Value.ToString() == "5") {
                    row.Cells["tingkat_kolek"].Value = "MACET";
                }
            }
        }

        private void BtnInput_Click(object sender, EventArgs e) {
            FrmKreditKolek frm = new FrmKreditKolek(this);
            frm.idKredit = idKredit;
            frm.ShowDialog();
        }
    }
}
