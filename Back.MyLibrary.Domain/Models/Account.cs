using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.MyLibrary.Domain.Models
{
    public class Account
    {
        public int id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public string apelido { get; set; }
        public string email { get; set; }
        public int pontos { get; set; }
        public Account()
        {

        }
        public Account(string _username, string _password, int _pontos, string _email, string _apelido, string _role)
        {
            username = _username;
            password = _password;
            apelido = _apelido;
            email = _email;
            pontos = _pontos;
            role = _role;
        }
    }
}
