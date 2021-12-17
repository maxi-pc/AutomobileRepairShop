namespace Automobile_Repair_Shop.EF_Classes
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AutomobileRepairShopEntities : DbContext
    {
        public AutomobileRepairShopEntities()
            : base("name=AutomobileRepairShopConnection")
        {
        }

     //   public virtual DbSet<C__RefactorLog> C__RefactorLog { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServiceOrder> ServiceOrders { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>()
                .Property(e => e.ClientFName)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.ClientLName)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.ClientPhone)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.ClientAddress)
                .IsUnicode(false);

            /*
            modelBuilder.Entity<Client>()
                .HasMany(e => e.Services)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

    */
            modelBuilder.Entity<Employee>()
                .Property(e => e.EmployeeFName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmployeeLName)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmployeePhone)
                .IsUnicode(false);

            modelBuilder.Entity<Employee>()
                .Property(e => e.EmployeeAddress)
                .IsUnicode(false);

            /*
            modelBuilder.Entity<Employee>()
                .HasMany(e => e.Services)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);
*/

            modelBuilder.Entity<Service>()
                .Property(e => e.ServiceCost)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Inventory>()
                .Property(e => e.PartName)
                .IsUnicode(false);

            /*
            modelBuilder.Entity<Inventory>()
                .HasMany(e => e.Services)
                .WithRequired(e => e.Inventory)
                .WillCascadeOnDelete(false);
                */

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.VehiclePlateNumber)
                .IsFixedLength();

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.VehicleStatus)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.VehicleModel)
                .IsUnicode(false);

            modelBuilder.Entity<Vehicle>()
                .Property(e => e.VehicleMake)
                .IsUnicode(false);

            /*
            modelBuilder.Entity<Vehicle>()
                .HasMany(e => e.Services)
                .WithRequired(e => e.Vehicle)
                .WillCascadeOnDelete(false);
                */
        }
    }
}
