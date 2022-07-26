namespace s0uxloader
{
    partial class Injector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Injector));
            this.user = new MetroFramework.Controls.MetroLabel();
            this.daysleft = new MetroFramework.Controls.MetroLabel();
            this.createdate = new MetroFramework.Controls.MetroLabel();
            this.inject = new MetroFramework.Controls.MetroButton();
            this.cheat = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.siticoneControlBox3 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox4 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.souxlogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.souxlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(13, 13);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(40, 19);
            this.user.TabIndex = 0;
            this.user.Text = "hello,";
            this.user.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // daysleft
            // 
            this.daysleft.AutoSize = true;
            this.daysleft.Location = new System.Drawing.Point(13, 32);
            this.daysleft.Name = "daysleft";
            this.daysleft.Size = new System.Drawing.Size(60, 19);
            this.daysleft.TabIndex = 4;
            this.daysleft.Text = "days left:";
            this.daysleft.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // createdate
            // 
            this.createdate.AutoSize = true;
            this.createdate.Location = new System.Drawing.Point(13, 51);
            this.createdate.Name = "createdate";
            this.createdate.Size = new System.Drawing.Size(70, 19);
            this.createdate.TabIndex = 5;
            this.createdate.Text = "created in:";
            this.createdate.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // inject
            // 
            this.inject.Location = new System.Drawing.Point(13, 127);
            this.inject.Name = "inject";
            this.inject.Size = new System.Drawing.Size(245, 32);
            this.inject.TabIndex = 6;
            this.inject.Text = "inject cheat";
            this.inject.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.inject.Click += new System.EventHandler(this.inject_Click);
            // 
            // cheat
            // 
            this.cheat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cheat.FormattingEnabled = true;
            this.cheat.ItemHeight = 23;
            this.cheat.Items.AddRange(new object[] {
            "counter-strike: global offensive",
            "dead by daylight",
            "league of legends [free]"});
            this.cheat.Location = new System.Drawing.Point(13, 92);
            this.cheat.Name = "cheat";
            this.cheat.Size = new System.Drawing.Size(245, 29);
            this.cheat.TabIndex = 7;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(93, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "select a game:";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // siticoneControlBox3
            // 
            this.siticoneControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.siticoneControlBox3.HoverState.Parent = this.siticoneControlBox3;
            this.siticoneControlBox3.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox3.Location = new System.Drawing.Point(231, 5);
            this.siticoneControlBox3.Name = "siticoneControlBox3";
            this.siticoneControlBox3.ShadowDecoration.Parent = this.siticoneControlBox3;
            this.siticoneControlBox3.Size = new System.Drawing.Size(40, 25);
            this.siticoneControlBox3.TabIndex = 10;
            this.siticoneControlBox3.Click += new System.EventHandler(this.siticoneControlBox3_Click);
            // 
            // siticoneControlBox4
            // 
            this.siticoneControlBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.siticoneControlBox4.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.siticoneControlBox4.HoverState.Parent = this.siticoneControlBox4;
            this.siticoneControlBox4.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox4.Location = new System.Drawing.Point(191, 5);
            this.siticoneControlBox4.Name = "siticoneControlBox4";
            this.siticoneControlBox4.ShadowDecoration.Parent = this.siticoneControlBox4;
            this.siticoneControlBox4.Size = new System.Drawing.Size(40, 25);
            this.siticoneControlBox4.TabIndex = 9;
            this.siticoneControlBox4.Click += new System.EventHandler(this.siticoneControlBox4_Click);
            // 
            // souxlogo
            // 
            this.souxlogo.BackColor = System.Drawing.Color.Transparent;
            this.souxlogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("souxlogo.BackgroundImage")));
            this.souxlogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.souxlogo.Image = ((System.Drawing.Image)(resources.GetObject("souxlogo.Image")));
            this.souxlogo.Location = new System.Drawing.Point(85, 139);
            this.souxlogo.Name = "souxlogo";
            this.souxlogo.Size = new System.Drawing.Size(101, 69);
            this.souxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.souxlogo.TabIndex = 11;
            this.souxlogo.TabStop = false;
            // 
            // Injector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 11F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 191);
            this.Controls.Add(this.inject);
            this.Controls.Add(this.souxlogo);
            this.Controls.Add(this.siticoneControlBox3);
            this.Controls.Add(this.siticoneControlBox4);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cheat);
            this.Controls.Add(this.createdate);
            this.Controls.Add(this.daysleft);
            this.Controls.Add(this.user);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("SimSun", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Injector";
            this.Padding = new System.Windows.Forms.Padding(20, 51, 20, 17);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Injector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.souxlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel user;
        private MetroFramework.Controls.MetroLabel daysleft;
        private MetroFramework.Controls.MetroLabel createdate;
        private MetroFramework.Controls.MetroButton inject;
        private MetroFramework.Controls.MetroComboBox cheat;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox3;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox4;
        protected internal System.Windows.Forms.PictureBox souxlogo;
    }
}