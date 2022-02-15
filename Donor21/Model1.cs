using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Donor21
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=DonationBD")
        {
        }

        public virtual DbSet<Edinica> Edinica { get; set; }
        public virtual DbSet<Status> Status { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Edinica>()
                .Property(e => e.GUID_Donor)
                .IsFixedLength();

            modelBuilder.Entity<Edinica>()
                .Property(e => e.Component)
                .IsFixedLength();

            modelBuilder.Entity<Edinica>()
                .Property(e => e.Group)
                .IsFixedLength();

            modelBuilder.Entity<Status>()
                .HasMany(e => e.Edinicas)
                .WithRequired(e => e.Status)
                .HasForeignKey(e => e.FK_Status)
                .WillCascadeOnDelete(false);
        }
    }
}
