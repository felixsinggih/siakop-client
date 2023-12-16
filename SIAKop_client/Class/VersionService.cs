using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace SIAKop_client.Class {
    class VersionService {

        SqlService dbServ;
        DataTable dtTmp;

        public VersionService() {
            dbServ = new SqlService();
            dtTmp = new DataTable();
        }

        public bool AppVersion() {
            bool Ver = false;
            dbServ.query = "SELECT * FROM setting WHERE id='SI01'";
            dtTmp = dbServ.ExecQuery(dbServ.query);
            if (dtTmp.Rows.Count > 0) {
                AppSession._version = dtTmp.Rows[0][1].ToString();
                AppSession._minVersion = dtTmp.Rows[0][2].ToString();
                AppSession._maintenance = dtTmp.Rows[0][3].ToString();
                Ver = true;
            }
            return Ver;
        }
    }
}
