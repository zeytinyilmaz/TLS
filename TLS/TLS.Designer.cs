using System.Drawing;

namespace TLS
{
    partial class TLS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            rdbDisabled = new RadioButton();
            rdbEnable = new RadioButton();
            listView1 = new ListView();
            selection = new ColumnHeader();
            Fremawork = new ColumnHeader();
            architectural = new ColumnHeader();
            progressBar1 = new ProgressBar();
            btnUygula = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdbDisabled);
            groupBox1.Controls.Add(rdbEnable);
            groupBox1.Location = new Point(206, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(173, 69);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // rdbDisabled
            // 
            rdbDisabled.AutoSize = true;
            rdbDisabled.Location = new Point(14, 37);
            rdbDisabled.Name = "rdbDisabled";
            rdbDisabled.Size = new Size(120, 19);
            rdbDisabled.TabIndex = 1;
            rdbDisabled.Text = "TLS / SSL Disabled";
            rdbDisabled.UseVisualStyleBackColor = true;
            // 
            // rdbEnable
            // 
            rdbEnable.AutoSize = true;
            rdbEnable.Checked = true;
            rdbEnable.Location = new Point(14, 15);
            rdbEnable.Name = "rdbEnable";
            rdbEnable.Size = new Size(117, 19);
            rdbEnable.TabIndex = 0;
            rdbEnable.TabStop = true;
            rdbEnable.Text = "TLS / SSL Enabled";
            rdbEnable.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { selection, Fremawork, architectural });
            listView1.GridLines = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Location = new Point(11, 12);
            listView1.Name = "listView1";
            listView1.Size = new Size(189, 199);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // selection
            // 
            selection.Text = "#";
            selection.Width = 30;
            // 
            // Fremawork
            // 
            Fremawork.Text = "FremaWork";
            Fremawork.Width = 65;
            // 
            // architectural
            // 
            architectural.Text = "Architectural";
            architectural.Width = 90;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(11, 217);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(368, 23);
            progressBar1.TabIndex = 9;
            // 
            // btnUygula
            // 
            btnUygula.Location = new Point(206, 171);
            btnUygula.Name = "btnUygula";
            btnUygula.Size = new Size(173, 40);
            btnUygula.TabIndex = 8;
            btnUygula.Text = "Uygula";
            btnUygula.UseVisualStyleBackColor = true;
            btnUygula.Click += btnUygula_Click;
            // 
            // TLS
            // 
            ClientSize = new Size(391, 252);
            Controls.Add(groupBox1);
            Controls.Add(listView1);
            Controls.Add(progressBar1);
            Controls.Add(btnUygula);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximumSize = new Size(407, 291);
            MinimumSize = new Size(407, 291);
            Name = "TLS";
            Text = "TLS/SSL Kontrol";
            FormClosing += TLS_FormClosing;
            Load += TLS_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rdbDisabled;
        private RadioButton rdbEnable;
        private ListView listView1;
        private ProgressBar progressBar1;
        private Button btnUygula;
        private ColumnHeader selection;
        private ColumnHeader Fremawork;
        private ColumnHeader architectural;
    }
}