using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace SIAKop_client.Class {
    class KreditService : Kredit {

        SqlService dbServ;
        DataTable dtTmp;

        public KreditService() {
            dbServ = new SqlService();
            dtTmp = new DataTable();
        }

        public String KodeRandom() {
            Random ran = new Random();
            String b = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int length = 2;
            String random = "";
            for (int i = 0; i < length; i++) {
                int a = ran.Next(26);
                random = random + b.ElementAt(a);
            }
            return random;
        }

        public String Kodegen() {
            String kode_koperasi = AppSession._database;
            //String kode_koperasi = AppSession._database.Substring(14, 7);
            //String kode_koperasi = AppSession._database.Substring(23, 7);
            String tanggal = DateTime.Now.ToString("yyMMdd");
            String param = kode_koperasi + tanggal;
            String random = KodeRandom();
            int urutan = 0;
            string kode = "";
            String id_kredit = "";
            dbServ.query = "select max(right(id_kredit, 3)) as kode FROM kredit where id_kredit like '%" + param + "%'";
            dtTmp = dbServ.ExecQuery(dbServ.query);
            if (dtTmp.Rows.Count > 0) {
                if (dtTmp.Rows[0][0].ToString() == "") {
                    urutan = 1;
                } else {
                    urutan = int.Parse(dtTmp.Rows[0][0].ToString()) + 1;
                }

                if (urutan >= 0 && urutan <= 9) {
                    kode = param + random + "00" + urutan.ToString();
                } else if (urutan >= 10 && urutan <= 99) {
                    kode = param + random + "0" + urutan.ToString();
                } else if (urutan >= 100) {
                    kode = param + random + urutan.ToString();
                }
                id_kredit = kode;
            }
            return id_kredit;
        }

        public void Add() {
            try {
                dbServ.query = "insert into kredit (id_kredit, id_anggota, id_user, sifat, valuta, bunga, plafon, " +
                    "baki_debet, pokok, frek_pokok, frek_bunga, sek_eko, jenis_kredit, kode_kondisi, tgl_kondisi, sbb_macet, tgl_macet, akad_awal, " +
                    "jatuh_tempo, perpanjangan, created_at, updated_at) values ('" + IDKREDIT + "', '" + IDANG + "', '" + IDUSER + "', '" + SIFAT + "', '" + VALUTA + "', " +
                    "'" + BUNGA + "', '" + PLAFON + "', '" + BAKIDEBET + "', '" + POKOK + "', '" + FREKPOKOK + "', '" + FREKBUNGA + "', '" + SEKTOR + "', '" + JENIS + "', " +
                    "'" + KONDISI + "', '" + TGLKONDISI + "', '" + MACET + "', '" + TGLMACET + "', '" + AKAD + "', '" + JTHTEMPO + "', '" + PERPANJANGAN + "', '" + CREATED + "', '" + UPDATED + "')";
                if (!(dbServ.ExecNonQuery(dbServ.query) > 0)) {
                    MessageBox.Show("Error, Data Kredit Tidak Tersimpan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex) {
                MessageBox.Show("Error:- " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Edit(String IdKredit) {
            try {
                dbServ.query = "update kredit set id_user='" + IDUSER + "', sifat='" + SIFAT + "', bunga='" + BUNGA + "', plafon='" + PLAFON + "', baki_debet='" + BAKIDEBET + "', " +
                    "pokok='" + POKOK + "', frek_pokok='" + FREKPOKOK + "', frek_bunga='" + FREKBUNGA + "', sek_eko='" + SEKTOR + "', jenis_kredit='" + JENIS + "', " +
                    "kode_kondisi='" + KONDISI + "', tgl_kondisi='" + TGLKONDISI + "', sbb_macet='" + MACET + "', tgl_macet='" + TGLMACET + "', akad_awal='" + AKAD + "', " +
                    "jatuh_tempo='" + JTHTEMPO + "', perpanjangan='" + PERPANJANGAN + "', updated_at='" + UPDATED + "' where id_kredit='" + IdKredit + "'";
                if (!(dbServ.ExecNonQuery(dbServ.query) > 0)) {
                    MessageBox.Show("Error, Data Kredit Tidak Tersimpan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex) {
                MessageBox.Show("Error:- " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EditKolek(String IdKredit) {
            try {
                dbServ.query = "update kredit set baki_debet='" + BAKIDEBET + "', pokok='" + POKOK + "', frek_pokok='" + FREKPOKOK + "', frek_bunga='" + FREKBUNGA + "', " +
                    "kode_kondisi='" + KONDISI + "', tgl_kondisi='" + TGLKONDISI + "', sbb_macet='" + MACET + "', tgl_macet='" + TGLMACET + "', " +
                    "updated_at='" + UPDATED + "' where id_kredit='" + IdKredit + "'";
                if (!(dbServ.ExecNonQuery(dbServ.query) > 0)) {
                    MessageBox.Show("Error, Data Kredit Tidak Tersimpan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex) {
                MessageBox.Show("Error:- " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string Count(String param) {
            String totalRows;
            dbServ.query = "SELECT ROW_NUMBER() OVER(ORDER BY k.id_kredit) as no, k.id_kredit, a.ktp, a.nama, a.tgl_lahir, k.bunga, k.plafon, k.baki_debet, k.akad_awal, k.jatuh_tempo  FROM kredit k, anggota a " +
                "where k.id_anggota=a.id_anggota " +
                "and (k.id_kredit like '%" + param + "%' or k.id_anggota like '%" + param + "%' or a.nama like '%" + param + "%' or a.ktp like '%" + param + "%') " +
                "ORDER BY no ASC";
            dtTmp = dbServ.ExecQuery(dbServ.query);
            totalRows = dtTmp.Rows.Count.ToString();
            return totalRows;
        }

        public DataTable Search(String param, int limit, int offset) {
            dbServ.query = "SELECT ROW_NUMBER() OVER(ORDER BY k.id_kredit) as no, k.id_kredit, a.ktp, a.nama, a.tgl_lahir, k.bunga, k.plafon, k.baki_debet, k.akad_awal, k.jatuh_tempo  FROM kredit k, anggota a " +
                "where k.id_anggota=a.id_anggota " +
                "and (k.id_kredit like '%" + param + "%' or k.id_anggota like '%" + param + "%' or a.nama like '%" + param + "%' or a.ktp like '%" + param + "%') " +
                "ORDER BY no ASC limit " + limit + " offset " + offset + "";
            return dbServ.ExecQuery(dbServ.query);
        }

        public DataTable SearchKreditById(String id) {
            dbServ.query = "SELECT a.id_anggota, a.nama, a.tempat_lahir, a.tgl_lahir, a.jns_kelamin, a.ktp, a.npwp, a.paspor, a.alias, a.nama_ibu, kk.telp, " +
                "ka.alamat, ka.kelurahan, ka.kecamatan, ka.dati_2, ka.kodepos, ka.negara, kp.nm_pekerjaan, kp.tempat_bekerja, kp.bid_usaha, k.id_kredit, k.sifat, " +
                "k.valuta, k.bunga, k.plafon, k.baki_debet, k.pokok, k.frek_pokok, k.frek_bunga, k.sek_eko, k.jenis_kredit, k.kode_kondisi, k.tgl_kondisi, k.sbb_macet, k.tgl_macet, " +
                "k.akad_awal, k.jatuh_tempo, k.perpanjangan, kk.email " +
                "FROM anggota a, kredit k, kontak kk, alamat ka, pekerjaan kp " +
                "WHERE k.id_anggota = a.id_anggota AND kk.id_anggota = a.id_anggota " +
                "AND ka.id_anggota = a.id_anggota AND kp.id_anggota = a.id_anggota " +
                "AND k.id_kredit = '" + id + "' " +
                "ORDER BY kk.updated_at, ka.updated_at, kp.updated_at DESC";
            return dbServ.ExecQuery(dbServ.query);
        }
    }
}
