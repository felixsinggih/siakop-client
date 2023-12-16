using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace SIAKop_client.Class {
    abstract class SqlConn {
        public abstract int ExecNonQuery(String query);
        public abstract DataTable ExecQuery(String query);
    }
}
