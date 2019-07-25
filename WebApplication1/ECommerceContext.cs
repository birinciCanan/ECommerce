using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1
{
    public class ECommerceContext : DbContext
    {
        public ECommerceContext()
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            //Db BAĞLANTISI İNCE AYARLARR (DATABASE İNSTANCE)
            dbContextOptionsBuilder.UseSqlServer("Server=127.0.0.1;Database=ECommerce;User Id=sa;Password =123; ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //DATABASE SEMASI UYGULANIRKEN KULLANILACAK KURAL SETLERİ
            //modelBuilder.Entity<User>().Property(a => a.Email).IsRequired();  //fluent api

        }
        public DbSet<User>Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
