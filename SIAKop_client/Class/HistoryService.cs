using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace SIAKop_client.Class {
    class HistoryService : History {

        SqlService dbServ;
        DataTable dtTmp;

        public HistoryService() {
            dbServ = new SqlService();
            dtTmp = new DataTable();
        }

        public void Add() {
            try {
                dbServ.query = "insert into activity_log (id_user, activity, created_at) values" +
                    "('" + ID + "', '" + ACT + "', '" + TIME + "')";
                if (!(dbServ.ExecNonQuery(dbServ.query) > 0)) {
                    MessageBox.Show("Error, Data History Tidak Tersimpan!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex) {
                MessageBox.Show("Error:- " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public String Count() {
            String totalRows;
            dbServ.query = "SELECT * FROM  activity_log";
            dtTmp = dbServ.ExecQuery(dbServ.query);
            totalRows = dtTmp.Rows.Count.ToString();
            return totalRows;
        }

        public DataTable ShowHistory(int limit, int offset) {
            dbServ.query = "SELECT users.id_user, users.name, activity_log.activity, activity_log.created_at FROM users, activity_log " +
                "WHERE users.id_user = activity_log.id_user " +
                "ORDER BY activity_log.created_at DESC limit " + limit + " offset " + offset + "";
            return dbServ.ExecQuery(dbServ.query);
        }
    }
}
