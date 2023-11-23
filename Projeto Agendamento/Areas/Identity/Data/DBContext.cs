using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Projeto_Agendamento.Areas.Identity.Data;
using System.Reflection.Emit;

namespace Projeto_Agendamento.Data;

public class DBContext : IdentityDbContext<ApplicationUser>
{
    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public DbSet<Estabelecimento> Estabelecimentos { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);

        builder.Entity<ApplicationUser>()
            .HasOne(u => u.Estabelecimento)
            .WithOne(e => e.User)
            .HasForeignKey<Estabelecimento>(e => e.UserId);
    }
}
