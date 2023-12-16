namespace SIAKop_client.Forms {
    partial class FrmHistory {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.LblTampil = new System.Windows.Forms.Label();
            this.LblPage = new System.Windows.Forms.Label();
            this.LblRowsCount = new System.Windows.Forms.Label();
            this.DgvHistory = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktifitas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.waktu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnNext = new FontAwesome.Sharp.IconButton();
            this.BtnPrev = new FontAwesome.Sharp.IconButton();
            this.BtnRefresh = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTampil
            // 
            this.LblTampil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblTampil.AutoSize = true;
            this.LblTampil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTampil.Location = new System.Drawing.Point(13, 507);
            this.LblTampil.Name = "LblTampil";
            this.LblTampil.Size = new System.Drawing.Size(220, 16);
            this.LblTampil.TabIndex = 36;
            this.LblTampil.Text = "Menampilkan 25 Data Per Halaman";
            // 
            // LblPage
            // 
            this.LblPage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LblPage.AutoSize = true;
            this.LblPage.Location = new System.Drawing.Point(583, 522);
            this.LblPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblPage.Name = "LblPage";
            this.LblPage.Size = new System.Drawing.Size(60, 16);
            this.LblPage.TabIndex = 33;
            this.LblPage.Text = "Page 0/0";
            this.LblPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblRowsCount
            // 
            this.LblRowsCount.AutoSize = true;
            this.LblRowsCount.Location = new System.Drawing.Point(9, 54);
            this.LblRowsCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblRowsCount.Name = "LblRowsCount";
            this.LblRowsCount.Size = new System.Drawing.Size(74, 16);
            this.LblRowsCount.TabIndex = 31;
            this.LblRowsCount.Text = "RowsCount";
            // 
            // DgvHistory
            // 
            this.DgvHistory.AllowUserToAddRows = false;
            this.DgvHistory.AllowUserToDeleteRows = false;
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DgvHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.DgvHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvHistory.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.DgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nama,
            this.aktifitas,
            this.waktu});
            this.DgvHistory.Location = new System.Drawing.Point(12, 73);
            this.DgvHistory.Name = "DgvHistory";
            this.DgvHistory.ReadOnly = true;
            this.DgvHistory.Size = new System.Drawing.Size(1244, 431);
            this.DgvHistory.TabIndex = 37;
            // 
            // id
            // 
            this.id.DataPropertyName = "id_user";
            this.id.HeaderText = "ID User";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
            // nama
            // 
            this.nama.DataPropertyName = "name";
            this.nama.HeaderText = "Nama";
            this.nama.Name = "nama";
            this.nama.ReadOnly = true;
            this.nama.Width = 280;
            // 
            // aktifitas
            // 
            this.aktifitas.DataPropertyName = "activity";
            this.aktifitas.HeaderText = "Aktifitas";
            this.aktifitas.Name = "aktifitas";
            this.aktifitas.ReadOnly = true;
            this.aktifitas.Width = 650;
            // 
            // waktu
            // 
            this.waktu.DataPropertyName = "created_at";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.Format = "F";
            dataGridViewCellStyle27.NullValue = null;
            this.waktu.DefaultCellStyle = dataGridViewCellStyle27;
            this.waktu.HeaderText = "Waktu";
            this.waktu.Name = "waktu";
            this.waktu.ReadOnly = true;
            this.waktu.Width = 225;
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
            this.BtnNext.Location = new System.Drawing.Point(660, 515);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Rotation = 0D;
            this.BtnNext.Size = new System.Drawing.Size(70, 30);
            this.BtnNext.TabIndex = 38;
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
            this.BtnPrev.Location = new System.Drawing.Point(496, 515);
            this.BtnPrev.Name = "BtnPrev";
            this.BtnPrev.Rotation = 0D;
            this.BtnPrev.Size = new System.Drawing.Size(70, 30);
            this.BtnPrev.TabIndex = 39;
            this.BtnPrev.Text = "Prev";
            this.BtnPrev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPrev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnPrev.UseVisualStyleBackColor = false;
            this.BtnPrev.Click += new System.EventHandler(this.BtnPrev_Click);
            // 
            // BtnRefresh
            // 
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
            this.BtnRefresh.TabIndex = 40;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnRefresh.UseVisualStyleBackColor = false;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // FrmHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1268, 554);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnPrev);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.DgvHistory);
            this.Controls.Add(this.LblTampil);
            this.Controls.Add(this.LblPage);
            this.Controls.Add(this.LblRowsCount);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmHistory";
            this.Load += new System.EventHandler(this.FrmHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTampil;
        private System.Windows.Forms.Label LblPage;
        private System.Windows.Forms.Label LblRowsCount;
        private System.Windows.Forms.DataGridView DgvHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn aktifitas;
        private System.Windows.Forms.DataGridViewTextBoxColumn waktu;
        private FontAwesome.Sharp.IconButton BtnNext;
        private FontAwesome.Sharp.IconButton BtnPrev;
        private FontAwesome.Sharp.IconButton BtnRefresh;
    }
}