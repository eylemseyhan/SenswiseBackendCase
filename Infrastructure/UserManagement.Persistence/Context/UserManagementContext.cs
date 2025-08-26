using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Domain.Entities;

namespace UserManagement.Persistence.Context
{
    public class UserManagementContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Localde olduğumuz için connection stringi burada verdim.
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=UserManagement;Username=postgres;Password=eylems22");

        }
        public DbSet<User> Users { get; set; }
    }
}
