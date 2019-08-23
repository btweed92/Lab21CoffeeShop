using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Lab20CoffeeShopPt3.Models
{
    public partial class CoffeeShopDbContext : DbContext
    {
        public CoffeeShopDbContext()
        {
        }

        public CoffeeShopDbContext(DbContextOptions<CoffeeShopDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=CoffeeShopDb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Items>(entity =>
            {
                entity.HasKey(e => e.ItemId)
                    .HasName("PK__Items__727E838BE9E838A0");

                entity.Property(e => e.ItemDesc)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ItemPrice).HasColumnType("decimal(3, 2)");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Users__1788CC4CC970CC45");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UserFirst)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.UserFunds).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.UserLast)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.UserPass)
                    .IsRequired()
                    .HasMaxLength(15);
            });
        }
    }
}
