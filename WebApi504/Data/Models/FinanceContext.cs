using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

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
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<SocialSecurity> SocialSecurities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=ALIENWARE-15R3\\MSSQLSERVER2019; user=sa; password=Pastor1987; Initial Catalog=Finance; Integrated Security=True; ConnectRetryCount=0");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Credit>(entity =>
            {
                entity.Property(e => e.Description).IsUnicode(false);

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
                    .HasName("PK__Person__AA2FFBE5C5E72295");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.Id).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);
            });

            modelBuilder.Entity<SocialSecurity>(entity =>
            {
                entity.HasKey(e => e.SocialId)
                    .HasName("PK__SocialSe__67CF711A64D237BE");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.SocialSecurities)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SocialSecurity_PersonId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
