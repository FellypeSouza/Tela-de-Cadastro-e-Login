using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelaDeCadastroELogin.DAO;

namespace TelaDeCadastroELogin.Controllers
{
    internal class Ctr_User
    {
        public void StartConnection()
        {
            Dao_User Dao_User = new Dao_User();
            Dao_User.StartConnection();
        }
        public Ctr_User() { }
    }
}
