using Bakalov.WebSite.Data.Model.Abstracts;
using Bakalov.WebSite.Data.Model.Contracts;

namespace Bakalov.WebSite.Data.Model
{
    public class FolderCategory : DataModel, IDeletable, IAuditable
    {
        public int FolderId { get; set; }

        public virtual Folder Folder { get; set; }

        public string  Name { get; set; }
    }
}
