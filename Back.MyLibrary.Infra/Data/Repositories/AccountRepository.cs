using Back.MyLibrary.Domain.Interface;
using Back.MyLibrary.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.MyLibrary.Infra.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly SqlContext _context;

        public AccountRepository(SqlContext context)
        {
            _context = context;
        }
        public async Task<Account> Get(string username, string password)
        {
            return _context.Account.Where(x => x.username == username && x.password == x.password).FirstOrDefault();
        }
        public async Task<List<Account>> UsersList()
        {
            var users = _context.Account.ToList();
            return users;
        }
        public async Task<bool> CreateUser(Account model)
        {
            var account = new Account(model.username, model.password, 0, model.email, model.apelido, model.role);
            _context.Account.Add(account);
            _context.SaveChanges();
            return true;
        }
        public async Task<Account> ValidateUser(string username, string apelido, string email)
        {
            return _context.Account.Where(x => x.username == username || x.email == email || x.apelido == apelido).FirstOrDefault();
        }
    }
}
