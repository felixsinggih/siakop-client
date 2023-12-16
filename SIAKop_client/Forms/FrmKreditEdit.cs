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
    public partial class FrmKreditEdit : Form {
        AnggotaService ang = new AnggotaService();
        KreditService kre = new KreditService();
        AlamatService alm = new AlamatService();
        KontakService kon = new KontakService();
        PekerjaanService pek = new PekerjaanService();
        AgunanService agun = new AgunanService();
        KolektabilitasService kol = new KolektabilitasService();

        public string idKredit;
        private string idAnggota;
        private string tglKondisi = "";
        private string tglSebab = "";
        DataTable DetKre = new DataTable();
        DataTable DatKol = new DataTable();
        DataTable DatAgu = new DataTable();

        private bool editAnggota = false;
        private bool editKontak = false;
        private bool editAlamat = false;
        private bool editPekerjaan = false;
        private bool editKredit = false;
        private bool editKolek = false;
        private bool deleteKolek = false;
        private bool editAgunan = false;
        private bool deleteAgunan = false;

        FrmKreditShow showKredit;

        public FrmKreditEdit(FrmKreditShow show) {
            InitializeComponent();
            this.showKredit = show;
        }

        private void FrmKreditEdit_Load(object sender, EventArgs e) {
            ComboBoxValue();
            using (FrmWait frm = new FrmWait(DataLoad)) {
                frm.ShowDialog();
            }
        }

        private void ActivityHistory(string act) {
            HistoryService his = new HistoryService();
            his.ID = AppSession._id_user;
            his.ACT = act;
            his.TIME = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            his.Add();
        }

        private void BtnSave_Click(object sender, EventArgs e) {
            FrmConfirmEditSave frm = new FrmConfirmEditSave(this);
            if (MessageBox.Show("Apakah Anda Yakin Akan Menyimpan Data Tersebut?", "Pesan", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                frm.ShowDialog();
            }
        }

        public void FindMonth(String month, String year, string act) {
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

            if (act == "edited")
                MessageBox.Show("Anda Sudah Mengedit Kolektibilitas Bulan " + conMonth + " " + year + "!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (act == "deleted")
                MessageBox.Show("Anda Sudah Menghapus Kolektibilitas Bulan " + conMonth + " " + year + "!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void ConfirmSave() {
            if (BgWorker.IsBusy != true) {
                BgWorker.RunWorkerAsync();
            }
        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e) {
            using (FrmWait frm = new FrmWait(StoreData)) {
                frm.ShowDialog();
            }
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if ((editAnggota == true) | (editKontak == true) || (editAlamat == true) || (editPekerjaan == true) || (editKredit == true) 
                || (editKolek == true) || (deleteKolek == true) || (editAgunan == true) || (deleteAgunan == true)) {
                MessageBox.Show("Data Berhasil Diubah!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                showKredit.RefreshKre();
            } else {
                MessageBox.Show("Tidak Ada Perubahan Data!", "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            
        }

        private void StoreData() {
            EditAnggota();
            EditKontak();
            EditAlamat();
            EditPekerjaan();
            EditKredit();
            EditKolek();
            EditAgunan();

        }

        private void EditAnggota() {
            string jenisK = "";
            DateTime tglLahir = DateTime.Parse(DetKre.Rows[0][3].ToString());
            if (RbLaki.Checked == true)
                jenisK = RbLaki.Text;
            else if (RbPerempuan.Checked == true)
                jenisK = RbPerempuan.Text;
            if (DetKre.Rows[0][1].ToString() != TxtNama.Text.Trim() || DetKre.Rows[0][2].ToString() != TxtTempatLahir.Text.Trim()
                || tglLahir.ToString("yyyy-MM-dd") != DtpTglLahir.Value.ToString("yyyy-MM-dd") || DetKre.Rows[0][4].ToString() != jenisK
                || DetKre.Rows[0][5].ToString() != TxtKtp.Text.Trim() || DetKre.Rows[0][6].ToString() != TxtNpwp.Text.Trim()
                || DetKre.Rows[0][7].ToString() != TxtPaspor.Text.Trim() || DetKre.Rows[0][8].ToString() != TxtAlias.Text.Trim()
                || DetKre.Rows[0][9].ToString() != TxtIbu.Text.Trim()) {
                ang.NAMA = TxtNama.Text.Trim();
                ang.TEMPAT = TxtTempatLahir.Text.Trim();
                ang.TANGGAL = DtpTglLahir.Value.ToString("yyyy-MM-dd");
                ang.JENIS = jenisK;
                ang.KTP = TxtKtp.Text.Trim();
                ang.NPWP = TxtNpwp.Text.Trim();
                ang.PASPOR = TxtPaspor.Text.Trim();
                ang.ALIAS = TxtAlias.Text.Trim();
                ang.IBU = TxtIbu.Text.Trim();
                ang.UPDATED = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                ang.Edit(idAnggota);
                string act = "Edit data debitur #" + idAnggota;
                ActivityHistory(act);
                editAnggota = true;
            } 
        }

        private void EditKontak() {
            if (DetKre.Rows[0][10].ToString() != TxtTelp.Text.Trim() || DetKre.Rows[0][38].ToString() != TxtEmail.Text.Trim()) {
                kon.TELP = TxtTelp.Text.Trim();
                kon.EMAIL = TxtEmail.Text.Trim();
                kon.UPDATED = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                kon.Edit(idAnggota);
                string act = "Edit data kontak debitur #" + idAnggota;
                ActivityHistory(act);
                editKontak = true;
            } 
        }

        private void EditAlamat() {
            string negara = "";
            CmbNegara.Invoke(new MethodInvoker(delegate { negara = ((KeyValuePair<string, string>)CmbNegara.SelectedItem).Key; }));
            if (DetKre.Rows[0][11].ToString() != TxtAlm.Text.Trim() || DetKre.Rows[0][12].ToString() != TxtKel.Text.Trim()
                || DetKre.Rows[0][13].ToString() != TxtKec.Text.Trim() || DetKre.Rows[0][14].ToString() != TxtDati.Text.Trim()
                || DetKre.Rows[0][15].ToString() != TxtKodePos.Text.Trim() || DetKre.Rows[0][16].ToString() != negara) {
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
                editAlamat = true;
            } 

        }

        private void EditPekerjaan() {
            if (DetKre.Rows[0][17].ToString() != TxtKerja.Text.Trim() || DetKre.Rows[0][18].ToString() != TxtTempatKerja.Text.Trim()
                || DetKre.Rows[0][19].ToString() != TxtBidUsaha.Text.Trim()) {
                pek.KERJAAN = TxtKerja.Text.Trim();
                pek.TEMPATBEKERJA = TxtTempatKerja.Text.Trim();
                pek.BIDUSAHA = TxtBidUsaha.Text.Trim();
                pek.UPDATED = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                pek.Edit(idAnggota);
                string act = "Edit data pekerjaan debitur #" + idAnggota;
                ActivityHistory(act);
                editPekerjaan = true;
            } 
        }

        private void EditKredit() {
            string sifatK = "";
            string sektorK = "";
            string jenisKre = "";
            string kondisiK = "";
            string sebabK = "";
            string perpanjanganK = "";
            CmbSifat.Invoke(new MethodInvoker(delegate { sifatK = ((KeyValuePair<string, string>)CmbSifat.SelectedItem).Key; }));
            CmbSektor.Invoke(new MethodInvoker(delegate { sektorK = ((KeyValuePair<string, string>)CmbSektor.SelectedItem).Key; }));
            CmbJenis.Invoke(new MethodInvoker(delegate { jenisKre = ((KeyValuePair<string, string>)CmbJenis.SelectedItem).Key; }));
            CmbKondisi.Invoke(new MethodInvoker(delegate { kondisiK = ((KeyValuePair<string, string>)CmbKondisi.SelectedItem).Key; }));
            CmbSebab.Invoke(new MethodInvoker(delegate { sebabK = ((KeyValuePair<string, string>)CmbSebab.SelectedItem).Key; }));
            CmbBaruPerpanjang.Invoke(new MethodInvoker(delegate { perpanjanganK = ((KeyValuePair<string, string>)CmbBaruPerpanjang.SelectedItem).Key; }));

            string kondisiTgl = "";
            string sebabTgl = "";
            if (DetKre.Rows[0][32].ToString() != "") {
                DateTime Kondisi = DateTime.Parse(DetKre.Rows[0][32].ToString());
                kondisiTgl = Kondisi.ToString("yyyy-MM-dd");
            }
            if (DetKre.Rows[0][34].ToString() != "") {
                DateTime Sebab = DateTime.Parse(DetKre.Rows[0][34].ToString());
                sebabTgl = Sebab.ToString("yyyy-MM-dd");
            }

            DateTime akadTgl = DateTime.Parse(DetKre.Rows[0][35].ToString());
            DateTime jatuhTgl = DateTime.Parse(DetKre.Rows[0][36].ToString());

            if (DetKre.Rows[0][21].ToString() != sifatK || DetKre.Rows[0][23].ToString() != TxtBunga.Text.Trim()
                || DetKre.Rows[0][24].ToString() != TxtPlafon.Text.Trim() || DetKre.Rows[0][25].ToString() != TxtDebet.Text.Trim()
                || DetKre.Rows[0][26].ToString() != TxtPokok.Text.Trim() || DetKre.Rows[0][27].ToString() != TxtFrekPokok.Text.Trim()
                || DetKre.Rows[0][28].ToString() != TxtFrekBunga.Text.Trim() || DetKre.Rows[0][29].ToString() != sektorK
                || DetKre.Rows[0][30].ToString() != jenisKre || DetKre.Rows[0][31].ToString() != kondisiK
                || kondisiTgl != tglKondisi || DetKre.Rows[0][33].ToString() != sebabK || sebabTgl != tglSebab
                || akadTgl.ToString("yyyy-MM-dd") != DtpAkad.Value.ToString("yyyy-MM-dd") || jatuhTgl.ToString("yyyy-MM-dd") != DtpJatuh.Value.ToString("yyyy-MM-dd")
                || DetKre.Rows[0][37].ToString() != perpanjanganK) {
                kre.IDUSER = AppSession._id_user;
                kre.SIFAT = sifatK;
                kre.BUNGA = TxtBunga.Text.Trim();
                kre.PLAFON = TxtPlafon.Text.Trim();
                kre.BAKIDEBET = TxtDebet.Text.Trim();
                kre.POKOK = TxtPokok.Text.Trim();
                kre.FREKPOKOK = TxtFrekPokok.Text.Trim();
                kre.FREKBUNGA = TxtFrekBunga.Text.Trim();
                kre.SEKTOR = sektorK;
                kre.JENIS = jenisKre;
                kre.KONDISI = kondisiK;
                kre.TGLKONDISI = tglKondisi;
                kre.MACET = sebabK;
                kre.TGLMACET = tglSebab;
                kre.AKAD = DtpAkad.Value.ToString("yyyy-MM-dd");
                kre.JTHTEMPO = DtpJatuh.Value.ToString("yyyy-MM-dd");
                kre.PERPANJANGAN = perpanjanganK;
                kre.UPDATED = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                kre.Edit(idKredit);
                string act = "Edit data kredit #" + idKredit;
                ActivityHistory(act);
                editKredit = true;
            } 
        }

        private void EditKolek() {
            if(DgvKolekEdit.Rows.Count > 0) {
                kol.IDUSER = AppSession._id_user;
                kol.UPDATED = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                foreach (DataGridViewRow row in DgvKolekEdit.Rows) {
                    String tingkatKolek = "";

                    if (row.Cells["tingkat_kolek_edit"].Value.ToString() == "LANCAR") {
                        tingkatKolek = "1";
                    } else if (row.Cells["tingkat_kolek_edit"].Value.ToString() == "KURANG LANCAR") {
                        tingkatKolek = "2";
                    } else if (row.Cells["tingkat_kolek_edit"].Value.ToString() == "DALAM PERHATIAN KHUSUS") {
                        tingkatKolek = "3";
                    } else if (row.Cells["tingkat_kolek_edit"].Value.ToString() == "DIRAGUKAN") {
                        tingkatKolek = "4";
                    } else if (row.Cells["tingkat_kolek_edit"].Value.ToString() == "MACET") {
                        tingkatKolek = "5";
                    }

                    DateTime kolekTgl = DateTime.Parse(row.Cells["tgl_kolek_edit"].Value.ToString());
                    kol.TINGKAT = tingkatKolek;
                    kol.HARI = row.Cells["hari_kolek_edit"].Value.ToString();
                    kol.TGL = kolekTgl.ToString("yyyy-MM-dd");
                    kol.Edit(row.Cells["id_kolek_edit"].Value.ToString());
                }
                string act = "Edit data kolektibilitas #" + idKredit;
                ActivityHistory(act);
                editKolek = true;
            } 

            if (DgvKolekDelete.Rows.Count > 0) {
                kol.IDUSER = AppSession._id_user;
                kol.DELETED = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                foreach (DataGridViewRow row in DgvKolekDelete.Rows) {
                    kol.Delete(row.Cells["id_kolek_del"].Value.ToString());
                }
                string act = "Hapus data kolektibilitas #" + idKredit;
                ActivityHistory(act);
                deleteKolek = true;
            } 
        }

        private void EditAgunan() {
            if (DgvAgunanEdit.Rows.Count > 0) {
                agun.IDUSER = AppSession._id_user;
                agun.UPDATED = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                foreach (DataGridViewRow row in DgvAgunanEdit.Rows) {
                    String buktiAgn = "";
                    String paripasuAgn = "";
                    String asuransiAgn = "";

                    if (row.Cells["paripasu_edit"].Value.ToString() == "YA") {
                        paripasuAgn = "1";
                    } else if (row.Cells["paripasu_edit"].Value.ToString() == "TIDAK") {
                        paripasuAgn = "2";
                    }

                    if (row.Cells["bukti_edit"].Value.ToString() == "BPKB") {
                        buktiAgn = "1";
                    } else if (row.Cells["bukti_edit"].Value.ToString() == "SHM") {
                        buktiAgn = "2";
                    } else if (row.Cells["bukti_edit"].Value.ToString() == "SHGB") {
                        buktiAgn = "3";
                    } else if (row.Cells["bukti_edit"].Value.ToString() == "LAINNYA") {
                        buktiAgn = "9";
                    }

                    if (row.Cells["asuransi_edit"].Value.ToString() == "YA") {
                        asuransiAgn = "1";
                    } else if (row.Cells["asuransi_edit"].Value.ToString() == "TIDAK") {
                        asuransiAgn = "2";
                    }

                    DateTime penilaianTgl = DateTime.Parse(row.Cells["tgl_penilaian_edit"].Value.ToString());

                    agun.BANK = row.Cells["bank_edit"].Value.ToString();
                    agun.INDEPENDEN = row.Cells["independen_edit"].Value.ToString();
                    agun.NJOP = row.Cells["njop_edit"].Value.ToString();
                    agun.TGLPENILAIAN = penilaianTgl.ToString("yyyy-MM-dd");
                    agun.PENILAI = row.Cells["penilai_edit"].Value.ToString();
                    agun.PARIPASU = paripasuAgn;
                    agun.PEMILIK = row.Cells["pemilik_edit"].Value.ToString();
                    agun.BUKTI = buktiAgn;
                    agun.ALAMAT = row.Cells["alm_agn_edit"].Value.ToString();
                    agun.DATI2 = row.Cells["dati2_agn_edit"].Value.ToString();
                    agun.ASURANSI = asuransiAgn;
                    agun.Edit(row.Cells["id_agunan_edit"].Value.ToString());
                }
                string act = "Edit data agunan #" + idKredit;
                ActivityHistory(act);
                editAgunan = true;
            } 

            if (DgvAgunanDelete.Rows.Count > 0) {
                agun.IDUSER = AppSession._id_user;
                agun.DELETED = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                foreach (DataGridViewRow row in DgvAgunanDelete.Rows) {
                    agun.Delete(row.Cells["id_agunan_del"].Value.ToString());
                }
                string act = "Hapus data agunan #" + idKredit;
                ActivityHistory(act);
                deleteAgunan = true;
            } 
        }

        private void DataLoad() {
            DetKre = kre.SearchKreditById(idKredit);
            DatKol = kol.SearchByIdKredit(idKredit);
            DatAgu = agun.SearchAgunanById(idKredit);

            DateTime tglLhr = DateTime.Parse(DetKre.Rows[0][3].ToString());

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

            if (DetKre.Rows[0][35].ToString() != "") {
                DateTime Akad = DateTime.Parse(DetKre.Rows[0][35].ToString());
                DtpAkad.Invoke(new MethodInvoker(delegate { DtpAkad.CustomFormat = "dd/MM/yyyy"; }));
                DtpAkad.Invoke(new MethodInvoker(delegate { DtpAkad.Text = Akad.ToString("dd/MM/yyyy"); }));
            }

            if (DetKre.Rows[0][36].ToString() != "") {
                DateTime Jatuh = DateTime.Parse(DetKre.Rows[0][36].ToString());
                DtpJatuh.Invoke(new MethodInvoker(delegate { DtpJatuh.CustomFormat = "dd/MM/yyyy"; }));
                DtpJatuh.Invoke(new MethodInvoker(delegate { DtpJatuh.Text = Jatuh.ToString("dd/MM/yyyy"); }));
            }

            if (DetKre.Rows[0][21].ToString() == "1")
                CmbSifat.Invoke(new MethodInvoker(delegate { CmbSifat.SelectedIndex = 1; }));
            else if (DetKre.Rows[0][21].ToString() == "2")
                CmbSifat.Invoke(new MethodInvoker(delegate { CmbSifat.SelectedIndex = 2; }));
            else if (DetKre.Rows[0][21].ToString() == "3")
                CmbSifat.Invoke(new MethodInvoker(delegate { CmbSifat.SelectedIndex = 3; }));
            else if (DetKre.Rows[0][21].ToString() == "9")
                CmbSifat.Invoke(new MethodInvoker(delegate { CmbSifat.SelectedIndex = 4; }));

            if (DetKre.Rows[0][29].ToString() == "1")
                CmbSektor.Invoke(new MethodInvoker(delegate { CmbSektor.SelectedIndex = 1; }));
            else if (DetKre.Rows[0][29].ToString() == "2")
                CmbSektor.Invoke(new MethodInvoker(delegate { CmbSektor.SelectedIndex = 2; }));
            else if (DetKre.Rows[0][29].ToString() == "3")
                CmbSektor.Invoke(new MethodInvoker(delegate { CmbSektor.SelectedIndex = 3; }));
            else if (DetKre.Rows[0][29].ToString() == "9")
                CmbSektor.Invoke(new MethodInvoker(delegate { CmbSektor.SelectedIndex = 4; }));

            if (DetKre.Rows[0][30].ToString() == "0")
                CmbJenis.Invoke(new MethodInvoker(delegate { CmbJenis.SelectedIndex = 1; }));
            else if (DetKre.Rows[0][30].ToString() == "1")
                CmbJenis.Invoke(new MethodInvoker(delegate { CmbJenis.SelectedIndex = 2; }));
            else if (DetKre.Rows[0][30].ToString() == "2")
                CmbJenis.Invoke(new MethodInvoker(delegate { CmbJenis.SelectedIndex = 3; }));

            if (DetKre.Rows[0][37].ToString() == "0")
                CmbBaruPerpanjang.Invoke(new MethodInvoker(delegate { CmbBaruPerpanjang.SelectedIndex = 1; }));
            else if (DetKre.Rows[0][37].ToString() == "1")
                CmbBaruPerpanjang.Invoke(new MethodInvoker(delegate { CmbBaruPerpanjang.SelectedIndex = 2; }));
            else if (DetKre.Rows[0][37].ToString() == "2")
                CmbBaruPerpanjang.Invoke(new MethodInvoker(delegate { CmbBaruPerpanjang.SelectedIndex = 3; }));

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

            idAnggota = DetKre.Rows[0][0].ToString();
            TxtNama.Invoke(new MethodInvoker(delegate { TxtNama.Text = DetKre.Rows[0][1].ToString(); }));
            TxtAlias.Invoke(new MethodInvoker(delegate { TxtAlias.Text = DetKre.Rows[0][8].ToString(); }));
            TxtTempatLahir.Invoke(new MethodInvoker(delegate { TxtTempatLahir.Text = DetKre.Rows[0][2].ToString(); }));
            TxtKtp.Invoke(new MethodInvoker(delegate { TxtKtp.Text = DetKre.Rows[0][5].ToString(); }));
            DtpTglLahir.Invoke(new MethodInvoker(delegate { DtpTglLahir.Text = tglLhr.ToString("dd/MM/yyyy"); }));
            if(DetKre.Rows[0][4].ToString() == "Laki-laki")
                RbLaki.Invoke(new MethodInvoker(delegate { RbLaki.Checked = true; }));
            else if (DetKre.Rows[0][4].ToString() == "Perempuan")
                RbPerempuan.Invoke(new MethodInvoker(delegate { RbPerempuan.Checked = true; }));
            TxtNpwp.Invoke(new MethodInvoker(delegate { TxtNpwp.Text = DetKre.Rows[0][6].ToString(); }));
            TxtPaspor.Invoke(new MethodInvoker(delegate { TxtPaspor.Text = DetKre.Rows[0][7].ToString(); }));
            TxtIbu.Invoke(new MethodInvoker(delegate { TxtIbu.Text = DetKre.Rows[0][9].ToString(); }));

            TxtTelp.Invoke(new MethodInvoker(delegate { TxtTelp.Text = DetKre.Rows[0][10].ToString(); }));
            TxtEmail.Invoke(new MethodInvoker(delegate { TxtEmail.Text = DetKre.Rows[0][38].ToString(); }));

            TxtAlm.Invoke(new MethodInvoker(delegate { TxtAlm.Text = DetKre.Rows[0][11].ToString(); }));
            TxtKel.Invoke(new MethodInvoker(delegate { TxtKel.Text = DetKre.Rows[0][12].ToString(); }));
            TxtKec.Invoke(new MethodInvoker(delegate { TxtKec.Text = DetKre.Rows[0][13].ToString(); }));
            TxtDati.Invoke(new MethodInvoker(delegate { TxtDati.Text = DetKre.Rows[0][14].ToString(); }));
            TxtKodePos.Invoke(new MethodInvoker(delegate { TxtKodePos.Text = DetKre.Rows[0][15].ToString(); }));
            if (DetKre.Rows[0][16].ToString() == "ID")
                CmbNegara.Invoke(new MethodInvoker(delegate { CmbNegara.SelectedIndex = 1; }));

            TxtKerja.Invoke(new MethodInvoker(delegate { TxtKerja.Text = DetKre.Rows[0][17].ToString(); }));
            TxtTempatKerja.Invoke(new MethodInvoker(delegate { TxtTempatKerja.Text = DetKre.Rows[0][18].ToString(); }));
            TxtBidUsaha.Invoke(new MethodInvoker(delegate { TxtBidUsaha.Text = DetKre.Rows[0][19].ToString(); }));

            TxtIdKredit.Invoke(new MethodInvoker(delegate { TxtIdKredit.Text = DetKre.Rows[0][20].ToString(); }));
            TxtIdKredit.Invoke(new MethodInvoker(delegate { TxtIdKredit.Enabled = false; }));
            TxtIdKredit.Invoke(new MethodInvoker(delegate { TxtIdKredit.BackColor = Color.White; }));
            TxtValuta.Invoke(new MethodInvoker(delegate { TxtValuta.Text = DetKre.Rows[0][22].ToString(); }));
            TxtValuta.Invoke(new MethodInvoker(delegate { TxtValuta.Enabled = false; }));
            TxtValuta.Invoke(new MethodInvoker(delegate { TxtValuta.BackColor = Color.White; }));
            TxtBunga.Invoke(new MethodInvoker(delegate { TxtBunga.Text = DetKre.Rows[0][23].ToString(); }));
            TxtPlafon.Invoke(new MethodInvoker(delegate { TxtPlafon.Text = DetKre.Rows[0][24].ToString(); }));
            TxtDebet.Invoke(new MethodInvoker(delegate { TxtDebet.Text = DetKre.Rows[0][25].ToString(); }));
            TxtPokok.Invoke(new MethodInvoker(delegate { TxtPokok.Text = DetKre.Rows[0][26].ToString(); }));
            TxtFrekPokok.Invoke(new MethodInvoker(delegate { TxtFrekPokok.Text = DetKre.Rows[0][27].ToString(); }));
            TxtFrekBunga.Invoke(new MethodInvoker(delegate { TxtFrekBunga.Text = DetKre.Rows[0][28].ToString(); }));

            DgvKolek.DataSource = DatKol;
            foreach (DataGridViewRow row in DgvKolek.Rows) {
                if (row.Cells["tingkat_kolek"].Value.ToString() == "1") {
                    row.Cells["tingkat_kolek"].Value = "LANCAR";
                } else if (row.Cells["tingkat_kolek"].Value.ToString() == "2") {
                    row.Cells["tingkat_kolek"].Value = "KURANG LANCAR";
                } else if (row.Cells["tingkat_kolek"].Value.ToString() == "3") {
                    row.Cells["tingkat_kolek"].Value = "DALAM PERHATIAN KHUSUS";
                } else if (row.Cells["tingkat_kolek"].Value.ToString() == "4") {
                    row.Cells["tingkat_kolek"].Value = "DIRAGUKAN";
                } else if (row.Cells["tingkat_kolek"].Value.ToString() == "5") {
                    row.Cells["tingkat_kolek"].Value = "MACET";
                }
            }

            DgvAgunan.DataSource = DatAgu;
            foreach (DataGridViewRow row in DgvAgunan.Rows) {
                if (row.Cells["paripasu_agun"].Value.ToString() == "1") {
                    row.Cells["paripasu_agun"].Value = "YA";
                } else if (row.Cells["paripasu_agun"].Value.ToString() == "2") {
                    row.Cells["paripasu_agun"].Value = "TIDAK";
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

                if (row.Cells["asuransi_agun"].Value.ToString() == "1") {
                    row.Cells["asuransi_agun"].Value = "YA";
                } else if (row.Cells["asuransi_agun"].Value.ToString() == "2") {
                    row.Cells["asuransi_agun"].Value = "TIDAK";
                }
            }
        }

        private void ComboBoxValue() {
            Dictionary<string, string> NegaraCombo = new Dictionary<string, string>();
            NegaraCombo.Add("", "--- SILAHKAN PILIH ---");
            NegaraCombo.Add("ID", "INDONESIA");
            CmbNegara.DataSource = new BindingSource(NegaraCombo, null);
            CmbNegara.DisplayMember = "Value";
            CmbNegara.ValueMember = "Key";

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
        }

        private void DtpKondisi_ValueChanged(object sender, EventArgs e) {
            DtpKondisi.CustomFormat = "dd/MM/yyyy";
            tglKondisi = DtpKondisi.Value.ToString("yyyy-MM-dd");
        }

        private void DtpSebab_ValueChanged(object sender, EventArgs e) {
            DtpSebab.CustomFormat = "dd/MM/yyyy";
            tglSebab = DtpSebab.Value.ToString("yyyy-MM-dd");
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

        private void DgvKolek_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            string act = "";
            bool check = false;
            if (DgvKolek.Columns[e.ColumnIndex].Name == "hapus_kolek") {
                DataGridViewRow row = this.DgvKolek.Rows[e.RowIndex];
                DateTime tglKolek = DateTime.Parse(row.Cells["tgl_kolek"].Value.ToString());

                foreach (DataGridViewRow rowEdit in DgvKolekEdit.Rows) {
                    DateTime tglGrid = DateTime.Parse(rowEdit.Cells["tgl_kolek_edit"].Value.ToString());
                    if (tglKolek.ToString("MM") == tglGrid.ToString("MM") && tglKolek.ToString("yyyy") == tglGrid.ToString("yyyy")) {
                        check = true;
                        act = "edited";
                    }
                }

                foreach (DataGridViewRow rowDel in DgvKolekDelete.Rows) {
                    DateTime tglGrid = DateTime.Parse(rowDel.Cells["tgl_kolek_del"].Value.ToString());
                    if (tglKolek.ToString("MM") == tglGrid.ToString("MM") && tglKolek.ToString("yyyy") == tglGrid.ToString("yyyy")) {
                        check = true;
                        act = "deleted";
                    }
                }

                if (check == true) {
                    FindMonth(tglKolek.ToString("MM"), tglKolek.ToString("yyyy"), act);
                } else {
                    DgvKolekDelete.Rows.Add(row.Cells["no_kolek"].Value.ToString(), row.Cells["id_kolek"].Value.ToString(), row.Cells["tingkat_kolek"].Value.ToString(),
                        row.Cells["hari_kolek"].Value.ToString(), tglKolek.ToString("dd/MM/yyyy"));
                }

            }

            FrmModalKolektabilitas mod = new FrmModalKolektabilitas(this);
            if (DgvKolek.Columns[e.ColumnIndex].Name == "edit_kolek") {
                DataGridViewRow row = this.DgvKolek.Rows[e.RowIndex];
                DateTime tglKolek = DateTime.Parse(row.Cells["tgl_kolek"].Value.ToString());

                foreach (DataGridViewRow rowEdit in DgvKolekEdit.Rows) {
                    DateTime tglGrid = DateTime.Parse(rowEdit.Cells["tgl_kolek_edit"].Value.ToString());
                    if (tglKolek.ToString("MM") == tglGrid.ToString("MM") && tglKolek.ToString("yyyy") == tglGrid.ToString("yyyy")) {
                        check = true;
                        act = "edited";
                    }
                }

                foreach (DataGridViewRow rowDel in DgvKolekDelete.Rows) {
                    DateTime tglGrid = DateTime.Parse(rowDel.Cells["tgl_kolek_del"].Value.ToString());
                    if (tglKolek.ToString("MM") == tglGrid.ToString("MM") && tglKolek.ToString("yyyy") == tglGrid.ToString("yyyy")) {
                        check = true;
                        act = "deleted";
                    }
                }

                if (check == true) {
                    FindMonth(tglKolek.ToString("MM"), tglKolek.ToString("yyyy"), act);
                } else {
                    mod.noKolek = row.Cells["no_kolek"].Value.ToString();
                    mod.idKolek = row.Cells["id_kolek"].Value.ToString();
                    mod.tingkatKolek = row.Cells["tingkat_kolek"].Value.ToString();
                    mod.TxtHariKolek.Text = row.Cells["hari_kolek"].Value.ToString();
                    mod.DtpKolek.CustomFormat = "dd/MM/yyyy";
                    mod.DtpKolek.Text = row.Cells["tgl_kolek"].Value.ToString();
                    mod.ShowDialog();
                }
            }
        }

        private void DgvKolekEdit_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (DgvKolekEdit.Columns[e.ColumnIndex].Name == "hapus_kolek_edit") {
                DataGridViewRow row = this.DgvKolekEdit.Rows[e.RowIndex];
                DgvKolekEdit.Rows.Remove(DgvKolekEdit.Rows[e.RowIndex]);
            }
        }

        private void DgvKolekDelete_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (DgvKolekDelete.Columns[e.ColumnIndex].Name == "hapus_kolek_del") {
                DataGridViewRow row = this.DgvKolekDelete.Rows[e.RowIndex];
                DgvKolekDelete.Rows.Remove(DgvKolekDelete.Rows[e.RowIndex]);
            }
        }

        private void ActAgunan(string act, string noAct) {
            if (act == "edited") {
                MessageBox.Show("Anda Sudah Mengedit Agunan Dengan Nomor " + noAct, "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if (act == "deleted") {
                MessageBox.Show("Anda Sudah Menghapus Agunan Dengan Nomor " + noAct, "Pesan Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DgvAgunan_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            bool check = false;
            string act = "";
            if (DgvAgunan.Columns[e.ColumnIndex].Name == "hapus") {
                DataGridViewRow row = this.DgvAgunan.Rows[e.RowIndex];
                
                foreach (DataGridViewRow rowEdit in DgvAgunanEdit.Rows) {
                    if (rowEdit.Cells["no_agunan_edit"].Value.ToString() == row.Cells["no"].Value.ToString()) {
                        check = true;
                        act = "edited";
                    }
                }

                foreach (DataGridViewRow rowDel in DgvAgunanDelete.Rows) {
                    if (rowDel.Cells["no_agunan_del"].Value.ToString() == row.Cells["no"].Value.ToString()) {
                        check = true;
                        act = "deleted";
                    }
                }

                if (check == true) {
                    ActAgunan(act, row.Cells["no"].Value.ToString());
                } else {
                    DgvAgunanDelete.Rows.Add(row.Cells["no"].Value.ToString(), row.Cells["id_agunan"].Value.ToString(), row.Cells["bank"].Value.ToString(),
                    row.Cells["independen"].Value.ToString(), row.Cells["njop"].Value.ToString(), row.Cells["tgl_penilaian"].Value.ToString(), row.Cells["penilai"].Value.ToString(),
                    row.Cells["paripasu_agun"].Value.ToString(), row.Cells["pemilik"].Value.ToString(), row.Cells["bukti"].Value.ToString(), row.Cells["alm_agun"].Value.ToString(),
                    row.Cells["dati_agun"].Value.ToString(), row.Cells["asuransi_agun"].Value.ToString());
                }

            }

            FrmModalAgunan mod = new FrmModalAgunan(this);
            if (DgvAgunan.Columns[e.ColumnIndex].Name == "edit") {
                DataGridViewRow row = this.DgvAgunan.Rows[e.RowIndex];

                foreach (DataGridViewRow rowDel in DgvAgunanDelete.Rows) {
                    if (rowDel.Cells["no_agunan_del"].Value.ToString() == row.Cells["no"].Value.ToString()) {
                        check = true;
                        act = "deleted";
                    }
                }

                foreach (DataGridViewRow rowEdit in DgvAgunanEdit.Rows) {
                    if (rowEdit.Cells["no_agunan_edit"].Value.ToString() == row.Cells["no"].Value.ToString()) {
                        check = true;
                        act = "edited";
                    }
                }

                if (check == true) {
                    ActAgunan(act, row.Cells["no"].Value.ToString());
                } else {
                    mod.noAgun = row.Cells["no"].Value.ToString();
                    mod.idAgun = row.Cells["id_agunan"].Value.ToString();
                    mod.TxtBank.Text = row.Cells["bank"].Value.ToString();
                    mod.TxtIndependen.Text = row.Cells["independen"].Value.ToString();
                    mod.TxtNjop.Text = row.Cells["njop"].Value.ToString();
                    mod.DtpPenilaian.Text = row.Cells["tgl_penilaian"].Value.ToString();
                    mod.TxtPenilai.Text = row.Cells["penilai"].Value.ToString();
                    mod.paripasu = row.Cells["paripasu_agun"].Value.ToString();
                    mod.TxtPemilik.Text = row.Cells["pemilik"].Value.ToString();
                    mod.bukti = row.Cells["bukti"].Value.ToString();
                    mod.TxtAlmAgunan.Text = row.Cells["alm_agun"].Value.ToString();
                    mod.TxtDatiAgunan.Text = row.Cells["dati_agun"].Value.ToString();
                    mod.asuransi = row.Cells["asuransi_agun"].Value.ToString();
                    mod.ShowDialog();
                }
            }
        }

        private void DgvAgunanEdit_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (DgvAgunanEdit.Columns[e.ColumnIndex].Name == "hapus_agn_edit") {
                DataGridViewRow row = this.DgvAgunanEdit.Rows[e.RowIndex];
                DgvAgunanEdit.Rows.Remove(DgvAgunanEdit.Rows[e.RowIndex]);
            }
        }

        private void DgvAgunanDelete_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (DgvAgunanDelete.Columns[e.ColumnIndex].Name == "hapus_agn_del") {
                DataGridViewRow row = this.DgvAgunanDelete.Rows[e.RowIndex];
                DgvAgunanDelete.Rows.Remove(DgvAgunanDelete.Rows[e.RowIndex]);
            }
        }
    }
}
