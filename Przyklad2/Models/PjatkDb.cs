namespace Przyklad2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class PjatkDb : DbContext
    {
        public PjatkDb()
            : base("name=PjatkDb")
        {
        }

        public virtual DbSet<Animal> Animals { get; set; }
        public virtual DbSet<AnimalType> AnimalTypes { get; set; }
        public virtual DbSet<Owner> Owners { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<AnimalType>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Owner>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Owner>()
                .Property(e => e.LastName)
                .IsUnicode(false);
        }
    }
}
