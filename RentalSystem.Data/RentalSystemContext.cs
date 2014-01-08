namespace RentalSystem.Data
{
    using System.Data.Entity;
    using RentalSystem.Models;

    public class RentalSystemContext : DbContext
    {
        public RentalSystemContext()
            : base("RentalDb")
        {
        }

        public DbSet<Accessory> Accessories { get; set; }

        public DbSet<Contract> Contracts { get; set; }

        public DbSet<Dealer> Dealers { get; set; }

        public DbSet<Machine> Machines { get; set; }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}