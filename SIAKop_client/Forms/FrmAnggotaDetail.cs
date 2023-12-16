using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SIAKop_client.Class;

namespace SIAKop_client.Forms {
    public partial class FrmAnggotaDetail : Form {
        public string idAnggota;

        public FrmAnggotaDetail() {
            InitializeComponent();
        }

        private void FrmAnggotaDetail_Load(object sender, EventArgs e) {
            using (FrmWait frm = new FrmWait(DataAnggota)) {
                frm.ShowDialog();
            }
        }

        private void DataAnggota() {
            AnggotaService ang = new AnggotaService();
            DataTable DetAng = new DataTable();
            DetAng = ang.SearchAnggotaById(idAnggota);
            DateTime tglLhr = DateTime.Parse(DetAng.Rows[0][3].ToString());
            string Negara = "";
            if (DetAng.Rows[0][17].ToString() == "ID")
                Negara = "Indonesia";

            LblDin.Invoke(new MethodInvoker(delegate { LblDin.Text = ": " + DetAng.Rows[0][0].ToString(); }));
            LblKtp.Invoke(new MethodInvoker(delegate { LblKtp.Text = ": " + DetAng.Rows[0][5].ToString(); }));
            LblNama.Invoke(new MethodInvoker(delegate { LblNama.Text = ": " + DetAng.Rows[0][1].ToString(); }));
            LblTempatLahir.Invoke(new MethodInvoker(delegate { LblTempatLahir.Text = ": " + DetAng.Rows[0][2].ToString() + "," + string.Format("{0 : dd MMMM yyyy}", tglLhr); }));
            LblJenisK.Invoke(new MethodInvoker(delegate { LblJenisK.Text = ": " + DetAng.Rows[0][4].ToString(); }));
            LblNpwp.Invoke(new MethodInvoker(delegate { LblNpwp.Text = ": " + DetAng.Rows[0][6].ToString(); }));
            LblPaspor.Invoke(new MethodInvoker(delegate { LblPaspor.Text = ": " + DetAng.Rows[0][7].ToString(); }));
            LblAlias.Invoke(new MethodInvoker(delegate { LblAlias.Text = ": " + DetAng.Rows[0][8].ToString(); }));
            LblNamaIbu.Invoke(new MethodInvoker(delegate { LblNamaIbu.Text = ": " + DetAng.Rows[0][9].ToString(); }));
            LblTelp.Invoke(new MethodInvoker(delegate { LblTelp.Text = ": " + DetAng.Rows[0][10].ToString(); }));
            LblEmail.Invoke(new MethodInvoker(delegate { LblEmail.Text = ": " + DetAng.Rows[0][11].ToString(); }));
            LblAlamat.Invoke(new MethodInvoker(delegate { LblAlamat.Text = ": " + DetAng.Rows[0][12].ToString() + ", " + DetAng.Rows[0][13].ToString() + ", \r\n  " + DetAng.Rows[0][14].ToString() + ", " + DetAng.Rows[0][15].ToString() + ", " + DetAng.Rows[0][16].ToString() + ", " + Negara; }));
            LblPekerjaan.Invoke(new MethodInvoker(delegate { LblPekerjaan.Text = ": " + DetAng.Rows[0][18].ToString(); }));
            LblTempatBekerja.Invoke(new MethodInvoker(delegate { LblTempatBekerja.Text = ": " + DetAng.Rows[0][19].ToString(); }));
            LblBidUsaha.Invoke(new MethodInvoker(delegate { LblBidUsaha.Text = ": " + DetAng.Rows[0][20].ToString(); }));
        }
    }
}
