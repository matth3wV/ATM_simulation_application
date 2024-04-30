using ATM_simulation_application.Models;
using Microsoft.EntityFrameworkCore;

namespace ATM_simulation_application;

internal class AccountContext: DbContext
{

    static readonly string connectionString = "Server=localhost; User ID=root; Password=password321; Database=bankatm";
   
    public DbSet<Account> Accounts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySQL(connectionString);
    }
}
