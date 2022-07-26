namespace s0uxloader
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.username = new MetroFramework.Controls.MetroTextBox();
            this.key = new MetroFramework.Controls.MetroTextBox();
            this.loginbutton = new MetroFramework.Controls.MetroButton();
            this.password = new MetroFramework.Controls.MetroTextBox();
            this.registerbutton = new MetroFramework.Controls.MetroButton();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.siticoneControlBox4 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox3 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(71, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(23, 92);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(88, 23);
            this.username.Style = MetroFramework.MetroColorStyle.Blue;
            this.username.TabIndex = 1;
            this.username.Text = "username";
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.username.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(23, 121);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(194, 23);
            this.key.Style = MetroFramework.MetroColorStyle.Blue;
            this.key.TabIndex = 3;
            this.key.Text = "key";
            this.key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.key.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(23, 172);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(100, 30);
            this.loginbutton.Style = MetroFramework.MetroColorStyle.Blue;
            this.loginbutton.TabIndex = 4;
            this.loginbutton.Text = "login";
            this.loginbutton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(129, 92);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(88, 23);
            this.password.Style = MetroFramework.MetroColorStyle.Blue;
            this.password.TabIndex = 5;
            this.password.Text = "password";
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // registerbutton
            // 
            this.registerbutton.Location = new System.Drawing.Point(120, 172);
            this.registerbutton.Name = "registerbutton";
            this.registerbutton.Size = new System.Drawing.Size(97, 30);
            this.registerbutton.Style = MetroFramework.MetroColorStyle.Blue;
            this.registerbutton.TabIndex = 6;
            this.registerbutton.Text = "register";
            this.registerbutton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.registerbutton.Click += new System.EventHandler(this.registerbutton_Click);
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(23, 151);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(106, 15);
            this.metroRadioButton1.Style = MetroFramework.MetroColorStyle.White;
            this.metroRadioButton1.TabIndex = 7;
            this.metroRadioButton1.TabStop = true;
            this.metroRadioButton1.Text = "save credentials";
            this.metroRadioButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroRadioButton1.UseVisualStyleBackColor = true;
            // 
            // siticoneControlBox4
            // 
            this.siticoneControlBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.siticoneControlBox4.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneControlBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.siticoneControlBox4.HoverState.Parent = this.siticoneControlBox4;
            this.siticoneControlBox4.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox4.Location = new System.Drawing.Point(160, 5);
            this.siticoneControlBox4.Name = "siticoneControlBox4";
            this.siticoneControlBox4.ShadowDecoration.Parent = this.siticoneControlBox4;
            this.siticoneControlBox4.Size = new System.Drawing.Size(40, 25);
            this.siticoneControlBox4.TabIndex = 2;
            this.siticoneControlBox4.Click += new System.EventHandler(this.siticoneControlBox4_Click);
            // 
            // siticoneControlBox3
            // 
            this.siticoneControlBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.siticoneControlBox3.HoverState.Parent = this.siticoneControlBox3;
            this.siticoneControlBox3.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox3.Location = new System.Drawing.Point(200, 5);
            this.siticoneControlBox3.Name = "siticoneControlBox3";
            this.siticoneControlBox3.ShadowDecoration.Parent = this.siticoneControlBox3;
            this.siticoneControlBox3.Size = new System.Drawing.Size(40, 25);
            this.siticoneControlBox3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 225);
            this.Controls.Add(this.siticoneControlBox3);
            this.Controls.Add(this.siticoneControlBox4);
            this.Controls.Add(this.metroRadioButton1);
            this.Controls.Add(this.registerbutton);
            this.Controls.Add(this.password);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.key);
            this.Controls.Add(this.username);
            this.Controls.Add(this.pictureBox1);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox username;
        private MetroFramework.Controls.MetroTextBox key;
        private MetroFramework.Controls.MetroButton loginbutton;
        private MetroFramework.Controls.MetroTextBox password;
        private MetroFramework.Controls.MetroButton registerbutton;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;

        private void InitializeCompnt()
        {
            this.components = new System.ComponentModel.Container();
            Siticone.Desktop.UI.AnimatorNS.Animation animation4 = new Siticone.Desktop.UI.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.siticoneDragControl1 = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneControlBox1 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneControlBox2 = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.siticoneTransition1 = new Siticone.Desktop.UI.WinForms.SiticoneTransition();
            this.siticoneShadowForm = new Siticone.Desktop.UI.WinForms.SiticoneShadowForm(this.components);
            this.SuspendLayout();
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.BorderRadius = 10;
            this.siticoneTransition1.SetDecoration(this.siticoneControlBox1, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.siticoneControlBox1.HoverState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.HoverState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.Location = new System.Drawing.Point(283, 4);
            this.siticoneControlBox1.Name = "siticoneControlBox3";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox1.TabIndex = 1;
            this.siticoneControlBox1.Click += new System.EventHandler(this.siticoneControlBox3_Click);
            // 
            // siticoneControlBox2
            // 
            this.siticoneControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox2.BorderRadius = 10;
            this.siticoneControlBox2.ControlBoxType = Siticone.Desktop.UI.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.siticoneTransition1.SetDecoration(this.siticoneControlBox2, Siticone.Desktop.UI.AnimatorNS.DecorationType.None);
            this.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.siticoneControlBox2.HoverState.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox2.Location = new System.Drawing.Point(237, 4);
            this.siticoneControlBox2.Name = "siticoneControlBox4";
            this.siticoneControlBox2.ShadowDecoration.Parent = this.siticoneControlBox2;
            this.siticoneControlBox2.Size = new System.Drawing.Size(45, 29);
            this.siticoneControlBox2.TabIndex = 2;
            this.siticoneControlBox2.Click += new System.EventHandler(this.siticoneControlBox4_Click);
        }
        private global::Siticone.Desktop.UI.WinForms.SiticoneDragControl siticoneDragControl1;

        // Token: 0x04000004 RID: 4
        private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox1;

        // Token: 0x04000005 RID: 5
        private global::Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox2;

        // Token: 0x04000009 RID: 9
        private global::Siticone.Desktop.UI.WinForms.SiticoneTransition siticoneTransition1;

        // Token: 0x0400000A RID: 10
        private Siticone.Desktop.UI.WinForms.SiticoneShadowForm siticoneShadowForm;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox4;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox siticoneControlBox3;
    }
}