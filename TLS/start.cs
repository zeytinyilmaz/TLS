using TLS.Siniflar;
using System.Windows.Forms;
using System;
using System.Collections.Generic;

namespace TLS
{
    public partial class start : Form
    {
        private TLS tls;

        public start()
        {
            InitializeComponent();
        }

        private void start_Load(object sender, EventArgs e)
        {
            try
            {
                this.ctrl();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void prbar() {
            this.progressBar1.Value += 1;
        }

        private void ctrl()
        {
            this.progressBar1.Maximum = 4;
            this.progressBar1.Value = 0;
            this.lblAciklama.Text = ".Net Framework ayarlarý okunuyor ...";
            this.prbar();
            this.lblAciklama.Text = ".Net Framework ayarlarý okunuyor (32 bit) ...";
            List<object> win32 = KayitDefteri.anahtarlariGetir(@"SOFTWARE\WOW6432Node\Microsoft\NET Framework Setup\NDP", KayitDefteri.makineOrtam.mevcutMakine, "v");
            this.prbar();
            this.lblAciklama.Text = ".Net Framework ayarlarý okunuyor (64 bit) ...";
            List<object> win64 = KayitDefteri.anahtarlariGetir(@"SOFTWARE\Microsoft\NET Framework Setup\NDP", KayitDefteri.makineOrtam.mevcutMakine, "v");
            this.prbar();
            this.lblAciklama.Text = "Nesneler yükleniyor ....";
            this.prbar(); 
            new TLS(win32, win64).ShowDialog();
            this.Hide();
        }
    }
}
