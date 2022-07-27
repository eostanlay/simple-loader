using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s0uxloader
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public static api KeyAuthApp = new api(
            name: "s0ux",
            ownerid: "HmbNv2e9Ew",
            secret: "df844e1d2ad711df15795ef98319409352b481ee75d3f4a361bf229eb563ee28",
            version: "1.0"
        );
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            KeyAuthApp.init();
            if (!KeyAuthApp.response.success)
            {
                MessageBox.Show(KeyAuthApp.response.message);
                Environment.Exit(0);
            }
            KeyAuthApp.check();

            if (Properties.Settings.Default.username != string.Empty)
            {
                username.Text = Properties.Settings.Default.username;
                password.Text = Properties.Settings.Default.password;
                save.Checked = Properties.Settings.Default.remember;
            }
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (save.Checked == true)
            {
                Properties.Settings.Default.username = username.Text;
                Properties.Settings.Default.password = password.Text;
                Properties.Settings.Default.remember = save.Checked;
                Properties.Settings.Default.Save();
            }
            
            KeyAuthApp.login(username.Text, password.Text);
            if (KeyAuthApp.response.success)
            {
                Injector main = new Injector();
                main.Show();
                this.Hide();
            }
            else
                MessageBox.Show("wrong username or password.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            KeyAuthApp.register(username.Text, password.Text, key.Text);
            if (KeyAuthApp.response.success)
            {
                Injector main = new Injector();
                main.Show();
                this.Hide();
            }
            else
                MessageBox.Show("error with the key.", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void siticoneControlBox3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void siticoneControlBox4_Click(object sender, EventArgs e)
        {

        }

        private void save_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
