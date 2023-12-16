using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SIAKop_client.Class {
    class ConfirmService {

        SqlService dbServ;
        DataTable dtTmp;

        public ConfirmService() {
            dbServ = new SqlService();
            dtTmp = new DataTable();
        }

        public bool ConfrimSave(String user, String pass) {
            bool Auth = false;
            dbServ.query = "select * from users where username='" + user + "' and password=sha1('" + pass + "')";
            dtTmp = dbServ.ExecQuery(dbServ.query);
            if (dtTmp.Rows.Count > 0) {
                Auth = true;
            }
            return Auth;
        }

        public DataTable CheckMan() {
            dbServ.query = "select * from users where user_level='1' and user_status='1'";
            return dbServ.ExecQuery(dbServ.query);
        }
    }
}
