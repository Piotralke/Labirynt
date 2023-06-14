using LabiryntBackend.Models;
using System.Diagnostics;
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

        private async void registerButton_Click(object sender, EventArgs e)
        {
            dataSetter<User> dataSetter = new dataSetter<User>();
            User user = new User(loginRegisterInput.Text, passwordRegisterInput.Text);
            var result = await dataSetter.postContent("User", user);
            if (result != null)
            {
                loginRegisterInput.Clear();
                passwordRegisterInput.Clear();
                passwordConfirmInput.Clear();
                MessageBox.Show("Pomyœlnie zarejestrowano!");
            }
            else
            {
                MessageBox.Show("Istnieje ju¿ u¿ytkownik o podanym loginie", "B³¹d rejestracji", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
     
            User user = dataGetter.login(loginInput.Text, passwordInput.Text);
            if (user != null)
            {
                Debug.WriteLine(JsonSerializer.Serialize(user));
                loginInput.Clear();
                passwordInput.Clear();
                GbMaze gbMaze = new GbMaze(user.id_user);
                this.Hide();
                gbMaze.Show();

            }
            else
            {
                MessageBox.Show("B³êdne dane logowania", "B³¹d logowania",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void passwordRegisterInput_TextChanged(object sender, EventArgs e)
        {
            if (passwordRegisterInput.Text != "" || passwordConfirmInput.Text != "")
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