using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace SIAKop_client.Class {
    class AlamatService :Alamat {

        SqlService dbServ;
        DataTable dtTmp;

        public AlamatService() {
            dbServ = new SqlService();
            dtTmp = new DataTable();
        }

        public void Add() {
            try {
                dbServ.query = "insert into alamat (id_anggota, alamat, kelurahan, kecamatan, dati_2, kodepos, negara, created_at, updated_at) values" +
                    "('" + ID + "', '" + ALM + "', '" + KEL + "', '" + KEC + "', '" + DATI2 + "', '" + KODEPOS + "', '" + NEGARA + "', '" + CREATED + "', '" + UPDATED + "')";
                if (!(dbServ.ExecNonQuery(dbServ.query) > 0)) {
                    MessageBox.Show("Error, Data Alamat Tidak Tersimpan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex) {
                MessageBox.Show("Error:- " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Edit(String id) {
            try {
                dbServ.query = "update alamat set alamat='" + ALM + "', kelurahan='" + KEL + "', kecamatan='" + KEC + "', dati_2='" + DATI2 + "', " +
                    "kodepos='" + KODEPOS + "', negara='" + NEGARA + "', updated_at='" + UPDATED + "' where id_anggota='" + id + "'";
                if (!(dbServ.ExecNonQuery(dbServ.query) > 0)) {
                    MessageBox.Show("Error, Data Kredit Tidak Tersimpan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex) {
                MessageBox.Show("Error:- " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
