using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIAKop_client.Class {
    class Agunan {
        private String _id_kredit;
        private String _id_user;
        private String _id_agunan;
        private String _nilai_bank;
        private String _nilai_independen;
        private String _njop;
        private String _tgl_penilaian;
        private String _nama_penilai;
        private String _paripsu;
        private String _nama_pemilik;
        private String _bukti_kepemilikan;
        private String _alamat_jaminan;
        private String _dati2;
        private String _asuransi;
        private String _created;
        private String _updated;
        private String _deleted;

        public Agunan() {
            _id_kredit = "";
            _id_user = "";
            _id_agunan = "";
            _nilai_bank = "";
            _nilai_independen = "";
            _njop = "";
            _tgl_penilaian = "";
            _nama_penilai = "";
            _paripsu = "";
            _nama_pemilik = "";
            _bukti_kepemilikan = "";
            _alamat_jaminan = "";
            _dati2 = "";
            _asuransi = "";
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

        public String IDAGN {
            get { return _id_agunan; }
            set { _id_agunan = value; }
        }

        public String BANK {
            get { return _nilai_bank; }
            set { _nilai_bank = value; }
        }

        public String INDEPENDEN {
            get { return _nilai_independen; }
            set { _nilai_independen = value; }
        }

        public String NJOP {
            get { return _njop; }
            set { _njop = value; }
        }

        public String TGLPENILAIAN {
            get { return _tgl_penilaian; }
            set { _tgl_penilaian = value; }
        }

        public String PENILAI {
            get { return _nama_penilai; }
            set { _nama_penilai = value; }
        }

        public String PARIPASU {
            get { return _paripsu; }
            set { _paripsu = value; }
        }

        public String PEMILIK {
            get { return _nama_pemilik; }
            set { _nama_pemilik = value; }
        }

        public String BUKTI {
            get { return _bukti_kepemilikan; }
            set { _bukti_kepemilikan = value; }
        }

        public String ALAMAT {
            get { return _alamat_jaminan; }
            set { _alamat_jaminan = value; }
        }

        public String DATI2 {
            get { return _dati2; }
            set { _dati2 = value; }
        }

        public String ASURANSI {
            get { return _asuransi; }
            set { _asuransi = value; }
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
