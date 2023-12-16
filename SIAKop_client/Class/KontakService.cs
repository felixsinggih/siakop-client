using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace SIAKop_client.Class {
    class KontakService : Kontak {

        SqlService dbServ;
        DataTable dtTmp;

        public KontakService() {
            dbServ = new SqlService();
            dtTmp = new DataTable();
        }

        public void Add() {
            try {
                dbServ.query = "insert into kontak (id_anggota, telp, email, created_at, updated_at) values" +
                    "('" + ID + "', '" + TELP + "', '" + EMAIL + "', '" + CREATED + "', '" + UPDATED + "')";
                if (!(dbServ.ExecNonQuery(dbServ.query) > 0)) {
                    MessageBox.Show("Error, Data Kontak Tidak Tersimpan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex) {
                MessageBox.Show("Error:- " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Edit(String id) {
            try {
                dbServ.query = "update kontak set telp='" + TELP + "', email='" + EMAIL + "', updated_at='" + UPDATED + "' where id_anggota='" + id + "'";
                if (!(dbServ.ExecNonQuery(dbServ.query) > 0)) {
                    MessageBox.Show("Error, Data Kredit Tidak Tersimpan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex) {
                MessageBox.Show("Error:- " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
