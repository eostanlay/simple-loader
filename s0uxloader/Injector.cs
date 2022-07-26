using ManualMapInjection.Injection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s0uxloader
{
    public partial class Injector : MetroFramework.Forms.MetroForm
    {
        public Injector()
        {
            InitializeComponent();
        }
        private void siticoneControlBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void Injector_Load(object sender, EventArgs e)
        {
            s0uxloader.Form1.KeyAuthApp.check();
            user.Text = "hello, " + s0uxloader.Form1.KeyAuthApp.user_data.username;
            //subscription.Text = "Subscription: " + Login.KeyAuthApp.user_data.subscriptions[0].subscription;
            daysleft.Text = s0uxloader.Form1.KeyAuthApp.expirydaysleft();
            createdate.Text = "member since " + UnixTimeToDateTime(long.Parse(s0uxloader.Form1.KeyAuthApp.user_data.createdate));
            //expiration.Text = "expiriration date: " + UnixTimeToDateTime(long.Parse(s0uxloader.Form1.KeyAuthApp.user_data.subscriptions[0].expiry));
            //onlineusers.Text = "online users: " + s0uxloader.Form1.KeyAuthApp.app_data.numOnlineUsers;
            //version.Text = "Current version: " + s0uxloader.Form1.KeyAuthApp.app_data.version;
        }
        public DateTime UnixTimeToDateTime(long unixtime)
        {
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            return dtDateTime;
        }

        private void siticoneControlBox3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void siticoneControlBox4_Click(object sender, EventArgs e)
        {

        }

        private void inject_Click(object sender, EventArgs e)
        {
            /* TODO: AUTO CLOSES STEAM AND RE-OPENS IT + AUTOMATICALLY OPEN GAME
            Process steam = Process.GetProcessesByName("Steam").FirstOrDefault<Process>();
            while (steam != null)
            {
                MessageBox.Show("close your steam", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            TODO: IF (CHEAT = CS) > INJECT CSGO DLL, IF (CHEAT = DBD) > INJECT DBD DLL */
            Process csgo = Process.GetProcessesByName("csgo").FirstOrDefault<Process>();
            Process dbd = Process.GetProcessesByName("Dead").FirstOrDefault<Process>();
            try
            {
                if (csgo != null)
                {
                    using (WebClient webClient = new WebClient())
                    {
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                        webClient.Proxy = null;
                        byte[] inject = s0uxloader.Form1.KeyAuthApp.download("");
                        ManualMapInjector manualMapInjector = new ManualMapInjector(csgo)
                        {
                            AsyncInjection = true
                        };
                        string.Format("hmodule = 0x{0:x8}", manualMapInjector.Inject(inject).ToInt64());
                        Environment.Exit(0);
                    }
                }
                else
                {
                    MessageBox.Show("you need to open the game", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
        }
    }
}