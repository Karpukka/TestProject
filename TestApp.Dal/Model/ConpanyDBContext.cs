namespace TestApp.Dal.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CompanyDBContext : DbContext
    {
        public CompanyDBContext()
            : base("name=DefauilConnection")
        {
        }

        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Empoyee> Empoyees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasMany(e => e.Department1)
                .WithOptional(e => e.Department2)
                .HasForeignKey(e => e.ParentDepartmentID);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Empoyees)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empoyee>()
                .Property(e => e.ID)
                .HasPrecision(5, 0);
        }
    }
}
