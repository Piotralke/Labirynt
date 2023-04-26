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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.loginInput = new System.Windows.Forms.TextBox();
            this.registerPanel = new System.Windows.Forms.Panel();
            this.goBackButton = new System.Windows.Forms.Button();
            this.passwordConfirmInput = new System.Windows.Forms.TextBox();
            this.passwordRegisterInput = new System.Windows.Forms.TextBox();
            this.loginRegisterInput = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.loginPanel.SuspendLayout();
            this.registerPanel.SuspendLayout();
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
            this.loginPanel.Controls.Add(this.linkLabel1);
            this.loginPanel.Controls.Add(this.passwordInput);
            this.loginPanel.Controls.Add(this.loginInput);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Location = new System.Drawing.Point(245, 71);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(348, 276);
            this.loginPanel.TabIndex = 1;
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
            // registerPanel
            // 
            this.registerPanel.Controls.Add(this.goBackButton);
            this.registerPanel.Controls.Add(this.passwordConfirmInput);
            this.registerPanel.Controls.Add(this.passwordRegisterInput);
            this.registerPanel.Controls.Add(this.loginRegisterInput);
            this.registerPanel.Controls.Add(this.registerButton);
            this.registerPanel.Location = new System.Drawing.Point(245, 71);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(348, 276);
            this.registerPanel.TabIndex = 3;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}