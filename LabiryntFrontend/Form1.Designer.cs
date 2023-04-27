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
            loginButton = new Button();
            loginPanel = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            linkLabel1 = new LinkLabel();
            passwordInput = new TextBox();
            loginInput = new TextBox();
            registerPanel = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            goBackButton = new Button();
            passwordConfirmInput = new TextBox();
            passwordRegisterInput = new TextBox();
            loginRegisterInput = new TextBox();
            registerButton = new Button();
            pictureBox1 = new PictureBox();
            loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            registerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loginButton
            // 
            loginButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            loginButton.Location = new Point(144, 209);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(125, 42);
            loginButton.TabIndex = 2;
            loginButton.Text = "Zaloguj";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // loginPanel
            // 
            loginPanel.Controls.Add(pictureBox5);
            loginPanel.Controls.Add(pictureBox4);
            loginPanel.Controls.Add(linkLabel1);
            loginPanel.Controls.Add(passwordInput);
            loginPanel.Controls.Add(loginInput);
            loginPanel.Controls.Add(loginButton);
            loginPanel.Location = new Point(751, 109);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(418, 491);
            loginPanel.TabIndex = 0;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.passwordicon;
            pictureBox5.Location = new Point(65, 149);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(34, 32);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.loginicon;
            pictureBox4.Location = new Point(65, 100);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(34, 32);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.LinkColor = Color.FromArgb(46, 196, 182);
            linkLabel1.Location = new Point(158, 254);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(102, 25);
            linkLabel1.TabIndex = 3;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Rejestracja";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // passwordInput
            // 
            passwordInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordInput.Location = new Point(114, 152);
            passwordInput.Name = "passwordInput";
            passwordInput.PlaceholderText = "Hasło";
            passwordInput.Size = new Size(213, 29);
            passwordInput.TabIndex = 1;
            passwordInput.UseSystemPasswordChar = true;
            // 
            // loginInput
            // 
            loginInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginInput.Location = new Point(114, 103);
            loginInput.Name = "loginInput";
            loginInput.PlaceholderText = "Login";
            loginInput.Size = new Size(213, 29);
            loginInput.TabIndex = 0;
            // 
            // registerPanel
            // 
            registerPanel.Controls.Add(pictureBox6);
            registerPanel.Controls.Add(pictureBox3);
            registerPanel.Controls.Add(pictureBox2);
            registerPanel.Controls.Add(goBackButton);
            registerPanel.Controls.Add(passwordConfirmInput);
            registerPanel.Controls.Add(passwordRegisterInput);
            registerPanel.Controls.Add(loginRegisterInput);
            registerPanel.Controls.Add(registerButton);
            registerPanel.Location = new Point(744, 109);
            registerPanel.Name = "registerPanel";
            registerPanel.Size = new Size(425, 491);
            registerPanel.TabIndex = 1;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.passwordicon;
            pictureBox6.Location = new Point(78, 156);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(34, 32);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 5;
            pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.passwordicon;
            pictureBox3.Location = new Point(78, 111);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(34, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.loginicon;
            pictureBox2.Location = new Point(78, 60);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 32);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // goBackButton
            // 
            goBackButton.Location = new Point(184, 273);
            goBackButton.Name = "goBackButton";
            goBackButton.Size = new Size(75, 23);
            goBackButton.TabIndex = 8;
            goBackButton.Text = "Powrót";
            goBackButton.UseVisualStyleBackColor = true;
            goBackButton.Click += goBackButton_Click;
            // 
            // passwordConfirmInput
            // 
            passwordConfirmInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordConfirmInput.Location = new Point(136, 159);
            passwordConfirmInput.Name = "passwordConfirmInput";
            passwordConfirmInput.PlaceholderText = "Potwierdź hasło";
            passwordConfirmInput.Size = new Size(213, 29);
            passwordConfirmInput.TabIndex = 6;
            passwordConfirmInput.UseSystemPasswordChar = true;
            passwordConfirmInput.TextChanged += passwordRegisterInput_TextChanged;
            // 
            // passwordRegisterInput
            // 
            passwordRegisterInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            passwordRegisterInput.Location = new Point(136, 111);
            passwordRegisterInput.Name = "passwordRegisterInput";
            passwordRegisterInput.PlaceholderText = "Hasło";
            passwordRegisterInput.Size = new Size(213, 29);
            passwordRegisterInput.TabIndex = 5;
            passwordRegisterInput.UseSystemPasswordChar = true;
            passwordRegisterInput.TextChanged += passwordRegisterInput_TextChanged;
            // 
            // loginRegisterInput
            // 
            loginRegisterInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginRegisterInput.Location = new Point(136, 63);
            loginRegisterInput.Name = "loginRegisterInput";
            loginRegisterInput.PlaceholderText = "Login";
            loginRegisterInput.Size = new Size(213, 29);
            loginRegisterInput.TabIndex = 4;
            // 
            // registerButton
            // 
            registerButton.Enabled = false;
            registerButton.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            registerButton.Location = new Point(157, 225);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(125, 42);
            registerButton.TabIndex = 7;
            registerButton.Text = "Zarejestruj";
            registerButton.UseVisualStyleBackColor = true;
            registerButton.Click += registerButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo1;
            pictureBox1.Location = new Point(112, 158);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(495, 132);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.DarkSlateGray;
            ClientSize = new Size(1264, 681);
            Controls.Add(pictureBox1);
            Controls.Add(registerPanel);
            Controls.Add(loginPanel);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            registerPanel.ResumeLayout(false);
            registerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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
        private PictureBox pictureBox6;
    }
}