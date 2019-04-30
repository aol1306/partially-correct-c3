namespace PrzykladKolokwium
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

        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Student_Subject> Student_Subject { get; set; }
        public virtual DbSet<Studies> Studies { get; set; }
        public virtual DbSet<Subject> Subject { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
