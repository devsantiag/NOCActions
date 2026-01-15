using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Web.WebView2.WinForms;

namespace NOC_Actions.Uc_AvisosSolicitacoesAoCliente
{
    public partial class WebForm : Form
    {
        private WebView2 webForm;

        public WebForm()
        {
            InitializeComponent();
            //this.Load += Form_Load;
            //this.Shown += Form_Shown;
            webView.Enabled = true;
        }

        //private async void Form_Load(object sender, EventArgs e)
        //{
        //    this.Controls.Clear();
        //    webForm = new WebView2
        //    {
        //        Dock = DockStyle.Fill
        //    };

        //    this.Controls.Add(webForm);

        //    await webForm.EnsureCoreWebView2Async();
        //    webForm.Source = new Uri("https://google.com");
        //    webForm.Focus();
        //}


        //private void Form_Shown(object sender, EventArgs e)
        //{
        //    webForm.Focus(); // 👈 AGORA FUNCIONA
        //}

        private void americaNet_toolTripMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("teste");
            webView.Enabled = true;
            webForm.Source = new Uri("https://google.com");
            webForm.Focus();
        }
    }
}
