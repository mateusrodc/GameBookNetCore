using Back.MyLibrary.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.MyLibrary.Domain.Interface
{
    public interface IAccountRepository
    {
        Task<Account> Get(string username, string password);
        Task<Account> ValidateUser(string username, string apelido, string email);
        Task<List<Account>> UsersList();
        Task<bool> CreateUser(Account account);
    }
}
