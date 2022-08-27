using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Back.MyLibrary.Domain.Models;

namespace Back.MyLibrary.Infra.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext()
        {

        }
        public bool IgnoreSaveChangeAndUseTransaction { get; set; }
        public SqlContext(DbContextOptions<SqlContext> options) : base(options) { }

        public DbSet<Account> Account { get; set; }

        public override int SaveChanges()
        {
            if (!IgnoreSaveChangeAndUseTransaction)
                return base.SaveChanges();
            return 0;
        }
    }
}
