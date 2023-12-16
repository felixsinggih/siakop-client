namespace SIAKop_client.Forms {
    partial class FrmModalKolektabilitas {
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
            this.DtpKolek = new System.Windows.Forms.DateTimePicker();
            this.label62 = new System.Windows.Forms.Label();
            this.CmbKolek = new System.Windows.Forms.ComboBox();
            this.label60 = new System.Windows.Forms.Label();
            this.TxtHariKolek = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblNo = new System.Windows.Forms.Label();
            this.BtnEdit = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // DtpKolek
            // 
            this.DtpKolek.CustomFormat = " ";
            this.DtpKolek.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpKolek.Location = new System.Drawing.Point(178, 114);
            this.DtpKolek.Name = "DtpKolek";
            this.DtpKolek.Size = new System.Drawing.Size(304, 22);
            this.DtpKolek.TabIndex = 85;
            this.DtpKolek.ValueChanged += new System.EventHandler(this.DtpKolek_ValueChanged);
            this.DtpKolek.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DtpKolek_KeyDown);
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Location = new System.Drawing.Point(28, 119);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(56, 16);
            this.label62.TabIndex = 86;
            this.label62.Text = "Tanggal ";
            // 
            // CmbKolek
            // 
            this.CmbKolek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbKolek.FormattingEnabled = true;
            this.CmbKolek.Location = new System.Drawing.Point(178, 56);
            this.CmbKolek.Name = "CmbKolek";
            this.CmbKolek.Size = new System.Drawing.Size(304, 24);
            this.CmbKolek.TabIndex = 84;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(28, 59);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(128, 16);
            this.label60.TabIndex = 81;
            this.label60.Text = "Tingkat Kolektibilitas";
            // 
            // TxtHariKolek
            // 
            this.TxtHariKolek.Location = new System.Drawing.Point(178, 86);
            this.TxtHariKolek.Name = "TxtHariKolek";
            this.TxtHariKolek.Size = new System.Drawing.Size(304, 22);
            this.TxtHariKolek.TabIndex = 82;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Location = new System.Drawing.Point(28, 89);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(98, 16);
            this.label61.TabIndex = 83;
            this.label61.Text = "Tunggakan Hari";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 16);
            this.label1.TabIndex = 88;
            this.label1.Text = "No";
            // 
            // LblNo
            // 
            this.LblNo.AutoSize = true;
            this.LblNo.Location = new System.Drawing.Point(175, 23);
            this.LblNo.Name = "LblNo";
            this.LblNo.Size = new System.Drawing.Size(15, 16);
            this.LblNo.TabIndex = 89;
            this.LblNo.Text = "0";
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnEdit.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEdit.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnEdit.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            this.BtnEdit.IconColor = System.Drawing.SystemColors.Window;
            this.BtnEdit.IconSize = 16;
            this.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEdit.Location = new System.Drawing.Point(417, 142);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Rotation = 0D;
            this.BtnEdit.Size = new System.Drawing.Size(65, 32);
            this.BtnEdit.TabIndex = 103;
            this.BtnEdit.Text = "Edit";
            this.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // FrmModalKolektabilitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(512, 195);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.LblNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DtpKolek);
            this.Controls.Add(this.label62);
            this.Controls.Add(this.CmbKolek);
            this.Controls.Add(this.label60);
            this.Controls.Add(this.TxtHariKolek);
            this.Controls.Add(this.label61);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmModalKolektabilitas";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Kolektibilitas";
            this.Load += new System.EventHandler(this.FrmModalKolektabilitas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DateTimePicker DtpKolek;
        private System.Windows.Forms.Label label62;
        public System.Windows.Forms.ComboBox CmbKolek;
        private System.Windows.Forms.Label label60;
        public System.Windows.Forms.TextBox TxtHariKolek;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblNo;
        private FontAwesome.Sharp.IconButton BtnEdit;
    }
}