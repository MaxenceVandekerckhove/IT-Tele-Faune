using IT_Télé_Faune.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IT_Télé_Faune.Views.Home
{
    public class IT_TelefauneContext : DbContext
    {
        public IT_TelefauneContext(DbContextOptions<IT_TelefauneContext> options)
            : base(options)
        {

        }
        public DbSet<SalarieBase> Salarie { get; set;}
        public DbSet<ServiceBase> Service { get; set; }
        public DbSet<SiteBase> Site { get; set; }
    }
}
