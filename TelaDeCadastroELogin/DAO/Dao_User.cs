using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TelaDeCadastroELogin.DAO
{
    internal class Dao_User
    {
        public void StartConnection()
        {
            try
            {
                string connectionString = "Data Source=DESKTOP-CRUVIUA\\SQLEXPRESS;Initial Catalog=TelaDeCadastroELoginDb;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                MessageBox.Show("Sucesso");
            }
            catch(Exception error)
            {
                MessageBox.Show("Erro: " +error);
            }
        }
        public void registerUser()
        {

        }
        public Dao_User()
        {

        }
    }
}
