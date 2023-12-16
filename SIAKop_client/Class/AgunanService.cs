using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace SIAKop_client.Class {
    class AgunanService :Agunan {

        SqlService dbServ;
        DataTable dtTmp;

        public AgunanService() {
            dbServ = new SqlService();
            dtTmp = new DataTable();
        }

        public String Kodegen(string id_kredit) {
            int urutan = 0;
            string kode = "";
            dbServ.query = "select max(right(id_agunan, 3)) as kode FROM kredit_agunan where id_agunan like '%" + id_kredit + "%'";
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
                dbServ.query = "insert into kredit_agunan (id_kredit, id_user, id_agunan, nilai_bank, nilai_independen, njop, tgl_penilaian, " +
                    "nm_penilai, paripasu, nm_pemilik, bukti_pemilik, alamat_agunan, dati_2_agunan, asuransi_agunan, created_at, updated_at) values" +
                    "('" + IDKREDIT + "', '" + IDUSER + "', '" + IDAGN + "', '" + BANK + "', '" + INDEPENDEN + "', '" + NJOP + "', '" + TGLPENILAIAN + "', " +
                    "'" + PENILAI + "', '" + PARIPASU + "', '" + PEMILIK + "', '" + BUKTI + "', '" + ALAMAT + "', '" + DATI2 + "', '" + ASURANSI + "', '" + CREATED + "', '" + UPDATED + "')";
                if (!(dbServ.ExecNonQuery(dbServ.query) > 0)) {
                    MessageBox.Show("Error, Data Agunan Tidak Tersimpan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex) {
                MessageBox.Show("Error:- " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Edit(String IdAgunan) {
            try {
                dbServ.query = "update kredit_agunan set id_user='" + IDUSER + "', nilai_bank='" + BANK + "', nilai_independen='" + INDEPENDEN + "', " +
                    "njop='" + NJOP + "', tgl_penilaian='" + TGLPENILAIAN + "', nm_penilai='" + PENILAI + "', paripasu='" + PARIPASU + "', " +
                    "nm_pemilik='" + PEMILIK + "', bukti_pemilik='" + BUKTI + "', alamat_agunan='" + ALAMAT + "', dati_2_agunan='" + DATI2 + "', " +
                    "asuransi_agunan='" + ASURANSI + "', updated_at='" + UPDATED + "' where id_agunan='" + IdAgunan + "'";
                if (!(dbServ.ExecNonQuery(dbServ.query) > 0)) {
                    MessageBox.Show("Error, Data Agunan Tidak Tersimpan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex) {
                MessageBox.Show("Error:- " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Delete(String IdAgunan) {
            try {
                dbServ.query = "update kredit_agunan set id_user='" + IDUSER + "', deleted_at='" + DELETED + "' where id_agunan='" + IdAgunan + "'";
                if (!(dbServ.ExecNonQuery(dbServ.query) > 0)) {
                    MessageBox.Show("Error, Data Agunan Tidak Terhapus!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex) {
                MessageBox.Show("Error:- " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataTable SearchAgunanById(String id) {
            dbServ.query = "SELECT ROW_NUMBER() OVER(ORDER BY id_agunan) as no, id_agunan, nilai_bank, nilai_independen, njop, tgl_penilaian, nm_penilai, paripasu, nm_pemilik, bukti_pemilik, alamat_agunan, " +
                "dati_2_agunan,asuransi_agunan FROM kredit_agunan WHERE id_kredit='" + id + "' and deleted_at is null ORDER BY id_agunan ASC";
            return dbServ.ExecQuery(dbServ.query);
        }
    }
}
