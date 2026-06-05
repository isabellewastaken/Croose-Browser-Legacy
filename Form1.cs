using System;
using System.Windows.Forms;

namespace Croose
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnaddTab_Click(null, EventArgs.Empty); // le fix
        }

        private WebBrowser CreateVistaBrowser()
        {
            WebBrowser browser = new WebBrowser();
            browser.Dock = DockStyle.Fill;
            browser.ScriptErrorsSuppressed = true;

            browser.Navigated += (s, e) => {
                if (tabControl1.SelectedTab != null && tabControl1.SelectedTab.Controls[0] == s)
                {
                    txtUrl.Text = browser.Url?.ToString() ?? "";
                }
            };
            return browser;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnaddTab_Click(sender, e);
        }

        private void btnaddTab_Click(object sender, EventArgs e)
        {
            TabPage newTab = new TabPage("New Tab");
            WebBrowser browser = CreateVistaBrowser();
            newTab.Controls.Add(browser);
            tabControl1.TabPages.Add(newTab);

            browser.Navigate("https://start.duckduckgo.com/");
            txtUrl.Text = "https://start.duckduckgo.com/";
            tabControl1.SelectedTab = newTab;
        }

        private void btnremovetab_Click_1(object sender, EventArgs e)
        {
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
                var browser = (WebBrowser)currentTab.Controls[0];

                browser.Navigate("https://html.duckduckgo.com/html/");
                txtUrl.Text = "https://html.duckduckgo.com/html/";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
            {
                var currentTab = tabControl1.SelectedTab;
                var browser = (WebBrowser)currentTab.Controls[0];

                if (browser.CanGoBack)
                {
                    browser.GoBack();
                }
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
            {
                var currentTab = tabControl1.SelectedTab;
                var browser = (WebBrowser)currentTab.Controls[0];

                if (browser.CanGoForward)
                {
                    browser.GoForward();
                }
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            TabPage newTab = new TabPage("New Tab");
            WebBrowser browser = CreateVistaBrowser();
            newTab.Controls.Add(browser);
            tabControl1.TabPages.Add(newTab);
            tabControl1.SelectedTab = newTab;

            string input = txtUrl.Text.Trim();

            if (input.StartsWith("https://", StringComparison.OrdinalIgnoreCase) ||
                input.StartsWith("http://", StringComparison.OrdinalIgnoreCase))
            {
                browser.Navigate(input);
            }
            else
            {
                string searchUrl = "https://duckduckgo.com/?q=" + Uri.EscapeDataString(input);
                browser.Navigate(searchUrl);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
            {
                var currentTab = tabControl1.SelectedTab;
                var browser = (WebBrowser)currentTab.Controls[0];
                browser.Refresh(); // WebBrowser uses Refresh instead of Reload
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            TabPage newTab = new TabPage("Help");
            WebBrowser browser = CreateVistaBrowser();
            newTab.Controls.Add(browser);
            tabControl1.TabPages.Add(newTab);
            tabControl1.SelectedTab = newTab;

            browser.Navigate("https://sites.google.com/view/croosebrowser/help"); // Hey, this isn't relevant to Legacy. Maybe we oughta fix this?
            txtUrl.Text = "Croose://help";
        }

        private void btnBlock_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 0)
            {
                var currentTab = tabControl1.SelectedTab;
                var browser = (WebBrowser)currentTab.Controls[0];
                txtUrl.Text = browser.Url?.ToString() ?? "";
            }
        }
    }
}
