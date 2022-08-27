using Back.MyLibrary.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.MyLibrary.Application.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(Account account);
    }
}
