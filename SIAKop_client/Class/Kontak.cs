using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIAKop_client.Class {
    class Kontak {
        private String _id;
        private String _telepon;
        private String _email;
        private String _created;
        private String _updated;

        public Kontak() {
            _id = "";
            _telepon = "";
            _email = "";
            _created = "";
            _updated = "";
        }

        public String ID {
            get { return _id; }
            set { _id = value; }
        }

        public String TELP {
            get { return _telepon; }
            set { _telepon = value; }
        }

        public String EMAIL {
            get { return _email; }
            set { _email = value; }
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
