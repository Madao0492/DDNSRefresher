using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace DDNSRefresher
{
    public partial class DDNSRefresher : Form
    {
        public DDNSRefresher()
        {
            InitializeComponent();
        }

        private void DDNSRefresher_Load(object sender, EventArgs e)
        {
            this.tBox_SSID.Text = Properties.Settings.Default.SSID;
            this.tBox_Host.Text = Properties.Settings.Default.Host;
            this.tBox_Domain.Text = Properties.Settings.Default.Domain;
            this.tBox_Password.Text = Properties.Settings.Default.Password;
        }

        private void btn_SSID_Click(object sender, EventArgs e)
        {
            String[] SSIDList = NativeWifi.GetConnectedNetworkSsids().ToArray();
            if (SSIDList.Length < 1)
            {
                MessageBox.Show("SSIDを取得できません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tBox_SSID.Text = SSIDList[0];
            }
        }

        private void btn_Apply_Click(object sender, EventArgs e)
        {
            if (tBox_SSID.Text == "" || tBox_Host.Text == "" || tBox_Domain.Text == "" || tBox_Password.Text == "")
            {
                MessageBox.Show("空欄の箇所があります", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Properties.Settings.Default.SSID = this.tBox_SSID.Text;
                Properties.Settings.Default.Host = this.tBox_Host.Text;
                Properties.Settings.Default.Domain = this.tBox_Domain.Text;
                Properties.Settings.Default.Password = this.tBox_Password.Text;
                Properties.Settings.Default.Save();
                this.updDDNS(this.tBox_SSID.Text, this.tBox_Host.Text, this.tBox_Domain.Text, this.tBox_Password.Text);
                this.Visible = false;
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            Application.Exit();
        }

        private void フォームを表示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void 終了ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            Application.Exit();
        }

        public void updDDNS(String SSID, String Host, String Domain, String Password)
        {
            String tSSID = SSID;
            String tHost = Host;
            String tDomain = Domain;
            String tPassword = Password;
            String[] pSSID = NativeWifi.GetConnectedNetworkSsids().ToArray();
            if (Properties.Settings.Default.SSID == "")
            {
                return;
            }
            if (pSSID.Length < 1)
            {
                this.popupMessage("DDNSRefresher", "更新中にエラーが発生しました");
                return;
            }
            if (pSSID[0] != tSSID)
            {
                return;
            }
            String IP, URL, response;
            WebClient wc = new WebClient();
            wc.Encoding = System.Text.Encoding.UTF8;
            if ((IP = this.getGIP()) == "ERROR")
            {
                this.popupMessage("DDNSRefresher", "更新中にエラーが発生しました");
                return;
            }
            URL = "http://dyn.value-domain.com/cgi-bin/dyn.fcg?d=" + tDomain + "&p=" + tPassword + "&h=" + tHost + "&i=" + IP;
            try
            {
                response = wc.DownloadString(URL);
                wc.Dispose();
                if (response.IndexOf("OK") != -1)
                {
                    this.popupMessage("DDNSRefresher", "DNSを更新しました");
                }
                else
                {
                    this.popupMessage("DDNSRefresher", "更新中にエラーが発生しました");
                }
            }
            catch
            {
                this.popupMessage("DDNSRefresher", "更新中にエラーが発生しました");
            }
        }

        private String getGIP()
        {
            String URL = "http://dyn.value-domain.com/cgi-bin/dyn.fcg?ip";
            String IP;
            WebClient wc = new WebClient();
            wc.Encoding = System.Text.Encoding.UTF8;
            try
            {
                IP = wc.DownloadString(URL);
                wc.Dispose();
                return IP;
            }
            catch
            {
                return "ERROR";
            }
        }

        private void popupMessage(String Title, String Message)
        {
            notifyIcon1.BalloonTipTitle = Title;
            notifyIcon1.BalloonTipText = Message;
            notifyIcon1.ShowBalloonTip(0);
        }

    }
}
