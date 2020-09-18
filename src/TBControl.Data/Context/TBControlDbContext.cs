using Microsoft.EntityFrameworkCore;
using TBControl.Business.Models;

namespace TBControl.Data.Context
{
    public class TBControlDbContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Provider> Providers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<FormOfPayment> FormOfPayments { get; set; }
        public DbSet<InstallmentType> InstallmentTypes { get; set; }
        public DbSet<Tracking> Trackings { get; set; }
        public DbSet<SalesOrder> SalesOrders { get; set; }
        public DbSet<AddressClient> AddressClients { get; set; }
        public DbSet<AddressProvider> AddressProviders { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<OrderedItem> OrderedItems { get; set; }

        public TBControlDbContext(DbContextOptions<TBControlDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }



    }
}
