using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaDeCadastroELogin.Models
{
    internal class User
    {
        private string id;
        public string GetId()
        {
            return id;
        }
        public void SetId(string id)
        {
            this.id = id;
        }
        private string name;
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        private string password;
        public string GetPassword()
        {
            return password;
        }
        public User(string name, string password)
        {
            Random random = new Random();
            this.name = name;
            this.password = password;
            this.id = random.Next(1000).ToString();
        }
    }
}
