using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApi504.Data.Models
{
    public partial class FinanceContext : DbContext
    {
        public FinanceContext()
        {
        }

        public FinanceContext(DbContextOptions<FinanceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Credit> Credits { get; set; }
        public virtual DbSet<Loan> Loans { get; set; }
        public virtual DbSet<Log> Logs { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<SocialSecurity> SocialSecurities { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=ALIENWARE-15R3\\MSSQLSERVER2019; user=sa; password=Pastor1987; Initial Catalog=Finance; Integrated Security=True; ConnectRetryCount=0");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Credit>(entity =>
            {
                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Credits)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Credits_PersonId");
            });

            modelBuilder.Entity<Loan>(entity =>
            {
                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Loans)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Loans_PersonId");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.PersonId)
                    .HasName("PK__Person__AA2FFBE5E8252D26");
            });

            modelBuilder.Entity<SocialSecurity>(entity =>
            {
                entity.HasKey(e => e.SocialId)
                    .HasName("PK__SocialSe__67CF711AE4409E4C");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.SocialSecurities)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SocialSecurity_PersonId");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_PersonId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
