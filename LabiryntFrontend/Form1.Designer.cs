namespace LabiryntFrontend
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginButton = new System.Windows.Forms.Button();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.registerPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.goBackButton = new System.Windows.Forms.Button();
            this.passwordConfirmInput = new System.Windows.Forms.TextBox();
            this.passwordRegisterInput = new System.Windows.Forms.TextBox();
            this.loginRegisterInput = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.loginInput = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.loginPanel.SuspendLayout();
            this.registerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(136, 166);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(75, 23);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Zaloguj";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.Controls.Add(this.pictureBox5);
            this.loginPanel.Controls.Add(this.pictureBox4);
            this.loginPanel.Controls.Add(this.linkLabel1);
            this.loginPanel.Controls.Add(this.passwordInput);
            this.loginPanel.Controls.Add(this.loginInput);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Location = new System.Drawing.Point(245, 141);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(348, 276);
            this.loginPanel.TabIndex = 0;
            // 
            // registerPanel
            // 
            this.registerPanel.Controls.Add(this.pictureBox3);
            this.registerPanel.Controls.Add(this.pictureBox2);
            this.registerPanel.Controls.Add(this.goBackButton);
            this.registerPanel.Controls.Add(this.passwordConfirmInput);
            this.registerPanel.Controls.Add(this.passwordRegisterInput);
            this.registerPanel.Controls.Add(this.loginRegisterInput);
            this.registerPanel.Controls.Add(this.registerButton);
            this.registerPanel.Location = new System.Drawing.Point(242, 144);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(348, 276);
            this.registerPanel.TabIndex = 1;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LabiryntFrontend.Properties.Resources.passwordicon;
            this.pictureBox3.Location = new System.Drawing.Point(87, 114);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LabiryntFrontend.Properties.Resources.loginicon;
            this.pictureBox2.Location = new System.Drawing.Point(86, 70);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(25, 19);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(75, 23);
            this.goBackButton.TabIndex = 2;
            this.goBackButton.Text = "Powrót";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // passwordConfirmInput
            // 
            this.passwordConfirmInput.Location = new System.Drawing.Point(126, 157);
            this.passwordConfirmInput.Name = "passwordConfirmInput";
            this.passwordConfirmInput.PlaceholderText = "Potwierdź hasło";
            this.passwordConfirmInput.Size = new System.Drawing.Size(100, 23);
            this.passwordConfirmInput.TabIndex = 1;
            this.passwordConfirmInput.UseSystemPasswordChar = true;
            this.passwordConfirmInput.TextChanged += new System.EventHandler(this.passwordRegisterInput_TextChanged);
            // 
            // passwordRegisterInput
            // 
            this.passwordRegisterInput.Location = new System.Drawing.Point(126, 114);
            this.passwordRegisterInput.Name = "passwordRegisterInput";
            this.passwordRegisterInput.PlaceholderText = "Hasło";
            this.passwordRegisterInput.Size = new System.Drawing.Size(100, 23);
            this.passwordRegisterInput.TabIndex = 1;
            this.passwordRegisterInput.UseSystemPasswordChar = true;
            this.passwordRegisterInput.TextChanged += new System.EventHandler(this.passwordRegisterInput_TextChanged);
            // 
            // loginRegisterInput
            // 
            this.loginRegisterInput.Location = new System.Drawing.Point(126, 70);
            this.loginRegisterInput.Name = "loginRegisterInput";
            this.loginRegisterInput.PlaceholderText = "Login";
            this.loginRegisterInput.Size = new System.Drawing.Size(100, 23);
            this.loginRegisterInput.TabIndex = 1;
            // 
            // registerButton
            // 
            this.registerButton.Enabled = false;
            this.registerButton.Location = new System.Drawing.Point(136, 198);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 0;
            this.registerButton.Text = "Zarejestruj";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::LabiryntFrontend.Properties.Resources.loginicon;
            this.pictureBox4.Location = new System.Drawing.Point(86, 70);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 23);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(196)))), ((int)(((byte)(182)))));
            this.linkLabel1.Location = new System.Drawing.Point(143, 140);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(63, 15);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Rejestracja";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(126, 114);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PlaceholderText = "Hasło";
            this.passwordInput.Size = new System.Drawing.Size(100, 23);
            this.passwordInput.TabIndex = 1;
            this.passwordInput.UseSystemPasswordChar = true;
            // 
            // loginInput
            // 
            this.loginInput.Location = new System.Drawing.Point(126, 70);
            this.loginInput.Name = "loginInput";
            this.loginInput.PlaceholderText = "Login";
            this.loginInput.Size = new System.Drawing.Size(100, 23);
            this.loginInput.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LabiryntFrontend.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(166, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(495, 132);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::LabiryntFrontend.Properties.Resources.passwordicon;
            this.pictureBox5.Location = new System.Drawing.Point(87, 114);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 23);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.registerPanel);
            this.Controls.Add(this.loginPanel);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.registerPanel.ResumeLayout(false);
            this.registerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button loginButton;
        private Panel loginPanel;
        private LinkLabel linkLabel1;
        private TextBox passwordInput;
        private TextBox loginInput;
        private Panel registerPanel;
        private Button goBackButton;
        private TextBox passwordConfirmInput;
        private TextBox passwordRegisterInput;
        private TextBox loginRegisterInput;
        private Button registerButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}