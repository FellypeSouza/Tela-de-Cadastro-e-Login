using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelaDeCadastroELogin.Models
{
    public class User
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
        public void SetPassword(string password)
        {
            this.password = password;
        }
        private DateTime registrationDate;
        public DateTime GetDate()
        {
            return registrationDate;
        }
        public void SetRegistrationDate()
        {
            registrationDate = DateTime.Now;
        }
        public User(string name, string password)
        {
            Random random = new Random();
            this.id = random.Next(1000).ToString();
            this.name = name;
            this.password = password;
            this.registrationDate = DateTime.Now;
        }
        public User(User User)
        {
            this.id = User.GetId();
            this.name = User.GetName();
            this.password = User.GetPassword();
            this.registrationDate = User.GetDate();
        }
        public User()
        {
            Random random = new Random();
            this.id = random.Next(1000).ToString();
            this.name = name;
            this.password = password;
        }
    }
}
