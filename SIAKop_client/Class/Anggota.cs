using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIAKop_client.Class {
    class Anggota {
        private String _id_anggota;
        private String _nama;
        private String _tempat_lahir;
        private String _tanggal_lahir;
        private String _jenis_kelamin;
        private String _ktp;
        private String _npwp;
        private String _paspor;
        private String _alias;
        private String _ibu;
        private String _create;
        private String _update;

        public Anggota() {
            _id_anggota = "";
            _nama = "";
            _tempat_lahir = "";
            _tanggal_lahir = "";
            _jenis_kelamin = "";
            _ktp = "";
            _npwp = "";
            _paspor = "";
            _alias = "";
            _ibu = "";
            _create = "";
            _update = "";
        }

        public String IDANG {
            get { return _id_anggota; }
            set { _id_anggota = value; }
        }

        public String NAMA {
            get { return _nama; }
            set { _nama = value; }
        }

        public String TEMPAT {
            get { return _tempat_lahir; }
            set { _tempat_lahir = value; }
        }

        public String TANGGAL {
            get { return _tanggal_lahir; }
            set { _tanggal_lahir = value; }
        }

        public String JENIS {
            get { return _jenis_kelamin; }
            set { _jenis_kelamin = value; }
        }

        public String KTP {
            get { return _ktp; }
            set { _ktp = value; }
        }

        public String NPWP {
            get { return _npwp; }
            set { _npwp = value; }
        }

        public String PASPOR {
            get { return _paspor; }
            set { _paspor = value; }
        }

        public String ALIAS {
            get { return _alias; }
            set { _alias = value; }
        }

        public String IBU {
            get { return _ibu; }
            set { _ibu = value; }
        }

        public String CREATED {
            get { return _create; }
            set { _create = value; }
        }

        public String UPDATED {
            get { return _update; }
            set { _update = value; }
        }
    }
}
