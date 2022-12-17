using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EX_ASP.Models;

namespace EX_ASP.Data
{
    public class EX_ASPContext : DbContext
    {
        public EX_ASPContext (DbContextOptions<EX_ASPContext> options)
            : base(options)
        {
        }

        public DbSet<EX_ASP.Models.Employee> Employee { get; set; } = default!;

    }
}
