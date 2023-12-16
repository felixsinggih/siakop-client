using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIAKop_client.Class {
    class Pekerjaan {
        private String _id;
        private String _pekerjaan;
        private String _tempat_bekerja;
        private String _bidang_usaha;
        private String _created;
        private String _updated;

        public Pekerjaan() {
            _id = "";
            _pekerjaan = "";
            _tempat_bekerja = "";
            _bidang_usaha = "";
            _created = "";
            _updated = "";
        }

        public String ID {
            get { return _id; }
            set { _id = value; }
        }

        public String KERJAAN {
            get { return _pekerjaan; }
            set { _pekerjaan = value; }
        }

        public String TEMPATBEKERJA {
            get { return _tempat_bekerja; }
            set { _tempat_bekerja = value; }
        }

        public String BIDUSAHA {
            get { return _bidang_usaha; }
            set { _bidang_usaha = value; }
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
