namespace SIAKop_client.Forms {
    partial class FrmConfirmKolek {
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
            this.TxtPass = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.BtnConfirm = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // TxtPass
            // 
            this.TxtPass.Location = new System.Drawing.Point(29, 41);
            this.TxtPass.Name = "TxtPass";
            this.TxtPass.PasswordChar = '*';
            this.TxtPass.Size = new System.Drawing.Size(286, 22);
            this.TxtPass.TabIndex = 4;
            this.TxtPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPass_KeyPress);
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(26, 22);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(170, 16);
            this.LblPassword.TabIndex = 3;
            this.LblPassword.Text = "Masukkan Password Anda :";
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirm.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.BtnConfirm.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirm.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnConfirm.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.BtnConfirm.IconColor = System.Drawing.SystemColors.Window;
            this.BtnConfirm.IconSize = 16;
            this.BtnConfirm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirm.Location = new System.Drawing.Point(322, 36);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Rotation = 0D;
            this.BtnConfirm.Size = new System.Drawing.Size(100, 32);
            this.BtnConfirm.TabIndex = 5;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfirm.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // FrmConfirmKolek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(434, 87);
            this.Controls.Add(this.BtnConfirm);
            this.Controls.Add(this.TxtPass);
            this.Controls.Add(this.LblPassword);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmConfirmKolek";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Konfirmasi Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtPass;
        private System.Windows.Forms.Label LblPassword;
        private FontAwesome.Sharp.IconButton BtnConfirm;
    }
}