using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PopPopPotholesAPI.Domain.Models
{
    public partial class PopPopPotholesDbContext : DbContext
    {
        public PopPopPotholesDbContext()
        {
        }

        public PopPopPotholesDbContext(DbContextOptions<PopPopPotholesDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<CityAdmin> CityAdmin { get; set; }
        public virtual DbSet<Issue> Issue { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("City", "PopPop");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasColumnName("cityName");

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasColumnName("countryName");

                entity.Property(e => e.CountyName).HasColumnName("countyName");

                entity.Property(e => e.StateName).HasColumnName("stateName");
            });

            modelBuilder.Entity<CityAdmin>(entity =>
            {
                entity.ToTable("CityAdmin", "PopPop");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AcctEnabled)
                    .IsRequired()
                    .HasColumnName("acctEnabled")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Email).HasColumnName("email");

                entity.Property(e => e.KeyToCity).HasColumnName("keyToCity");

                entity.Property(e => e.LockOut)
                    .HasColumnName("lockOut")
                    .HasColumnType("datetime");

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("userName");

                entity.Property(e => e.UserPass)
                    .IsRequired()
                    .HasColumnName("userPass");

                entity.HasOne(d => d.KeyToCityNavigation)
                    .WithMany(p => p.CityAdmin)
                    .HasForeignKey(d => d.KeyToCity)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CityAdmin__keyTo__4CA06362");
            });

            modelBuilder.Entity<Issue>(entity =>
            {
                entity.ToTable("Issue", "PopPop");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CityId).HasColumnName("cityId");

                entity.Property(e => e.IssueDesc)
                    .IsRequired()
                    .HasColumnName("issueDesc");

                entity.Property(e => e.IssueStatus)
                    .HasColumnName("issueStatus")
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Unassigned')");

                entity.Property(e => e.IssueTimestamp)
                    .HasColumnName("issueTimestamp")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IssueType)
                    .IsRequired()
                    .HasColumnName("issueType");

                entity.Property(e => e.IssueUpvotes)
                    .HasColumnName("issueUpvotes")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasColumnType("decimal(17, 15)");

                entity.Property(e => e.LinkImg).HasColumnName("linkImg");

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasColumnType("decimal(17, 15)");

                entity.Property(e => e.Severity)
                    .HasColumnName("severity")
                    .HasDefaultValueSql("('moderate')");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Issue)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK__Issue__cityId__52593CB8");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
