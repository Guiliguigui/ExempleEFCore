using ExempleEFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleEFCore.Data
{
    public class ApplicationDbContext : DbContext
    {
        // pas nécessaire d'utiliser le constructeur avec options
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source = (LocalDB)\EFCoreDemoDB");
        }
        DbSet<Student> Students { get; set; }

    }
}
