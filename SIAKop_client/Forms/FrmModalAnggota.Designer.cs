namespace SIAKop_client.Forms {
    partial class FrmModalAnggota {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblTampil = new System.Windows.Forms.Label();
            this.LblPage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCari = new System.Windows.Forms.TextBox();
            this.LblRowsCount = new System.Windows.Forms.Label();
            this.DgvAnggota = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.din = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ktp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempat_lahir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgl_lahir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_ibu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.set = new System.Windows.Forms.DataGridViewButtonColumn();
            this.BtnRefresh = new FontAwesome.Sharp.IconButton();
            this.BtnPrev = new FontAwesome.Sharp.IconButton();
            this.BtnNext = new FontAwesome.Sharp.IconButton();
            this.BtnSearch = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAnggota)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTampil
            // 
            this.LblTampil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblTampil.AutoSize = true;
            this.LblTampil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTampil.Location = new System.Drawing.Point(12, 509);
            this.LblTampil.Name = "LblTampil";
            this.LblTampil.Size = new System.Drawing.Size(220, 16);
            this.LblTampil.TabIndex = 34;
            this.LblTampil.Text = "Menampilkan 25 Data Per Halaman";
            // 
            // LblPage
            // 
            this.LblPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblPage.AutoSize = true;
            this.LblPage.Location = new System.Drawing.Point(562, 528);
            this.LblPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPage.Name = "LblPage";
            this.LblPage.Size = new System.Drawing.Size(60, 16);
            this.LblPage.TabIndex = 31;
            this.LblPage.Text = "Page 0/0";
            this.LblPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(685, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Pencarian";
            // 
            // TxtCari
            // 
            this.TxtCari.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCari.Location = new System.Drawing.Point(757, 38);
            this.TxtCari.Name = "TxtCari";
            this.TxtCari.Size = new System.Drawing.Size(344, 22);
            this.TxtCari.TabIndex = 29;
            this.TxtCari.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCari_KeyPress);
            // 
            // LblRowsCount
            // 
            this.LblRowsCount.AutoSize = true;
            this.LblRowsCount.Location = new System.Drawing.Point(12, 46);
            this.LblRowsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRowsCount.Name = "LblRowsCount";
            this.LblRowsCount.Size = new System.Drawing.Size(74, 16);
            this.LblRowsCount.TabIndex = 26;
            this.LblRowsCount.Text = "RowsCount";
            // 
            // DgvAnggota
            // 
            this.DgvAnggota.AllowUserToAddRows = false;
            this.DgvAnggota.AllowUserToDeleteRows = false;
            dataGridViewCellStyle50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvAnggota.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle50;
            this.DgvAnggota.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvAnggota.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle51.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle51.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle51.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle51.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle51.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle51.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAnggota.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle51;
            this.DgvAnggota.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAnggota.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.din,
            this.ktp,
            this.nama,
            this.tempat_lahir,
            this.tgl_lahir,
            this.nama_ibu,
            this.set});
            this.DgvAnggota.Location = new System.Drawing.Point(15, 66);
            this.DgvAnggota.Name = "DgvAnggota";
            this.DgvAnggota.ReadOnly = true;
            dataGridViewCellStyle56.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvAnggota.RowsDefaultCellStyle = dataGridViewCellStyle56;
            this.DgvAnggota.Size = new System.Drawing.Size(1157, 440);
            this.DgvAnggota.TabIndex = 25;
            this.DgvAnggota.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvAnggota_CellContentClick);
            // 
            // no
            // 
            this.no.DataPropertyName = "no";
            this.no.HeaderText = "No.";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            this.no.Width = 80;
            // 
            // din
            // 
            this.din.DataPropertyName = "id_anggota";
            dataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.din.DefaultCellStyle = dataGridViewCellStyle52;
            this.din.HeaderText = "DIN";
            this.din.Name = "din";
            this.din.ReadOnly = true;
            this.din.Width = 140;
            // 
            // ktp
            // 
            this.ktp.DataPropertyName = "ktp";
            dataGridViewCellStyle53.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ktp.DefaultCellStyle = dataGridViewCellStyle53;
            this.ktp.HeaderText = "KTP";
            this.ktp.Name = "ktp";
            this.ktp.ReadOnly = true;
            this.ktp.Width = 140;
            // 
            // nama
            // 
            this.nama.DataPropertyName = "nama";
            this.nama.HeaderText = "Nama Lengkap";
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            this.nama.Width = 240;
            // 
            // tempat_lahir
            // 
            this.tempat_lahir.DataPropertyName = "tempat_lahir";
            dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tempat_lahir.DefaultCellStyle = dataGridViewCellStyle54;
            this.tempat_lahir.HeaderText = "Tempat Lahir";
            this.tempat_lahir.Name = "tempat_lahir";
            this.tempat_lahir.ReadOnly = true;
            this.tempat_lahir.Width = 130;
            // 
            // tgl_lahir
            // 
            this.tgl_lahir.DataPropertyName = "tgl_lahir";
            dataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tgl_lahir.DefaultCellStyle = dataGridViewCellStyle55;
            this.tgl_lahir.HeaderText = "Tanggal Lahir";
            this.tgl_lahir.Name = "tgl_lahir";
            this.tgl_lahir.ReadOnly = true;
            this.tgl_lahir.Width = 107;
            // 
            // nama_ibu
            // 
            this.nama_ibu.DataPropertyName = "nama_ibu";
            this.nama_ibu.HeaderText = "Nama Ibu Kandung";
            this.nama_ibu.Name = "nama_ibu";
            this.nama_ibu.ReadOnly = true;
            this.nama_ibu.Width = 170;
            // 
            // set
            // 
            this.set.HeaderText = "Action";
            this.set.Name = "set";
            this.set.ReadOnly = true;
            this.set.Text = "Gunakan";
            this.set.UseColumnTextForButtonValue = true;
            this.set.Width = 90;
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
            this.BtnRefresh.Location = new System.Drawing.Point(15, 11);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Rotation = 0D;
            this.BtnRefresh.Size = new System.Drawing.Size(100, 32);
            this.BtnRefresh.TabIndex = 35;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
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
            this.BtnPrev.Location = new System.Drawing.Point(475, 521);
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Rotation = 0D;
            this.BtnPrev.Size = new System.Drawing.Size(70, 30);
            this.BtnPrev.TabIndex = 36;
            this.BtnPrev.Text = "Prev";
            this.BtnPrev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPrev.UseVisualStyleBackColor = false;
            this.BtnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
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
            this.BtnNext.Location = new System.Drawing.Point(639, 521);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Rotation = 0D;
            this.BtnNext.Size = new System.Drawing.Size(70, 30);
            this.BtnNext.TabIndex = 37;
            this.BtnNext.Text = "Next";
            this.BtnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnNext.UseVisualStyleBackColor = false;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
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
            this.BtnSearch.Location = new System.Drawing.Point(1107, 34);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Rotation = 0D;
            this.BtnSearch.Size = new System.Drawing.Size(65, 30);
            this.BtnSearch.TabIndex = 38;
            this.BtnSearch.Text = "Cari";
            this.BtnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // FrmModalAnggota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnPrev);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.LblTampil);
            this.Controls.Add(this.LblPage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtCari);
            this.Controls.Add(this.LblRowsCount);
            this.Controls.Add(this.DgvAnggota);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmModalAnggota";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Debitur";
            this.Load += new System.EventHandler(this.FrmModalAnggota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAnggota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTampil;
        private System.Windows.Forms.Label LblPage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCari;
        private System.Windows.Forms.Label LblRowsCount;
        private System.Windows.Forms.DataGridView DgvAnggota;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn din;
        private System.Windows.Forms.DataGridViewTextBoxColumn ktp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempat_lahir;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgl_lahir;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_ibu;
        private System.Windows.Forms.DataGridViewButtonColumn set;
        private FontAwesome.Sharp.IconButton BtnRefresh;
        private FontAwesome.Sharp.IconButton BtnPrev;
        private FontAwesome.Sharp.IconButton BtnNext;
        private FontAwesome.Sharp.IconButton BtnSearch;
    }
}