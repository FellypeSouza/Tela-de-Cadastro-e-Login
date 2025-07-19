using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using TelaDeCadastroELogin.Models;

namespace TelaDeCadastroELogin.DAO
{
    internal class Dao_User
    {
        private SqlConnection connection;
        private string connectionString = "Data Source=DESKTOP-CRUVIUA\\SQLEXPRESS;Initial Catalog=TelaDeCadastroELoginDb;Integrated Security=True";
        public Dao_User(string connectionString)
        {
            //Conexão com o banco de dados
            connection = new SqlConnection(connectionString);
        }
        
        public void RegisterNewUser(User user)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Usuario (IdUser,username, password, registrationDate) VALUES (@id, @usuarioNome, @usuarioSenha, @date)";
                
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.Add(new SqlParameter("@id", user.GetId()));
                cmd.Parameters.Add(new SqlParameter("@usuarioNome", user.GetName()));
                cmd.Parameters.Add(new SqlParameter("@usuarioSenha", user.GetPassword()));
                cmd.Parameters.Add(new SqlParameter("@date", user.GetDate()));

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: "+ex);
                }
            }
        }
        
        public User ReadUser(User user)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Usuario WHERE idUser = @id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.Add(new SqlParameter("@id", user.GetId()));

                try
                {
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        user.SetId(Convert.ToString(dr["idUser"]));
                        user.SetName(Convert.ToString(dr["username"]));
                    }
                    else
                    {
                        return null;
                    }
                    conn.Close();
                    return user;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro: " + ex);
                    return null;
                }
            }
        }
        public void AlterPassword(User User)
        {
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Usuario SET password = @newPassword WHERE idUser = @id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.Add(new SqlParameter("@newPassword", User.GetPassword()));
                cmd.Parameters.Add(new SqlParameter("@id", User.GetId()));

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro: " + ex);
                }
            }
        }
        public void AlterData(User User)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE Usuario SET username = @newUsername WHERE idUser = @id";

                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.Add(new SqlParameter("@newUsername", User.GetName()));
                cmd.Parameters.Add(new SqlParameter("@id", User.GetId()));

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Dados alterados com sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex);
                }
            }
        }
    }
}
