using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace DatabaseDependentApp
{
    public partial class GuitarsDbContext : DbContext
    {
        public GuitarsDbContext(DbContextOptions options):base(options)
        {
        }

        public virtual DbSet<Guitar> Guitars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Guitar>().ToTable("guitars", "public");

            modelBuilder.Entity<Guitar>(e =>
            {
                e.Property(x => x.Id).HasColumnName("guitar_id");
                e.Property(x => x.Brand).HasColumnName("brand");
                e.Property(x => x.Model).HasColumnName("model");
                e.Property(x => x.BodyStyle).HasColumnName("body_style");
                e.Property(x => x.ScaleLength).HasColumnName("scale_length");
                e.Property(x => x.StringCount).HasColumnName("string_count");
            });
        }
    }
}
