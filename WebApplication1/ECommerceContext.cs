﻿using Microsoft.EntityFrameworkCore;
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
            modelBuilder.Entity<Category>().HasData(new Category() {
                Id = 1,
                Name="Elektronik",
                Description="Ev elektriğine dair herşey"
            });
            modelBuilder.Entity<Category>().HasData(new Category()
            {
                Id = 2,
                Name = "Beyaz Eşya",
                Description = "Mutfak elektroniği"
            });
            modelBuilder.Entity<Category>().HasData(new Category()
            {
                Id = 3,
                Name = "Tekstil",
                Description = "Gardrobu doldur"
            });
            modelBuilder.Entity<State>().HasData(new State()
            {
                Id = 1,
                Name = "Aktif"
            });
            modelBuilder.Entity<State>().HasData(new State()
            {
                Id = 2,
                Name = "Pasif"
            });

        }
        public DbSet<User>Users { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<State> States { get; set; }
    }
}
