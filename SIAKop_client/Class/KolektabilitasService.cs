using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace SIAKop_client.Class {
    class KolektabilitasService :Kolektabilitas {

        SqlService dbServ;
        DataTable dtTmp;

        public KolektabilitasService() {
            dbServ = new SqlService();
            dtTmp = new DataTable();
        }

        public String Kodegen(string id_kredit) {
            int urutan = 0;
            string kode = "";
            dbServ.query = "select max(right(id_kolektabilitas, 3)) as kode FROM kredit_kolektabilitas where id_kolektabilitas like '%" + id_kredit + "%'";
            dtTmp = dbServ.ExecQuery(dbServ.query);
            if (dtTmp.Rows.Count > 0) {
                if (dtTmp.Rows[0][0].ToString() == "") {
                    urutan = 1;
                } else {
                    urutan = int.Parse(dtTmp.Rows[0][0].ToString()) + 1;
                }

                if (urutan >= 0 && urutan <= 9) {
                    kode = id_kredit + "00" + urutan.ToString();
                } else if (urutan >= 10 && urutan <= 99) {
                    kode = id_kredit + "0" + urutan.ToString();
                } else if (urutan >= 100) {
                    kode = id_kredit + urutan.ToString();
                }
            }
            return kode;
        }

        public void Add() {
            try {
                dbServ.query = "insert into kredit_kolektabilitas (id_kredit, id_user, id_kolektabilitas, tingkat_kolek, hari_kolek, tgl_kolek, created_at, updated_at) values " +
                    "('" + IDKREDIT + "', '" + IDUSER + "', '" + IDKOLEK + "', '" + TINGKAT + "', '" + HARI + "', '" + TGL + "', '" + CREATED + "', '" + UPDATED + "')";
                if (!(dbServ.ExecNonQuery(dbServ.query) > 0)) {
                    MessageBox.Show("Error, Data Kolektabilitas Tidak Tersimpan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex) {
                MessageBox.Show("Error:- " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Edit(String IdKolek) {
            try {
                dbServ.query = "update kredit_kolektabilitas set id_user='" + IDUSER + "', tingkat_kolek='" + TINGKAT + "', hari_kolek='" + HARI + "', " +
                    "tgl_kolek='" + TGL + "', updated_at='" + UPDATED + "' where id_kolektabilitas='" + IdKolek + "'";
                if (!(dbServ.ExecNonQuery(dbServ.query) > 0)) {
                    MessageBox.Show("Error, Data Kolektabilitas Tidak Tersimpan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex) {
                MessageBox.Show("Error:- " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Delete(String IdKolek) {
            try {
                dbServ.query = "update kredit_kolektabilitas set id_user='" + IDUSER + "', deleted_at='" + DELETED + "' where id_kolektabilitas='" + IdKolek + "'";
                if (!(dbServ.ExecNonQuery(dbServ.query) > 0)) {
                    MessageBox.Show("Error, Data Kolektabilitas Tidak Terhapus!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex) {
                MessageBox.Show("Error:- " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable SearchByIdKredit(String IdKredit) {
            dbServ.query = "SELECT ROW_NUMBER() OVER(ORDER BY tgl_kolek) as no, id_kolektabilitas, tingkat_kolek, hari_kolek, tgl_kolek from kredit_kolektabilitas " +
                "where id_kredit='" + IdKredit + "' and deleted_at is null " +
                "ORDER BY tgl_kolek ASC";
            return dbServ.ExecQuery(dbServ.query);
        }
    }
}
