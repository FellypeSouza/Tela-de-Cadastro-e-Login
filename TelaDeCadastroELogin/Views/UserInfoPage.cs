﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelaDeCadastroELogin.Controllers;
using TelaDeCadastroELogin.Models;

namespace TelaDeCadastroELogin.Views
{
    public partial class UserInfoPage : Form
    {
        Ctr_User Ctr_User;
        User user;
        public UserInfoPage(User User)
        {
            InitializeComponent();
            user = new User(User);
        }

        private void UserInfoPage_Load(object sender, EventArgs e)
        {
            Ctr_User = new Ctr_User();
       

            usernameLabel.Text = user.GetName();
            passwordLabel.Text = user.GetPassword();
            dateLabel.Text = user.GetDate().ToString();
        }

        private void alterPasswordButton_Click(object sender, EventArgs e)
        {

            checkPasswordPanel.Visible = true;

            Ctr_User = new Ctr_User();
            Ctr_User.AlterPassword(user);
            RefreshUserInfo();
        }

        private void alterDataButton_Click(object sender, EventArgs e)
        {
            alterDataPanel.Visible = true;
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            deleteUserPanel.Visible = true;
        }

        private void checkPassword_Click(object sender, EventArgs e)
        {
            if (checkPasswordTextbox.Text == "")
            {
                MessageBox.Show("Textbox vazio");
            }
            else
            {
                if (checkPasswordTextbox.Text == user.GetPassword())
                {
                    checkPasswordPanel.Visible = false;
                    alterUserPasswordPanel.Visible = true;
                }
                else
                {
                    if (checkPasswordTextbox.Text != user.GetPassword())
                    {
                        MessageBox.Show("Senha incorreta");
                    }
                }
            }
        }

        private void sendNewPassword_Click(object sender, EventArgs e)
        {
            if (newUserPasswordTextbox.Text == "")
            {
                MessageBox.Show("Textbox vazio");
            }
            else
            {
                user.SetPassword(newUserPasswordTextbox.Text);
                
                if(user.GetPassword() == newUserPasswordTextbox.Text)
                {
                    Ctr_User.AlterPassword(user);
                    MessageBox.Show("Senha alterada com sucesso");
                    alterUserPasswordPanel.Visible = false;
                    RefreshUserInfo();
                }
                else
                {
                    MessageBox.Show("Houve um erro");
                }
            }
        }

        private void sendNewData_Click(object sender, EventArgs e)
        {
            if (passwordTextbox.Text == "" || newUsernameTextbox.Text == "")
            {
                MessageBox.Show("Inputs vazios");
            }
            else
            {
                if (passwordTextbox.Text == user.GetPassword())
                {
                    user.SetName(newUsernameTextbox.Text);

                    if (user.GetPassword() == passwordTextbox.Text)
                    {
                        Ctr_User.AlterData(user);
                        alterDataPanel.Visible = false;
                        RefreshUserInfo();
                    }
                    else
                    {
                        MessageBox.Show("Houve um erro");
                    }
                }
                else
                {
                    MessageBox.Show("Senha incorreta");
                }
            }
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            if (userPasswordTextbox.Text == "")
            {
                MessageBox.Show("Input vazio");
            }
            else
            {
                if(deleteUserCheck.Checked)
                {
                    if (user.GetPassword() == userPasswordTextbox.Text)
                    {
                        Ctr_User.DeleteUser(user);
                        user = null;
                        RefreshUserInfo();
                        deleteUserPanel.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Senha incorreta");
                    }
                }
                else
                {
                    MessageBox.Show("Confirmação necessária");
                }
            }
        }
        public void RefreshUserInfo()
        {
            if(user == null)
            {
                usernameLabel.Text = "Sem cadastro";
                passwordLabel.Text = "Sem cadastro";
                dateLabel.Text = "Sem cadastro";
            }
            else
            {
                usernameLabel.Text = user.GetName();
                passwordLabel.Text = user.GetPassword();
                dateLabel.Text = user.GetDate().ToString();
            }
        }
    }
}
