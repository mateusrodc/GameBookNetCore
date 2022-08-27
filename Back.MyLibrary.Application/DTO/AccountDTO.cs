using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.MyLibrary.Application.DTO
{
    public class AccountDTO
    {
        public string username { get; set; }
        public string password { get; set; }
        public AccountDTO()
        {

        }
        public AccountDTO(string _username, string _password)
        {
            username = _username;
            password = _password;
        }
    }
}
