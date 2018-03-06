using Bakalov.WebSite.Data.Model.Abstracts;
using Bakalov.WebSite.Data.Model.Contracts;
using System.Collections.Generic;

namespace Bakalov.WebSite.Data.Model
{
    public class Carousel: DataModel, IDeletable, IAuditable
    {
        private ICollection<Item> items;
        private ICollection<Folder> folders;

        public Carousel()
        {
            items = new HashSet<Item>();
            folders = new HashSet<Folder>();
        }

        public int? ItemId { get; set; }

        public virtual ICollection<Item> Item
        {
            get => items;
            set => items = value;
        }

        public int FolderId { get; set; }

        public virtual ICollection<Folder> Folder
        {
            get => folders;
            set => folders = value;
        }

        public string Name { get; set; }

        public bool  IsItemCarousel { get; set; }

        public bool IsInCarousel  { get; set; }
    }
}