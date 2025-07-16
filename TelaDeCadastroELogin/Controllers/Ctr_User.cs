using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelaDeCadastroELogin.DAO;
using TelaDeCadastroELogin.Models;

namespace TelaDeCadastroELogin.Controllers
{
    internal class Ctr_User
    {
        Dao_User Dao_User;
        public void StartConnection()
        {
        }
        public void RegisterNewUser(User User)
        {
            Dao_User = new Dao_User("Data Source=DESKTOP-CRUVIUA\\SQLEXPRESS;Initial Catalog=TelaDeCadastroELoginDb;Integrated Security=True");
            Dao_User.RegisterNewUser(User);
        }

        public User ReadUser(User user)
        {
            Dao_User = new Dao_User("Data Source=DESKTOP-CRUVIUA\\SQLEXPRESS;Initial Catalog=TelaDeCadastroELoginDb;Integrated Security=True");
            return Dao_User.ReadUser(user);
        }
        public Ctr_User()
        {

        }
    }
}
