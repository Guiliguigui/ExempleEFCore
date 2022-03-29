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
            using var context = new ApplicationDbContext(new DbContextOptions<ApplicationDbContext>());
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
