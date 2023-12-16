using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIAKop_client.Class {
    class Kolektabilitas {
        private String _id_kredit;
        private String _id_user;
        private String _id_kolektabilitas;
        private String _tingkat;
        private String _hari;
        private String _tgl;
        private String _created;
        private String _updated;
        private String _deleted;

        public Kolektabilitas() {
            _id_kredit = "";
            _id_user = "";
            _id_kolektabilitas = "";
            _tingkat = "";
            _hari = "";
            _tgl = "";
            _created = "";
            _updated = "";
            _deleted = "";
        }

        public String IDKREDIT {
            get { return _id_kredit; }
            set { _id_kredit = value; }
        }

        public String IDUSER {
            get { return _id_user; }
            set { _id_user = value; }
        }

        public String IDKOLEK {
            get { return _id_kolektabilitas; }
            set { _id_kolektabilitas = value; }
        }

        public String TINGKAT {
            get { return _tingkat; }
            set { _tingkat = value; }
        }

        public String HARI {
            get { return _hari; }
            set { _hari = value; }
        }

        public String TGL {
            get { return _tgl; }
            set { _tgl = value; }
        }

        public String CREATED {
            get { return _created; }
            set { _created = value; }
        }

        public String UPDATED {
            get { return _updated; }
            set { _updated = value; }
        }

        public String DELETED {
            get { return _deleted; }
            set { _deleted = value; }
        }
    }
}
