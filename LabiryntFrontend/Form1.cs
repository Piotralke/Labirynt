using LabiryntBackend.Models;
using System.Text.Json;

namespace LabiryntFrontend
{
    public partial class Form1 : Form
    {
        dataGetter dataGetter = new dataGetter();
        List<Panel> panelList = new List<Panel>();
        public Form1()
        {
            InitializeComponent();
            panelList.Add(loginPanel);
            panelList.Add(registerPanel);
            panelList[0].BringToFront();
        }

        private void goBackButton_Click(object sender, EventArgs e)
        {
            loginRegisterInput.Clear();
            passwordRegisterInput.Clear();
            passwordConfirmInput.Clear();
            panelList[0].BringToFront();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginInput.Clear();
            passwordInput.Clear();
            panelList[1].BringToFront();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            dataSetter <User> dataSetter = new dataSetter<User>();
            User user = new User(loginRegisterInput.Text, passwordRegisterInput.Text);
            var result = dataSetter.postContent("User", user);
            loginRegisterInput.Clear();
            passwordRegisterInput.Clear();
            passwordConfirmInput.Clear();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            List<string> credentials = new List<string>();
            credentials.Add(loginInput.Text);
            credentials.Add(passwordInput.Text);
            string isValid = dataGetter.getContent("User/Login", credentials);
            if(isValid == "true")
            {
                loginInput.Clear();
                passwordInput.Clear();
                panelList[1].BringToFront();
               
                
            }
            
        }

        private void passwordRegisterInput_TextChanged(object sender, EventArgs e)
        {
            if (passwordRegisterInput.Text != "" || passwordConfirmInput.Text !="")
            {
                if (passwordRegisterInput.Text == passwordConfirmInput.Text)
                {
                    registerButton.Enabled = true;
                }
                else
                {
                    registerButton.Enabled = false;
                }
            }
            
        }

        
    }
}