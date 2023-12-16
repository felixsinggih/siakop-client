using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIAKop_client.Class {
    class AppSession {
        public static string _database;
        public static string _id_user;
        public static string _name;
        public static string _username;
        public static string _level;
        public static string _status;
        public static string _currentVersion = "1.0.0.0";
        public static string _version;
        public static string _minVersion;
        public static string _maintenance;
        public static string _statusKoperasi;

        public AppSession() {
            _database = "";
            _id_user = "";
            _name = "";
            _username = "";
            _level = "";
            _status = "";
            _version = "";
            _minVersion = "";
            _maintenance = "";
            _statusKoperasi = "";
        }

        public String DATABASE {
            get { return _database; }
            set { _database = value; }
        }

        public String IDUSER {
            get { return _id_user; }
            set { _id_user = value; }
        }

        public String NAME {
            get { return _name; }
            set { _name = value; }
        }

        public String USERNAME {
            get { return _username; }
            set { _username = value; }
        }

        public String LEVEL {
            get { return _level; }
            set { _level = value; }
        }

        public String STATUS {
            get { return _status; }
            set { _status = value; }
        }

        public String VERSION {
            get { return _version; }
            set { _version = value; }
        }

        public String MINVERSION {
            get { return _minVersion; }
            set { _minVersion = value; }
        }

        public String MAINTENANCE {
            get { return _maintenance;  }
            set { _maintenance = value;  }
        }

        public String STATUSKOPERASI {
            get { return _statusKoperasi; }
            set { _statusKoperasi = value; }
        }
    }
}
