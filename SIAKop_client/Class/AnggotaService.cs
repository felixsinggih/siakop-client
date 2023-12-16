using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace SIAKop_client.Class {
    class AnggotaService :Anggota {

        SqlService dbServ;
        DataTable dtTmp;

        public AnggotaService() {
            dbServ = new SqlService();
            dtTmp = new DataTable();
        }

        public string CekKtp(String ktp) {
            string Ktp = "" ;
            dbServ.query = "select ktp from anggota where ktp='" + ktp + "'";
            dtTmp = dbServ.ExecQuery(dbServ.query);
            if (dtTmp.Rows.Count > 0) {
                Ktp = dtTmp.Rows[0][0].ToString();
            }
            return Ktp;
        }

        public String Kodegen() {
            String kode_koperasi = AppSession._database;
            //String kode_koperasi = AppSession._database.Substring(14, 7);
            //String kode_koperasi = AppSession._database.Substring(23, 7);
            String tanggal = DateTime.Now.ToString("yyMM");
            String param = kode_koperasi + tanggal + "1";
            int urutan = 0;
            string kode = "";
            String id_anggota = "";
            dbServ.query = "select max(right(id_anggota, 3)) as kode FROM anggota where id_anggota like '%" + param + "%'";
            dtTmp = dbServ.ExecQuery(dbServ.query);
            if (dtTmp.Rows.Count > 0) {
                if (dtTmp.Rows[0][0].ToString() == "") {
                    urutan = 1;
                } else {
                    urutan = int.Parse(dtTmp.Rows[0][0].ToString()) + 1;
                }

                if (urutan >= 0 && urutan <= 9) {
                    kode = param + "00" + urutan.ToString();
                } else if (urutan >= 10 && urutan <= 99) {
                    kode = param + "0" + urutan.ToString();
                } else if (urutan >= 100) {
                    kode = param + urutan.ToString();
                }
                id_anggota = kode;
            }
            return id_anggota;
        }

        public void Add() {
            try {
                dbServ.query = "insert into anggota (id_anggota, nama, tempat_lahir, tgl_lahir, jns_kelamin, ktp, npwp, paspor, alias, nama_ibu, created_at, updated_at) values " +
                    "('" + IDANG + "', '" + NAMA + "', '" + TEMPAT + "', '" + TANGGAL + "', '" + JENIS + "', '" + KTP + "', '" + NPWP + "', '" + PASPOR + "', " +
                    "'" + ALIAS + "', '" + IBU + "', '" + CREATED + "', '" + UPDATED + "')";
                if (!(dbServ.ExecNonQuery(dbServ.query) > 0)) {
                    MessageBox.Show("Error, Data Anggota Tidak Tersimpan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex) {
                MessageBox.Show("Error:- " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Edit(String idAng) {
            try {
                dbServ.query = "update anggota set nama='" + NAMA + "', tempat_lahir='" + TEMPAT + "', tgl_lahir='" + TANGGAL + "', jns_kelamin='" + JENIS + "', " +
                    "ktp='" + KTP + "', npwp='" + NPWP + "', paspor='" + PASPOR + "', nama_ibu='" + IBU + "', updated_at='" + UPDATED + "' " +
                    "where id_anggota='" + idAng + "'";
                if (!(dbServ.ExecNonQuery(dbServ.query) > 0)) {
                    MessageBox.Show("Error, Data Kredit Tidak Tersimpan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex) {
                MessageBox.Show("Error:- " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string Count(String param) {
            String totalRows;
            dbServ.query = "SELECT ROW_NUMBER() OVER(ORDER BY id_anggota) as no, id_anggota, ktp, nama, tempat_lahir, tgl_lahir, nama_ibu FROM anggota " +
                "where (id_anggota like '%" + param + "%' or nama like '%" + param + "%' or ktp like '%" + param + "%' or tgl_lahir like '%" + param + "%') " +
                "ORDER BY no ASC";
            dtTmp = dbServ.ExecQuery(dbServ.query);
            totalRows = dtTmp.Rows.Count.ToString();
            return totalRows;
        }

        public DataTable Search(String param, int limit, int offset) {
            dbServ.query = "SELECT ROW_NUMBER() OVER(ORDER BY id_anggota) as no, id_anggota, ktp, nama, tempat_lahir, tgl_lahir, nama_ibu FROM anggota " +
                "where (id_anggota like '%" + param + "%' or nama like '%" + param + "%' or ktp like '%" + param + "%' or tgl_lahir like '%" + param + "%') " +
                "ORDER BY no ASC limit " + limit + " offset " + offset + "";
            return dbServ.ExecQuery(dbServ.query);
        }

        public DataTable SearchAnggotaById(String id) {
            dbServ.query = "SELECT a.id_anggota, a.nama, a.tempat_lahir, a.tgl_lahir, a.jns_kelamin, a.ktp, a.npwp, a.paspor, a.alias, a.nama_ibu, kk.telp, kk.email, " +
                "ka.alamat, ka.kelurahan, ka.kecamatan, ka.dati_2, ka.kodepos, ka.negara, kp.nm_pekerjaan, kp.tempat_bekerja, kp.bid_usaha " +
                "FROM anggota a, kontak kk, alamat ka, pekerjaan kp " +
                "WHERE kk.id_anggota = a.id_anggota " +
                "AND ka.id_anggota = a.id_anggota AND kp.id_anggota = a.id_anggota " +
                "AND a.id_anggota='" + id + "'" +
                "ORDER BY kk.updated_at, ka.updated_at, kp.updated_at DESC";
            return dbServ.ExecQuery(dbServ.query);
        }
    }
}
