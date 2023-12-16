namespace SIAKop_client.Forms {
    partial class FrmKreditKolek {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblDin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblKtp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LblNama = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblTempatLahir = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.LblAlias = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TxtPerpanjangan = new System.Windows.Forms.TextBox();
            this.TxtJatuh = new System.Windows.Forms.TextBox();
            this.TxtAkad = new System.Windows.Forms.TextBox();
            this.TxtJenis = new System.Windows.Forms.TextBox();
            this.TxtSektor = new System.Windows.Forms.TextBox();
            this.TxtFrekBunga = new System.Windows.Forms.TextBox();
            this.TxtFrekPokok = new System.Windows.Forms.TextBox();
            this.TxtPokok = new System.Windows.Forms.TextBox();
            this.TxtDebet = new System.Windows.Forms.TextBox();
            this.TxtPlafon = new System.Windows.Forms.TextBox();
            this.DtpSebab = new System.Windows.Forms.DateTimePicker();
            this.DtpKondisi = new System.Windows.Forms.DateTimePicker();
            this.CmbSebab = new System.Windows.Forms.ComboBox();
            this.CmbKondisi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBunga = new System.Windows.Forms.TextBox();
            this.TxtValuta = new System.Windows.Forms.TextBox();
            this.TxtSifat = new System.Windows.Forms.TextBox();
            this.TxtIdKredit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.DtpKolek = new System.Windows.Forms.DateTimePicker();
            this.label62 = new System.Windows.Forms.Label();
            this.CmbKolek = new System.Windows.Forms.ComboBox();
            this.label60 = new System.Windows.Forms.Label();
            this.TxtHariKolek = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.BgWorker = new System.ComponentModel.BackgroundWorker();
            this.BtnSave = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Window;
            this.groupBox1.Controls.Add(this.LblDin);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.LblKtp);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.LblNama);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.LblTempatLahir);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.LblAlias);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 176);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informasi Debitur";
            // 
            // LblDin
            // 
            this.LblDin.AutoSize = true;
            this.LblDin.Location = new System.Drawing.Point(164, 28);
            this.LblDin.Name = "LblDin";
            this.LblDin.Size = new System.Drawing.Size(42, 16);
            this.LblDin.TabIndex = 17;
            this.LblDin.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "DIN ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "KTP";
            // 
            // LblKtp
            // 
            this.LblKtp.AutoSize = true;
            this.LblKtp.Location = new System.Drawing.Point(164, 53);
            this.LblKtp.Name = "LblKtp";
            this.LblKtp.Size = new System.Drawing.Size(42, 16);
            this.LblKtp.TabIndex = 19;
            this.LblKtp.Text = "label3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Nama";
            // 
            // LblNama
            // 
            this.LblNama.AutoSize = true;
            this.LblNama.Location = new System.Drawing.Point(164, 78);
            this.LblNama.Name = "LblNama";
            this.LblNama.Size = new System.Drawing.Size(42, 16);
            this.LblNama.TabIndex = 21;
            this.LblNama.Text = "label5";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 16);
            this.label8.TabIndex = 22;
            this.label8.Text = "Tempat, Tanggal Lahir";
            // 
            // LblTempatLahir
            // 
            this.LblTempatLahir.AutoSize = true;
            this.LblTempatLahir.Location = new System.Drawing.Point(164, 129);
            this.LblTempatLahir.Name = "LblTempatLahir";
            this.LblTempatLahir.Size = new System.Drawing.Size(42, 16);
            this.LblTempatLahir.TabIndex = 23;
            this.LblTempatLahir.Text = "label7";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(25, 104);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 16);
            this.label16.TabIndex = 24;
            this.label16.Text = "Alias";
            // 
            // LblAlias
            // 
            this.LblAlias.AutoSize = true;
            this.LblAlias.Location = new System.Drawing.Point(164, 104);
            this.LblAlias.Name = "LblAlias";
            this.LblAlias.Size = new System.Drawing.Size(49, 16);
            this.LblAlias.TabIndex = 25;
            this.LblAlias.Text = "label15";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnSave);
            this.groupBox2.Controls.Add(this.TxtPerpanjangan);
            this.groupBox2.Controls.Add(this.TxtJatuh);
            this.groupBox2.Controls.Add(this.TxtAkad);
            this.groupBox2.Controls.Add(this.TxtJenis);
            this.groupBox2.Controls.Add(this.TxtSektor);
            this.groupBox2.Controls.Add(this.TxtFrekBunga);
            this.groupBox2.Controls.Add(this.TxtFrekPokok);
            this.groupBox2.Controls.Add(this.TxtPokok);
            this.groupBox2.Controls.Add(this.TxtDebet);
            this.groupBox2.Controls.Add(this.TxtPlafon);
            this.groupBox2.Controls.Add(this.DtpSebab);
            this.groupBox2.Controls.Add(this.DtpKondisi);
            this.groupBox2.Controls.Add(this.CmbSebab);
            this.groupBox2.Controls.Add(this.CmbKondisi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label33);
            this.groupBox2.Controls.Add(this.label32);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TxtBunga);
            this.groupBox2.Controls.Add(this.TxtValuta);
            this.groupBox2.Controls.Add(this.TxtSifat);
            this.groupBox2.Controls.Add(this.TxtIdKredit);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label46);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label24);
            this.groupBox2.Controls.Add(this.label29);
            this.groupBox2.Controls.Add(this.label31);
            this.groupBox2.Controls.Add(this.label34);
            this.groupBox2.Controls.Add(this.label35);
            this.groupBox2.Location = new System.Drawing.Point(12, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1240, 329);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informasi Kredit";
            // 
            // TxtPerpanjangan
            // 
            this.TxtPerpanjangan.Location = new System.Drawing.Point(768, 249);
            this.TxtPerpanjangan.Name = "TxtPerpanjangan";
            this.TxtPerpanjangan.Size = new System.Drawing.Size(453, 22);
            this.TxtPerpanjangan.TabIndex = 100;
            // 
            // TxtJatuh
            // 
            this.TxtJatuh.Location = new System.Drawing.Point(768, 221);
            this.TxtJatuh.Name = "TxtJatuh";
            this.TxtJatuh.Size = new System.Drawing.Size(453, 22);
            this.TxtJatuh.TabIndex = 99;
            // 
            // TxtAkad
            // 
            this.TxtAkad.Location = new System.Drawing.Point(768, 193);
            this.TxtAkad.Name = "TxtAkad";
            this.TxtAkad.Size = new System.Drawing.Size(453, 22);
            this.TxtAkad.TabIndex = 98;
            // 
            // TxtJenis
            // 
            this.TxtJenis.Location = new System.Drawing.Point(768, 49);
            this.TxtJenis.Name = "TxtJenis";
            this.TxtJenis.Size = new System.Drawing.Size(453, 22);
            this.TxtJenis.TabIndex = 97;
            // 
            // TxtSektor
            // 
            this.TxtSektor.Location = new System.Drawing.Point(768, 21);
            this.TxtSektor.Name = "TxtSektor";
            this.TxtSektor.Size = new System.Drawing.Size(453, 22);
            this.TxtSektor.TabIndex = 96;
            // 
            // TxtFrekBunga
            // 
            this.TxtFrekBunga.Location = new System.Drawing.Point(215, 246);
            this.TxtFrekBunga.Name = "TxtFrekBunga";
            this.TxtFrekBunga.Size = new System.Drawing.Size(383, 22);
            this.TxtFrekBunga.TabIndex = 95;
            // 
            // TxtFrekPokok
            // 
            this.TxtFrekPokok.Location = new System.Drawing.Point(215, 218);
            this.TxtFrekPokok.Name = "TxtFrekPokok";
            this.TxtFrekPokok.Size = new System.Drawing.Size(383, 22);
            this.TxtFrekPokok.TabIndex = 94;
            // 
            // TxtPokok
            // 
            this.TxtPokok.Location = new System.Drawing.Point(215, 190);
            this.TxtPokok.Name = "TxtPokok";
            this.TxtPokok.Size = new System.Drawing.Size(383, 22);
            this.TxtPokok.TabIndex = 93;
            // 
            // TxtDebet
            // 
            this.TxtDebet.Location = new System.Drawing.Point(215, 162);
            this.TxtDebet.Name = "TxtDebet";
            this.TxtDebet.Size = new System.Drawing.Size(383, 22);
            this.TxtDebet.TabIndex = 92;
            // 
            // TxtPlafon
            // 
            this.TxtPlafon.Location = new System.Drawing.Point(215, 134);
            this.TxtPlafon.Name = "TxtPlafon";
            this.TxtPlafon.Size = new System.Drawing.Size(383, 22);
            this.TxtPlafon.TabIndex = 91;
            // 
            // DtpSebab
            // 
            this.DtpSebab.CustomFormat = " ";
            this.DtpSebab.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpSebab.Location = new System.Drawing.Point(768, 165);
            this.DtpSebab.Name = "DtpSebab";
            this.DtpSebab.Size = new System.Drawing.Size(453, 22);
            this.DtpSebab.TabIndex = 86;
            this.DtpSebab.ValueChanged += new System.EventHandler(this.DtpSebab_ValueChanged);
            this.DtpSebab.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DtpSebab_KeyDown);
            // 
            // DtpKondisi
            // 
            this.DtpKondisi.CustomFormat = " ";
            this.DtpKondisi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpKondisi.Location = new System.Drawing.Point(768, 107);
            this.DtpKondisi.Name = "DtpKondisi";
            this.DtpKondisi.Size = new System.Drawing.Size(453, 22);
            this.DtpKondisi.TabIndex = 84;
            this.DtpKondisi.ValueChanged += new System.EventHandler(this.DtpKondisi_ValueChanged);
            this.DtpKondisi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DtpKondisi_KeyDown);
            // 
            // CmbSebab
            // 
            this.CmbSebab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbSebab.FormattingEnabled = true;
            this.CmbSebab.Location = new System.Drawing.Point(768, 135);
            this.CmbSebab.Name = "CmbSebab";
            this.CmbSebab.Size = new System.Drawing.Size(453, 24);
            this.CmbSebab.TabIndex = 85;
            // 
            // CmbKondisi
            // 
            this.CmbKondisi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbKondisi.FormattingEnabled = true;
            this.CmbKondisi.Location = new System.Drawing.Point(768, 77);
            this.CmbKondisi.Name = "CmbKondisi";
            this.CmbKondisi.Size = new System.Drawing.Size(453, 24);
            this.CmbKondisi.TabIndex = 83;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(636, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 90;
            this.label3.Text = "Tanggal Macet";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(636, 138);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(85, 16);
            this.label33.TabIndex = 89;
            this.label33.Text = "Sebab Macet";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(636, 112);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(99, 16);
            this.label32.TabIndex = 88;
            this.label32.Text = "Tanggal Kondisi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(636, 80);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 16);
            this.label11.TabIndex = 87;
            this.label11.Text = "Kondisi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 16);
            this.label2.TabIndex = 82;
            this.label2.Text = "Frekuensi Tunggakan Bunga";
            // 
            // TxtBunga
            // 
            this.TxtBunga.Location = new System.Drawing.Point(215, 106);
            this.TxtBunga.Name = "TxtBunga";
            this.TxtBunga.Size = new System.Drawing.Size(383, 22);
            this.TxtBunga.TabIndex = 81;
            // 
            // TxtValuta
            // 
            this.TxtValuta.Location = new System.Drawing.Point(215, 78);
            this.TxtValuta.Name = "TxtValuta";
            this.TxtValuta.Size = new System.Drawing.Size(383, 22);
            this.TxtValuta.TabIndex = 80;
            // 
            // TxtSifat
            // 
            this.TxtSifat.Location = new System.Drawing.Point(215, 50);
            this.TxtSifat.Name = "TxtSifat";
            this.TxtSifat.Size = new System.Drawing.Size(383, 22);
            this.TxtSifat.TabIndex = 79;
            // 
            // TxtIdKredit
            // 
            this.TxtIdKredit.Location = new System.Drawing.Point(215, 22);
            this.TxtIdKredit.Name = "TxtIdKredit";
            this.TxtIdKredit.Size = new System.Drawing.Size(383, 22);
            this.TxtIdKredit.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(636, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 76;
            this.label5.Text = "Baru/Perpanjangan";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(636, 224);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(81, 16);
            this.label46.TabIndex = 74;
            this.label46.Text = "Jatuh Tempo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(636, 196);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 16);
            this.label15.TabIndex = 72;
            this.label15.Text = "Akad Awal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 44;
            this.label7.Text = "No. Kredit";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 16);
            this.label9.TabIndex = 62;
            this.label9.Text = "Bunga";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 16);
            this.label10.TabIndex = 46;
            this.label10.Text = "Sifat";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 81);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 16);
            this.label17.TabIndex = 48;
            this.label17.Text = "Valuta";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(636, 52);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(76, 16);
            this.label23.TabIndex = 60;
            this.label23.Text = "Jenis Kredit";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(25, 137);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 16);
            this.label24.TabIndex = 50;
            this.label24.Text = "Plafon";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(636, 24);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(101, 16);
            this.label29.TabIndex = 58;
            this.label29.Text = "Sektor Ekonomi";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(25, 165);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(72, 16);
            this.label31.TabIndex = 52;
            this.label31.Text = "Baki Debet";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(25, 221);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(173, 16);
            this.label34.TabIndex = 56;
            this.label34.Text = "Frekuensi Tunggakan Pokok";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(25, 193);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(112, 16);
            this.label35.TabIndex = 54;
            this.label35.Text = "Tunggakan Pokok";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DtpKolek);
            this.groupBox3.Controls.Add(this.label62);
            this.groupBox3.Controls.Add(this.CmbKolek);
            this.groupBox3.Controls.Add(this.label60);
            this.groupBox3.Controls.Add(this.TxtHariKolek);
            this.groupBox3.Controls.Add(this.label61);
            this.groupBox3.Location = new System.Drawing.Point(625, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(627, 171);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Input Kolektibilitas";
            // 
            // DtpKolek
            // 
            this.DtpKolek.CustomFormat = " ";
            this.DtpKolek.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpKolek.Location = new System.Drawing.Point(179, 93);
            this.DtpKolek.Name = "DtpKolek";
            this.DtpKolek.Size = new System.Drawing.Size(429, 22);
            this.DtpKolek.TabIndex = 82;
            this.DtpKolek.ValueChanged += new System.EventHandler(this.DtpKolek_ValueChanged);
            this.DtpKolek.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DtpKolek_KeyDown);
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(25, 99);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(56, 16);
            this.label62.TabIndex = 83;
            this.label62.Text = "Tanggal ";
            // 
            // CmbKolek
            // 
            this.CmbKolek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbKolek.FormattingEnabled = true;
            this.CmbKolek.Location = new System.Drawing.Point(179, 35);
            this.CmbKolek.Name = "CmbKolek";
            this.CmbKolek.Size = new System.Drawing.Size(429, 24);
            this.CmbKolek.TabIndex = 81;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(25, 38);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(128, 16);
            this.label60.TabIndex = 78;
            this.label60.Text = "Tingkat Kolektibilitas";
            // 
            // TxtHariKolek
            // 
            this.TxtHariKolek.Location = new System.Drawing.Point(179, 65);
            this.TxtHariKolek.Name = "TxtHariKolek";
            this.TxtHariKolek.Size = new System.Drawing.Size(429, 22);
            this.TxtHariKolek.TabIndex = 79;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(25, 71);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(98, 16);
            this.label61.TabIndex = 80;
            this.label61.Text = "Tunggakan Hari";
            // 
            // BgWorker
            // 
            this.BgWorker.WorkerReportsProgress = true;
            this.BgWorker.WorkerSupportsCancellation = true;
            this.BgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgWorker_DoWork);
            this.BgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgWorker_RunWorkerCompleted);
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnSave.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnSave.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnSave.IconColor = System.Drawing.SystemColors.Window;
            this.BtnSave.IconSize = 16;
            this.BtnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.Location = new System.Drawing.Point(1121, 283);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Rotation = 0D;
            this.BtnSave.Size = new System.Drawing.Size(100, 32);
            this.BtnSave.TabIndex = 101;
            this.BtnSave.Text = "Simpan";
            this.BtnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmKreditKolek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1264, 533);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmKreditKolek";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Input Kolektabilitas";
            this.Load += new System.EventHandler(this.FrmKreditKolek_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblDin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblKtp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblNama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblTempatLahir;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label LblAlias;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBunga;
        private System.Windows.Forms.TextBox TxtValuta;
        private System.Windows.Forms.TextBox TxtSifat;
        private System.Windows.Forms.TextBox TxtIdKredit;
        private System.Windows.Forms.DateTimePicker DtpSebab;
        private System.Windows.Forms.DateTimePicker DtpKondisi;
        private System.Windows.Forms.ComboBox CmbSebab;
        private System.Windows.Forms.ComboBox CmbKondisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtFrekPokok;
        private System.Windows.Forms.TextBox TxtPokok;
        private System.Windows.Forms.TextBox TxtDebet;
        private System.Windows.Forms.TextBox TxtPlafon;
        private System.Windows.Forms.TextBox TxtPerpanjangan;
        private System.Windows.Forms.TextBox TxtJatuh;
        private System.Windows.Forms.TextBox TxtAkad;
        private System.Windows.Forms.TextBox TxtJenis;
        private System.Windows.Forms.TextBox TxtSektor;
        private System.Windows.Forms.TextBox TxtFrekBunga;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker DtpKolek;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.ComboBox CmbKolek;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.TextBox TxtHariKolek;
        private System.Windows.Forms.Label label61;
        private System.ComponentModel.BackgroundWorker BgWorker;
        private FontAwesome.Sharp.IconButton BtnSave;
    }
}