using System.Drawing;
using System.Windows.Forms;

namespace TLS
{
    partial class start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            progressBar1 = new ProgressBar();
            lblbaslik = new Label();
            lblAciklama = new Label();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 43);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(603, 23);
            progressBar1.TabIndex = 0;
            // 
            // lblbaslik
            // 
            lblbaslik.AutoSize = true;
            lblbaslik.BackColor = Color.Transparent;
            lblbaslik.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblbaslik.ForeColor = Color.Black;
            lblbaslik.Location = new Point(226, 9);
            lblbaslik.Name = "lblbaslik";
            lblbaslik.Size = new Size(173, 30);
            lblbaslik.TabIndex = 1;
            lblbaslik.Text = "TLS/SSL Kontrol";
            // 
            // lblAciklama
            // 
            lblAciklama.AutoSize = true;
            lblAciklama.BackColor = Color.Transparent;
            lblAciklama.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblAciklama.ForeColor = Color.Black;
            lblAciklama.Location = new Point(12, 69);
            lblAciklama.Name = "lblAciklama";
            lblAciklama.Size = new Size(0, 20);
            lblAciklama.TabIndex = 2;
            // 
            // start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(627, 106);
            Controls.Add(lblAciklama);
            Controls.Add(lblbaslik);
            Controls.Add(progressBar1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "start";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TLS";
            Load += start_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private Label lblbaslik;
        private Label lblAciklama;
    }
}
