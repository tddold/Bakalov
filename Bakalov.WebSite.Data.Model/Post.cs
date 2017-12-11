using Bakalov.WebSite.Data.Model.Abstracts;
using Bakalov.WebSite.Data.Model.Contracts;

namespace Bakalov.WebSite.Data.Model
{
    public class Post : DataModel, IDeletable, IAuditable
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public virtual User Author { get; set; }
    }
}
