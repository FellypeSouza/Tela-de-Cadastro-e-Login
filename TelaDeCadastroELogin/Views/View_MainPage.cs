using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelaDeCadastroELogin.Controllers;
using TelaDeCadastroELogin.Models;
using TelaDeCadastroELogin.Views;

namespace TelaDeCadastroELogin
{
    public partial class MainPage : Form
    {
        Ctr_User Ctr_User;
        public MainPage()
        {
            InitializeComponent();
        }

        private void registerUserButton_Click(object sender, EventArgs e)
        {
            //Verificação dos Inputs
            if (usernameInput.Text == "" || passwordInput.Text == "")
            {
                MessageBox.Show("Preencha todos os campos para continuar");
            }
            else
            {
                //Verificação das senhas
                if(passwordInput.Text == confirmPasswordInput.Text)
                {
                    //Crio o modelo do usuário com as informações preenchidas no formulário
                    User User = new User(usernameInput.Text, passwordInput.Text);

                    Ctr_User = new Ctr_User();
                    Ctr_User.RegisterNewUser(User);

                    UserInfoPage UserInfoPage = new UserInfoPage(Ctr_User.ReadUser(User));
                    UserInfoPage.ShowDialog();
                }
                else
                {
                    MessageBox.Show("As senhas devem ser preenchidas igualmente");
                }
            }

        }

        private void clearInputDataButton_Click(object sender, EventArgs e)
        {
            usernameInput.Text = "";
            passwordInput.Text = "";
            confirmPasswordInput.Text = "";
        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCheckBox.Checked)
            {
                passwordInput.UseSystemPasswordChar = false;
                confirmPasswordInput.UseSystemPasswordChar = false;
            }
            else
            {
                passwordInput.UseSystemPasswordChar = true;
                confirmPasswordInput.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ctr_User = new Ctr_User();
        }
    }
}
