using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace SIAKop_client.Class {
    class SqlService : SqlConn {

        MySqlConnection cn;
        private String strCon = "";
        private MySqlCommand sComm;
        private MySqlDataAdapter dtAdp;
        public String query;

        public SqlService() {
            strCon = ConStr();
            cn = new MySqlConnection(strCon);
            sComm = new MySqlCommand();
            dtAdp = new MySqlDataAdapter();
        }

        public string ConStr() {
            AppSetting setting = new AppSetting();
            return setting.GetConnectionString("cn");
        }

        public void OpenConnection() {
            if (cn.State == ConnectionState.Closed) {
                try {
                    cn.Open();
                }
                catch (Exception) { }
            }
        }

        public void CloseConnection() {
            cn.Close();
        }

        public override int ExecNonQuery(String query) {
            int retVal = -1;

            try {
                OpenConnection();
                sComm.Connection = cn;
                sComm.CommandText = query;
                retVal = sComm.ExecuteNonQuery();
            }
            catch (Exception) { }
            finally {
                CloseConnection();
            }

            return retVal;
        }

        public override DataTable ExecQuery(String query) {
            DataTable retVal = new DataTable();

            try {
                OpenConnection();
                sComm.Connection = cn;
                sComm.CommandText = query;
                dtAdp.SelectCommand = sComm;
                dtAdp.Fill(retVal);
            }
            catch (Exception) { }
            finally {
                CloseConnection();
            }

            return retVal;
        }
    }
}
