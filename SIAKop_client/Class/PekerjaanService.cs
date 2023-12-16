using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace SIAKop_client.Class {
    class PekerjaanService : Pekerjaan {

        SqlService dbServ;
        DataTable dtTmp;

        public PekerjaanService() {
            dbServ = new SqlService();
            dtTmp = new DataTable();
        }

        public void Add() {
            try {
                dbServ.query = "insert into pekerjaan (id_anggota, nm_pekerjaan, tempat_bekerja, bid_usaha, created_at, updated_at) values" +
                    "('" + ID + "', '" + KERJAAN + "', '" + TEMPATBEKERJA + "', '" + BIDUSAHA + "', '" + CREATED + "', '" + UPDATED + "')";
                if (!(dbServ.ExecNonQuery(dbServ.query) > 0)) {
                    MessageBox.Show("Error, Data Pekerjaan Tidak Tersimpan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex) {
                MessageBox.Show("Error:- " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Edit(String id) {
            try {
                dbServ.query = "update pekerjaan set nm_pekerjaan='" + KERJAAN + "', tempat_bekerja='" + TEMPATBEKERJA + "', bid_usaha='" + BIDUSAHA + "', " +
                    "updated_at='" + UPDATED + "' where id_anggota='" + id + "'";
                if (!(dbServ.ExecNonQuery(dbServ.query) > 0)) {
                    MessageBox.Show("Error, Data Kredit Tidak Tersimpan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex) {
                MessageBox.Show("Error:- " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
