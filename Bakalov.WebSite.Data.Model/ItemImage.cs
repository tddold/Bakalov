using Bakalov.WebSite.Data.Model.Abstracts;
using Bakalov.WebSite.Data.Model.Contracts;

namespace Bakalov.WebSite.Data.Model
{
public    class ItemImage:DataModel, IDeletable, IAuditable
    {
        public int IntemId { get; set; }

        public virtual Item Item { get; set; }

        public int? PostId { get; set; }

        public virtual Post Post { get; set; }

        public string Image { get; set; }

        public int Position  { get; set; }
    }
}
