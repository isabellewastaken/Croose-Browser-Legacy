using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Wpf;
using System.Reflection.Metadata;
using System.Security.Policy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using WebView2 = Microsoft.Web.WebView2.WinForms.WebView2;

namespace Croose
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            TabPage newTab = new TabPage("New Tab");
            WebView2 webView = new WebView2();
            webView.Dock = DockStyle.Fill;
            newTab.Controls.Add(webView);
            tabControl1.TabPages.Add(newTab);
            webView.Source = new Uri("https://start.duckduckgo.com/");
            string sURL = webView.Source.ToString();
            txtUrl.Text = sURL;
            new TabPage(sURL);
            tabControl1.SelectedTab = newTab;
        }




        private void btnaddTab_Click(object sender, EventArgs e)
        {

            TabPage newTab = new TabPage("New Tab");
            WebView2 webView = new WebView2();
            webView.Dock = DockStyle.Fill;
            newTab.Controls.Add(webView);
            tabControl1.TabPages.Add(newTab);
            webView.Source = new Uri("https://start.duckduckgo.com/");
            string sURL = webView.Source.ToString();
            txtUrl.Text = sURL;
            new TabPage(sURL);
            tabControl1.SelectedTab = newTab;
        }




        private void btnremovetab_Click_1(object sender, EventArgs e)
        {
            WebView2 webView = new WebView2();
            if (tabControl1.TabCount > 0)
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);

            }
        }



        private void btnHome_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
            {
                var currentTab = tabControl1.SelectedTab;

                var webView = (WebView2)currentTab.Controls[0];

                webView.Source = new Uri("https://noai.duckduckgo.com");
                string sURL = webView.Source.ToString();
                txtUrl.Text = sURL;
                new TabPage(sURL);
            }
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            var currentTab = tabControl1.SelectedTab;
            var webView = (WebView2)currentTab.Controls[0];

            if (webView.CanGoBack)
            {
                webView.GoBack();
                string sURL = webView.Source.ToString();
                txtUrl.Text = sURL;
                new TabPage(sURL);
            }
        }


        private void btnForward_Click(object sender, EventArgs e)
        {
            var currentTab = tabControl1.SelectedTab;
            var webView = (WebView2)currentTab.Controls[0];

            if (webView.CanGoForward)
            {
                webView.GoForward();
                string sURL = webView.Source.ToString();
                txtUrl.Text = sURL;
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            TabPage newTab = new TabPage(txtUrl.Text);
            WebView2 webView = new WebView2();
            webView.Dock = DockStyle.Fill;
            newTab.Controls.Add(webView);
            tabControl1.TabPages.Add(newTab);
            string input = txtUrl.Text.Trim();
            string sURL = txtUrl.Text;
            txtUrl.Text = sURL;
            new TabPage(sURL);
            tabControl1.SelectedTab = newTab;

            if (input.StartsWith("https://", StringComparison.OrdinalIgnoreCase))
            {

                webView.Source = new Uri(input);
            }
            else
            {

                string searchUrl = "https://www.ecosia.org/search?q=" + Uri.EscapeDataString(input);
                webView.Source = new Uri(searchUrl);

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            var currentTab = tabControl1.SelectedTab;
            var webView = (WebView2)currentTab.Controls[0];
            webView.Reload();
            string sURL = webView.Source.ToString();
            txtUrl.Text = sURL;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            TabPage newTab = new TabPage(txtUrl.Text);
            WebView2 webView = new WebView2();
            webView.Dock = DockStyle.Fill;
            newTab.Controls.Add(webView);
            tabControl1.TabPages.Add(newTab);
            webView.Source = new Uri("https://sites.google.com/view/croosebrowser/help");
            string sURL = webView.Source.ToString();
            txtUrl.Text = "Croose://help";
            new TabPage("Help");

        }

        private void btnBlock_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
            {
                var currentTab = tabControl1.SelectedTab;

                var webView = (WebView2)currentTab.Controls[0];

                webView.Source = new Uri("https://noai.duckduckgo.com");
                string sURL = webView.Source.ToString();
                txtUrl.Text = sURL;
                new TabPage(sURL);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var currentTab = tabControl1.SelectedTab;
            var webView = (WebView2)currentTab.Controls[0];
            string sURL = webView.Source.ToString();
            txtUrl.Text = sURL;

        }

       
    }
}

 








