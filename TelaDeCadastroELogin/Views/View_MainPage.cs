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

namespace TelaDeCadastroELogin
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void registerUserButton_Click(object sender, EventArgs e)
        {

        }

        private void clearInputDataButton_Click(object sender, EventArgs e)
        {

        }

        private void showPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void conexao_Click(object sender, EventArgs e)
        {
            Ctr_User Ctr_User = new Ctr_User();
            Ctr_User.StartConnection();
        }
    }
}
