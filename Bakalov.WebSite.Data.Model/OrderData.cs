using Bakalov.WebSite.Data.Model.Abstracts;
using Bakalov.WebSite.Data.Model.Contracts;

namespace Bakalov.WebSite.Data.Model
{
    public class OrderData:DataModel, IDeletable, IAuditable
    {
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }

        public int ItemId { get; set; }

        public virtual Item Item { get; set; }

        public decimal Price { get; set; }

        public decimal Price2 { get; set; }

        public decimal Discount { get; set; }
    }
}
