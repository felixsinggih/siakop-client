using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using SIAKop_client.Class;

namespace SIAKop_client.Forms {
    public partial class FrmLogin : Form {

        private bool islogin = false;

        public FrmLogin() {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e) {
            textBox1.Text = "admin";
            textBox2.Text = "admin";
            MasterConnection();
        }

        void MasterConnection() {
            //string connectionString = string.Format("Server={0};Database={1};Uid={2};Password={3};", "156.67.211.160", "u2784109_siakop_master", "u2784109_testapp", "logika123");
            string connectionString = string.Format("Server={0};Database={1};Uid={2};Password={3};", "localhost", "siakop_master", "root", "");
            try {
                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.IsConnect) {
                    AppSetting setting = new AppSetting(); 
                    setting.SaveConnectionString("cn", connectionString);
                }

                VersionService vs = new VersionService();
                if(vs.AppVersion() == true) {
                    int currentVersion = Convert.ToInt16(AppSession._currentVersion.Replace(".", ""));
                    int version = Convert.ToInt16(AppSession._version.Replace(".", ""));
                    int minVersion = Convert.ToInt16(AppSession._minVersion.Replace(".", ""));

                    if (AppSession._maintenance == "Y") {
                        MessageBox.Show("Saat ini sedang dilakukan pemeliharaan sistem", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Application.Exit();
                    } else {
                        if (currentVersion < minVersion) {
                            MessageBox.Show("Versi aplikasi yang anda gunakan sudah kadaluarsa, silahkan update aplikasi anda!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                        }
                    }
                }
            }
            catch (Exception e) {
                //MessageBox.Show("Koneksi Server Gagal Tersambung", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Koneksi ke server gagal!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void Login() {
            LoginService login = new LoginService();
            if (login.Login(textBox1.Text, textBox2.Text) == true) {
                if (AppSession._status == "1") {
                    //string connectionString = string.Format("Server={0};Database={1};User ID={2};Password={3};", "156.67.211.160", AppSession._database, "u2784109_testapp", "logika123");
                    string connectionString = string.Format("Server={0};Database={1};User ID={2};Password={3};", "localhost", "siakop_client_" + AppSession._database, "root", "");
                    try {
                        SqlHelper helper = new SqlHelper(connectionString);
                        if (helper.IsConnect) {
                            AppSetting setting = new AppSetting();
                            setting.SaveConnectionString("cn", connectionString);
                            //MessageBox.Show("Connection Has Changed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            FrmMenus frm = new FrmMenus();
                            string myLevel = "";
                            if (AppSession._level == "3")
                                myLevel = "Operator";
                            frm.Show();
                            frm.Text = "SIforA | " + AppSession._username + " | " + AppSession._name + " | " + myLevel;
                            frm.Show();
                            ActivityHistory();
                            this.Hide();
                        }
                    } catch (Exception ex) {
                        MessageBox.Show("Koneksi tidak dapat tersambung", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else {
                    MessageBox.Show("Maaf, Status Anda Sudah Tidak Aktif", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            } else {
                MessageBox.Show("Maaf, Username/Password Salah!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e) {
            if (BgWorker.IsBusy != true) {
                BgWorker.RunWorkerAsync();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13) {
                if (BgWorker.IsBusy != true) {
                    BgWorker.RunWorkerAsync();
                }
            }
        }

        private void ActivityHistory() {
            HistoryService his = new HistoryService();
            his.ID = AppSession._id_user;
            his.ACT = "Login";
            his.TIME= DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            his.Add();
        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e) {
            //MasterConnection();
            LoginService login = new LoginService();
            if (login.Login(textBox1.Text, textBox2.Text) == true) {
                islogin = true;
                BackgroundWorker worker = sender as BackgroundWorker;
                for (int i = 1; i <= 10; i++) {
                    System.Threading.Thread.Sleep(500);
                    worker.ReportProgress(i * 10);
                }
            } else {
                islogin = false;
            }
        }

        private void BgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            ProgLogin.Visible = true;
            ProgLogin.Value = e.ProgressPercentage;
            LblProg.Text = string.Format("Connecting to server ...........");
            LblProg.Location = new Point(241, 164);
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if (islogin == true) {
                if (AppSession._statusKoperasi == "2") {
                    MessageBox.Show("Maaf, Status koperasi anda DIBEKUKAN SEMENTARA. Silahkan hubungi admin untuk informasi terkait hal tersebut.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                } else {
                    if (AppSession._status == "1") {
                        //string connectionString = string.Format("Server={0};Database={1};User ID={2};Password={3};", "156.67.211.160", "u2784109_siakop_client_" + AppSession._database, "u2784109_testapp", "logika123");
                        string connectionString = string.Format("Server={0};Database={1};User ID={2};Password={3};", "localhost", "siakop_client_" + AppSession._database, "root", "");
                        try {
                            SqlHelper helper = new SqlHelper(connectionString);
                            if (helper.IsConnect) {
                                AppSetting setting = new AppSetting();
                                setting.SaveConnectionString("cn", connectionString);
                                FrmMenus frm = new FrmMenus();
                                string myLevel = "";
                                if (AppSession._level == "3")
                                    myLevel = "Operator";
                                frm.Text = "SIforA | " + AppSession._username + " | " + AppSession._name + " | " + myLevel;
                                frm.Show();
                                ActivityHistory();
                                this.Hide();
                            }
                        } catch (Exception ex) {
                            MessageBox.Show("Koneksi tidak dapat tersambung", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Application.Exit();
                        }
                    } else {
                        MessageBox.Show("Maaf, Status Anda Sudah Tidak Aktif", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            } else if (islogin == false) {
                MessageBox.Show("Maaf, Username/Password Salah!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
