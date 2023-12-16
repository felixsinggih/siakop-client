using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIAKop_client.Class {
    class History {
        private String _id;
        private String _activity;
        private String _time;

        public History() {
            _id = "";
            _activity = "";
            _time = "";
        }

        public String ID {
            get { return _id; }
            set { _id = value; }
        }

        public String ACT {
            get { return _activity; }
            set { _activity = value; }
        }

        public String TIME {
            get { return _time; }
            set { _time = value; }
        }
    }
}
