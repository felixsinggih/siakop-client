using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SIAKop_client.Class {
    class Kredit {
        private String _id_kredit;
        private String _id_anggota;
        private String _id_user;
        private String _sifat;
        private String _valuta;
        private String _bunga;
        private String _plafon;
        private String _baki_debet;
        private String _pokok;
        private String _frek_pokok;
        private String _frek_bunga;
        private String _sek_eko;
        private String _jenis;
        private String _kondisi;
        private String _tgl_kondisi;
        private String _sbb_macet;
        private String _tgl_macet;
        private String _akad_awal;
        private String _jatuh_tempo;
        private String _perpanjangan;
        private String _created;
        private String _updated;

        public Kredit() {
            _id_kredit = "";
            _id_anggota = "";
            _id_user = "";
            _sifat = "";
            _valuta = "";
            _bunga = "";
            _plafon = "";
            _baki_debet = "";
            _pokok = "";
            _frek_pokok = "";
            _frek_bunga = "";
            _sek_eko = "";
            _jenis = "";
            _kondisi = "";
            _tgl_kondisi = "";
            _sbb_macet = "";
            _tgl_macet = "";
            _akad_awal = "";
            _jatuh_tempo = "";
            _perpanjangan = "";
            _created = "";
            _updated = "";
        }

        public String IDKREDIT {
            get { return _id_kredit; }
            set { _id_kredit = value; }
        }

        public String IDANG {
            get { return _id_anggota; }
            set { _id_anggota = value; }
        }

        public String IDUSER {
            get { return _id_user; }
            set { _id_user = value; }
        }

        public String SIFAT {
            get { return _sifat; }
            set { _sifat = value; }
        }

        public String VALUTA {
            get { return _valuta; }
            set { _valuta = value; }
        }

        public String BUNGA {
            get { return _bunga; }
            set { _bunga = value; }
        }

        public String PLAFON {
            get { return _plafon; }
            set { _plafon = value; }
        }

        public String BAKIDEBET {
            get { return _baki_debet; }
            set { _baki_debet = value; }
        }

        public String POKOK {
            get { return _pokok; }
            set { _pokok = value; }
        }

        public String FREKPOKOK {
            get { return _frek_pokok; }
            set { _frek_pokok = value; }
        }

        public String FREKBUNGA {
            get { return _frek_bunga; }
            set { _frek_bunga = value; }
        }

        public String SEKTOR {
            get { return _sek_eko; }
            set { _sek_eko = value; }
        }

        public String JENIS {
            get { return _jenis; }
            set { _jenis = value; }
        }

        public String KONDISI {
            get { return _kondisi; }
            set { _kondisi = value; }
        }

        public String TGLKONDISI {
            get { return _tgl_kondisi; }
            set { _tgl_kondisi = value; }
        }

        public String MACET {
            get { return _sbb_macet; }
            set { _sbb_macet = value; }
        }

        public String TGLMACET {
            get { return _tgl_macet; }
            set { _tgl_macet = value; }
        }

        public String AKAD {
            get { return _akad_awal; }
            set { _akad_awal = value; }
        }

        public String JTHTEMPO {
            get { return _jatuh_tempo; }
            set { _jatuh_tempo = value; }
        }

        public String PERPANJANGAN {
            get { return _perpanjangan; }
            set { _perpanjangan = value; }
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
