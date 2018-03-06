using Bakalov.WebSite.Data.Model.Abstracts;
using Bakalov.WebSite.Data.Model.Contracts;

namespace Bakalov.WebSite.Data.Model
{
    public class Folder : DataModel, IDeletable, IAuditable
    {
        public int? ParentFolderId { get; set; }

        public virtual Folder ParentFolder { get; set; }

        public string Image { get; set; }

        public string Url { get; set; }

        public int MySort { get; set; }

        public virtual FolderStatus FolderStatus { get; set; }
    }
}
