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
using System.Threading;
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
            /* TODO: AUTOMATICALLY OPEN GAME */
            Process csgo = Process.GetProcessesByName("csgo").FirstOrDefault<Process>();
            //Process dbd = Process.GetProcessesByName("Dead").FirstOrDefault<Process>(); TO DO: KERNEL INJECTION
            Process lol = Process.GetProcessesByName("leagueoflegends").FirstOrDefault<Process>();
            Process steam = Process.GetProcessesByName("steam").FirstOrDefault<Process>();
            var steampath = new ProcessStartInfo("Steam.exe");
            steampath.WorkingDirectory = @"C:\Program Files (x86)\Steam";
            var cspath = new ProcessStartInfo("csgo.exe");
            cspath.WorkingDirectory = @"C:\Program Files (x86)\Steam\steamapps\common\Counter-Strike Global Offensive";
            //cspath.WorkingDirectory = @"F:\SteamLibrary\steamapps\common\Counter-Strike Global Offensive"; //MY CUSTOM CSGO PATH

            /* working but it doesn't inject if you take to long to open cs, so i will fix this later
            if (steam != null)
            {
                MessageBox.Show("closing steam, please wait.", "steam already open", MessageBoxButtons.OK, MessageBoxIcon.Information);
                steam.Kill();
                steam = Process.Start(steampath);
                Thread.Sleep(30000); //time to user log in before opening game
                MessageBox.Show("please, open your game.", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Thread.Sleep(30000); //time to user open the game

                /* removing to fix later (error when opening csgo using process.start, it says i need to open cs from steam)
                csgo = Process.Start(cspath);
                MessageBox.Show("opening game.", "please wait", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Thread.Sleep(10000); //time to open csgo before injecting

                try
                {
                    if (csgo != null)
                    {
                        using (WebClient webClient = new WebClient())
                        {
                            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                            webClient.Proxy = null;
                            byte[] inject = s0uxloader.Form1.KeyAuthApp.download("133580");
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
                        MessageBox.Show("please, open your game.", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Environment.Exit(0);
                }
            }*/
            /* TODO: IF (CHEAT = CS) > INJECT CSGO DLL, IF (CHEAT = DBD) > INJECT DBD DLL */

            try
            {
                if (csgo != null)
                {
                    csgo = Process.Start("csgo.exe");
                    Thread.Sleep(5000);
                    using (WebClient webClient = new WebClient())
                    {
                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                        webClient.Proxy = null;
                        byte[] inject = s0uxloader.Form1.KeyAuthApp.download("133580");
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