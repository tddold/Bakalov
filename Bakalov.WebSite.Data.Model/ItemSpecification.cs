using Bakalov.WebSite.Data.Model.Abstracts;
using Bakalov.WebSite.Data.Model.Contracts;

namespace Bakalov.WebSite.Data.Model
{
    public class ItemSpecification : DataModel, IDeletable, IAuditable
    {
        public string Key { get; set; }

        public string  Value { get; set; }

        public int ItemId { get; set; }

        public virtual Item Item { get; set; }
    }
}