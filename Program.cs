using ExempleEFCore.Data;
using ExempleEFCore.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace ExempleEFCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contextOptions = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseSqlServer(@"Data Source = (LocalDB)\EntityBDD;Integrated Security=True")
                .Options;

            using var context = new ApplicationDbContext(contextOptions); // ne pas oublier le using

            Student student = new Student()
            {
                Firstname = "Anthony",
                Lastname = "Di Persio",
                Phone = "0607080910",
                Email = "anthony@exemple.com",
            };
            context.Add(student);
            context.SaveChanges();
        }
    }
}
