namespace SIAKop_client.Forms {
    partial class FrmWait {
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
            this.PgBar = new System.Windows.Forms.ProgressBar();
            this.LblProg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PgBar
            // 
            this.PgBar.Location = new System.Drawing.Point(12, 33);
            this.PgBar.Name = "PgBar";
            this.PgBar.Size = new System.Drawing.Size(317, 23);
            this.PgBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.PgBar.TabIndex = 0;
            // 
            // LblProg
            // 
            this.LblProg.AutoSize = true;
            this.LblProg.Location = new System.Drawing.Point(9, 9);
            this.LblProg.Name = "LblProg";
            this.LblProg.Size = new System.Drawing.Size(101, 21);
            this.LblProg.TabIndex = 1;
            this.LblProg.Text = "Processing ......";
            // 
            // FrmWait
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(341, 70);
            this.Controls.Add(this.LblProg);
            this.Controls.Add(this.PgBar);
            this.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmWait";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmWait";
            this.Load += new System.EventHandler(this.FrmWait_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar PgBar;
        private System.Windows.Forms.Label LblProg;
    }
}