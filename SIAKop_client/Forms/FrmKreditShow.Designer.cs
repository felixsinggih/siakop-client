namespace SIAKop_client.Forms {
    partial class FrmKreditShow {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle89 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle90 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle99 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle91 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle92 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle93 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle94 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle95 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle96 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle97 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle98 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvKredit = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_kredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ktp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgl_lahir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plafon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.baki_debet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.akad_awal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jatuh_tempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewButtonColumn();
            this.edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCari = new System.Windows.Forms.TextBox();
            this.LblRowsCount = new System.Windows.Forms.Label();
            this.LblTampil = new System.Windows.Forms.Label();
            this.LblPage = new System.Windows.Forms.Label();
            this.BtnSearch = new FontAwesome.Sharp.IconButton();
            this.BtnNext = new FontAwesome.Sharp.IconButton();
            this.BtnPrev = new FontAwesome.Sharp.IconButton();
            this.BtnRefresh = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvKredit)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvKredit
            // 
            this.DgvKredit.AllowUserToAddRows = false;
            this.DgvKredit.AllowUserToDeleteRows = false;
            dataGridViewCellStyle89.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvKredit.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle89;
            this.DgvKredit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvKredit.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle90.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle90.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle90.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle90.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle90.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle90.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle90.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvKredit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle90;
            this.DgvKredit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvKredit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.id_kredit,
            this.ktp,
            this.nama,
            this.tgl_lahir,
            this.bunga,
            this.plafon,
            this.baki_debet,
            this.akad_awal,
            this.jatuh_tempo,
            this.detail,
            this.edit});
            this.DgvKredit.Location = new System.Drawing.Point(12, 68);
            this.DgvKredit.Name = "DgvKredit";
            this.DgvKredit.ReadOnly = true;
            dataGridViewCellStyle99.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvKredit.RowsDefaultCellStyle = dataGridViewCellStyle99;
            this.DgvKredit.Size = new System.Drawing.Size(1161, 434);
            this.DgvKredit.TabIndex = 0;
            this.DgvKredit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvKredit_CellContentClick);
            // 
            // no
            // 
            this.no.DataPropertyName = "no";
            this.no.HeaderText = "No.";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Width = 80;
            // 
            // id_kredit
            // 
            this.id_kredit.DataPropertyName = "id_kredit";
            dataGridViewCellStyle91.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id_kredit.DefaultCellStyle = dataGridViewCellStyle91;
            this.id_kredit.HeaderText = "No. Kredit";
            this.id_kredit.Name = "id_kredit";
            this.id_kredit.ReadOnly = true;
            this.id_kredit.Width = 150;
            // 
            // ktp
            // 
            this.ktp.DataPropertyName = "ktp";
            dataGridViewCellStyle92.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ktp.DefaultCellStyle = dataGridViewCellStyle92;
            this.ktp.HeaderText = "KTP";
            this.ktp.Name = "ktp";
            this.ktp.ReadOnly = true;
            this.ktp.Width = 140;
            // 
            // nama
            // 
            this.nama.DataPropertyName = "nama";
            this.nama.HeaderText = "Nama";
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            this.nama.Width = 178;
            // 
            // tgl_lahir
            // 
            this.tgl_lahir.DataPropertyName = "tgl_lahir";
            dataGridViewCellStyle93.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tgl_lahir.DefaultCellStyle = dataGridViewCellStyle93;
            this.tgl_lahir.HeaderText = "Tanggal Lahir";
            this.tgl_lahir.Name = "tgl_lahir";
            this.tgl_lahir.ReadOnly = true;
            this.tgl_lahir.Width = 83;
            // 
            // bunga
            // 
            this.bunga.DataPropertyName = "bunga";
            dataGridViewCellStyle94.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.bunga.DefaultCellStyle = dataGridViewCellStyle94;
            this.bunga.HeaderText = "Bunga";
            this.bunga.Name = "bunga";
            this.bunga.ReadOnly = true;
            this.bunga.Width = 60;
            // 
            // plafon
            // 
            this.plafon.DataPropertyName = "plafon";
            dataGridViewCellStyle95.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle95.NullValue = null;
            this.plafon.DefaultCellStyle = dataGridViewCellStyle95;
            this.plafon.HeaderText = "Plafon";
            this.plafon.Name = "plafon";
            this.plafon.ReadOnly = true;
            this.plafon.Width = 150;
            // 
            // baki_debet
            // 
            this.baki_debet.DataPropertyName = "baki_debet";
            dataGridViewCellStyle96.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle96.NullValue = null;
            this.baki_debet.DefaultCellStyle = dataGridViewCellStyle96;
            this.baki_debet.HeaderText = "Baki Debet";
            this.baki_debet.Name = "baki_debet";
            this.baki_debet.ReadOnly = true;
            this.baki_debet.Width = 150;
            // 
            // akad_awal
            // 
            this.akad_awal.DataPropertyName = "akad_awal";
            dataGridViewCellStyle97.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.akad_awal.DefaultCellStyle = dataGridViewCellStyle97;
            this.akad_awal.HeaderText = "Akad Awal";
            this.akad_awal.Name = "akad_awal";
            this.akad_awal.ReadOnly = true;
            this.akad_awal.Width = 83;
            // 
            // jatuh_tempo
            // 
            this.jatuh_tempo.DataPropertyName = "jatuh_tempo";
            dataGridViewCellStyle98.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.jatuh_tempo.DefaultCellStyle = dataGridViewCellStyle98;
            this.jatuh_tempo.HeaderText = "Jatuh Tempo";
            this.jatuh_tempo.Name = "jatuh_tempo";
            this.jatuh_tempo.ReadOnly = true;
            this.jatuh_tempo.Width = 83;
            // 
            // detail
            // 
            this.detail.HeaderText = "Detail";
            this.detail.Name = "detail";
            this.detail.ReadOnly = true;
            this.detail.Text = "Detail";
            this.detail.ToolTipText = "Lihat Detail Kredit";
            this.detail.UseColumnTextForButtonValue = true;
            this.detail.Width = 60;
            // 
            // edit
            // 
            this.edit.HeaderText = "Edit";
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Text = "Edit";
            this.edit.ToolTipText = "Edit Data Kredit";
            this.edit.UseColumnTextForButtonValue = true;
            this.edit.Width = 60;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(697, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Pencarian";
            // 
            // TxtCari
            // 
            this.TxtCari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCari.Location = new System.Drawing.Point(758, 39);
            this.TxtCari.Name = "TxtCari";
            this.TxtCari.Size = new System.Drawing.Size(344, 20);
            this.TxtCari.TabIndex = 24;
            this.TxtCari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCari_KeyPress);
            // 
            // LblRowsCount
            // 
            this.LblRowsCount.AutoSize = true;
            this.LblRowsCount.Location = new System.Drawing.Point(9, 52);
            this.LblRowsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRowsCount.Name = "LblRowsCount";
            this.LblRowsCount.Size = new System.Drawing.Size(62, 13);
            this.LblRowsCount.TabIndex = 21;
            this.LblRowsCount.Text = "RowsCount";
            // 
            // LblTampil
            // 
            this.LblTampil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblTampil.AutoSize = true;
            this.LblTampil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTampil.Location = new System.Drawing.Point(13, 505);
            this.LblTampil.Name = "LblTampil";
            this.LblTampil.Size = new System.Drawing.Size(220, 16);
            this.LblTampil.TabIndex = 29;
            this.LblTampil.Text = "Menampilkan 25 Data Per Halaman";
            // 
            // LblPage
            // 
            this.LblPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblPage.AutoSize = true;
            this.LblPage.Location = new System.Drawing.Point(540, 519);
            this.LblPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPage.Name = "LblPage";
            this.LblPage.Size = new System.Drawing.Size(52, 13);
            this.LblPage.TabIndex = 26;
            this.LblPage.Text = "Page 0/0";
            this.LblPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(128)))));
            this.BtnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSearch.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnSearch.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.BtnSearch.IconColor = System.Drawing.SystemColors.Window;
            this.BtnSearch.IconSize = 16;
            this.BtnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSearch.Location = new System.Drawing.Point(1108, 33);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Rotation = 0D;
            this.BtnSearch.Size = new System.Drawing.Size(65, 30);
            this.BtnSearch.TabIndex = 39;
            this.BtnSearch.Text = "Cari";
            this.BtnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNext.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnNext.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNext.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnNext.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.BtnNext.IconColor = System.Drawing.SystemColors.Window;
            this.BtnNext.IconSize = 16;
            this.BtnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNext.Location = new System.Drawing.Point(609, 510);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Rotation = 0D;
            this.BtnNext.Size = new System.Drawing.Size(70, 30);
            this.BtnNext.TabIndex = 40;
            this.BtnNext.Text = "Next";
            this.BtnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnPrev
            // 
            this.BtnPrev.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.BtnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPrev.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnPrev.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrev.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnPrev.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            this.BtnPrev.IconColor = System.Drawing.SystemColors.Window;
            this.BtnPrev.IconSize = 16;
            this.BtnPrev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrev.Location = new System.Drawing.Point(453, 510);
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Rotation = 0D;
            this.BtnPrev.Size = new System.Drawing.Size(70, 30);
            this.BtnPrev.TabIndex = 41;
            this.BtnPrev.Text = "Prev";
            this.BtnPrev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPrev.UseVisualStyleBackColor = false;
            this.BtnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(115)))), ((int)(((byte)(235)))));
            this.BtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRefresh.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnRefresh.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRefresh.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnRefresh.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.BtnRefresh.IconColor = System.Drawing.SystemColors.Window;
            this.BtnRefresh.IconSize = 16;
            this.BtnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRefresh.Location = new System.Drawing.Point(12, 12);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Rotation = 0D;
            this.BtnRefresh.Size = new System.Drawing.Size(100, 32);
            this.BtnRefresh.TabIndex = 42;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // FrmKreditShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1185, 546);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnPrev);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.LblTampil);
            this.Controls.Add(this.LblPage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtCari);
            this.Controls.Add(this.LblRowsCount);
            this.Controls.Add(this.DgvKredit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKreditShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKreditShow";
            this.Load += new System.EventHandler(this.FrmKreditShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvKredit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvKredit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCari;
        private System.Windows.Forms.Label LblRowsCount;
        private System.Windows.Forms.Label LblTampil;
        private System.Windows.Forms.Label LblPage;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_kredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ktp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgl_lahir;
        private System.Windows.Forms.DataGridViewTextBoxColumn bunga;
        private System.Windows.Forms.DataGridViewTextBoxColumn plafon;
        private System.Windows.Forms.DataGridViewTextBoxColumn baki_debet;
        private System.Windows.Forms.DataGridViewTextBoxColumn akad_awal;
        private System.Windows.Forms.DataGridViewTextBoxColumn jatuh_tempo;
        private System.Windows.Forms.DataGridViewButtonColumn detail;
        private System.Windows.Forms.DataGridViewButtonColumn edit;
        private FontAwesome.Sharp.IconButton BtnSearch;
        private FontAwesome.Sharp.IconButton BtnNext;
        private FontAwesome.Sharp.IconButton BtnPrev;
        private FontAwesome.Sharp.IconButton BtnRefresh;
    }
}