using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Modelo
{
    public partial class ModulosDeSeguridad : DbContext
    {
        public ModulosDeSeguridad()
            : base("name=ModulosDeSeguridad")
        {
        }

        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Profile> Profile { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.ProductName)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.BrandName)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.DescriptionProduct)
                .IsUnicode(false);

            modelBuilder.Entity<Profile>()
                .HasMany(e => e.User)
                .WithRequired(e => e.Profile)
                .HasForeignKey(e => e.Perfil)
                .WillCascadeOnDelete(false);
        }
    }
}
