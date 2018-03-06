using Bakalov.WebSite.Data.Model;
using Bakalov.WebSite.Data.Model.Contracts;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Data.Entity;
using System.Linq;

namespace Bakalov.WebSite.Data
{
    public class MsSqlDbContext : IdentityDbContext<User>
    {
        public MsSqlDbContext()
            : base("LocalConnection", throwIfV1Schema: false)
        {
        }

        public IDbSet<Post> Posts { get; set; }

        public IDbSet<Item> Items { get; set; }

        public IDbSet<ItemImage> ItemImages { get; set; }

        public IDbSet<ItemSpecification> ItemSpecifications { get; set; }

        public IDbSet<Folder> Folders { get; set; }

        public IDbSet<FolderCategory> FolderCategories { get; set; }

        public IDbSet<Order> Orders { get; set; }

        public IDbSet<OrderData> OrderDatas { get; set; }

        public IDbSet<OrderInvoiceData> OrderInvoiceDatas { get; set; }

        public IDbSet<Promotion> Promotions { get; set; }

        public IDbSet<Category> Categories { get; set; }

        public IDbSet<Carousel> Carousels { get; set; }

        public override int SaveChanges()
        {
            ApplyAuditInfoRules();
            return base.SaveChanges();
        }

        private void ApplyAuditInfoRules()
        {
            foreach (var entry in
                this.ChangeTracker.Entries()
                    .Where(
                        e =>
                        e.Entity is IAuditable && ((e.State == EntityState.Added) || (e.State == EntityState.Modified))))
            {
                var entity = (IAuditable)entry.Entity;
                if (entry.State == EntityState.Added && entity.CreatedOn == default(DateTime))
                {
                    entity.CreatedOn = DateTime.Now;
                }
                else
                {
                    entity.ModifiedOn = DateTime.Now;
                }
            }
        }

        public static MsSqlDbContext Create()
        {
            return new MsSqlDbContext();
        }
    }
}
