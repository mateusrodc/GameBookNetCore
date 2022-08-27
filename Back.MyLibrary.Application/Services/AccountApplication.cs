using Back.MyLibrary.Application.DTO;
using Back.MyLibrary.Application.Interfaces;
using Back.MyLibrary.Domain.Interface;
using Back.MyLibrary.Domain.Models;
using Back.MyLibrary.Infra.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.MyLibrary.Application.Services
{
    public class AccountApplication : IAccountApplication
    {
        private readonly SqlContext _context;
        private readonly IAccountRepository _accountRepository;
        public AccountApplication(SqlContext context, IAccountRepository accountRepository)
        {
            _context = context;
            _accountRepository = accountRepository;
        }
        public async Task<Account> Get(string username, string password)
        {
            return await _accountRepository.Get(username, password);
        }
        public async Task<List<Account>> UsersList()
        {
            var users = await _accountRepository.UsersList();
            return users;
        }
        public async Task<bool> CreateUser(Account account)
        {
            var user = await _accountRepository.CreateUser(account);
            return user;
        }
        public async Task<Account> ValidateUser(string username, string apelido, string email)
        {
            return await _accountRepository.ValidateUser(username, apelido, email);
        }
    }
}
