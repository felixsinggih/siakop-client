using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SIAKop_client.Class {
    class LoginService {

        SqlService dbServ;
        DataTable dtTmp;

        public LoginService() {
            dbServ = new SqlService();
            dtTmp = new DataTable();
        }

        public bool Login(String user, String pass) {
            bool Auth = false;
            dbServ.query = "select * from allusers_koperasi where username='" + user + "' and password=sha1('" + pass + "')";
            dtTmp = dbServ.ExecQuery(dbServ.query);
            if (dtTmp.Rows.Count > 0) {
                AppSession._id_user = dtTmp.Rows[0][0].ToString();
                AppSession._name = dtTmp.Rows[0][1].ToString();
                AppSession._username = dtTmp.Rows[0][2].ToString();
                AppSession._level = dtTmp.Rows[0][5].ToString();
                AppSession._status = dtTmp.Rows[0][6].ToString();
                AppSession._database = dtTmp.Rows[0][7].ToString();
                AppSession._statusKoperasi = dtTmp.Rows[0][8].ToString();
                Auth = true;
            }
            return Auth;
        }
    }
}
