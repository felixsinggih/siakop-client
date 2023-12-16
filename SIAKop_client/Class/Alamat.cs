using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIAKop_client.Class {
    class Alamat {
        private String _id;
        private String _alamat;
        private String _kelurahan;
        private String _kecamatan;
        private String _dati2;
        private String _kodepos;
        private String _negara;
        private String _created;
        private string _updated;

        public Alamat() {
            _id = "";
            _alamat = "";
            _kelurahan = "";
            _kecamatan = "";
            _dati2 = "";
            _kodepos = "";
            _negara = "";
            _created = "";
            _updated = "";
        }

        public String ID {
            get { return _id; }
            set { _id = value; }
        }

        public String ALM {
            get { return _alamat; }
            set { _alamat = value; }
        }

        public String KEL {
            get { return _kelurahan; }
            set { _kelurahan = value; }
        }

        public String KEC {
            get { return _kecamatan; }
            set { _kecamatan = value; }
        }

        public String DATI2 {
            get { return _dati2; }
            set { _dati2 = value; }
        }

        public String KODEPOS {
            get { return _kodepos; }
            set { _kodepos = value; }
        }

        public String NEGARA {
            get { return _negara; }
            set { _negara = value; }
        }

        public String CREATED {
            get { return _created; }
            set { _created = value; }
        }

        public String UPDATED {
            get { return _updated; }
            set { _updated = value; }
        }
    }
}
