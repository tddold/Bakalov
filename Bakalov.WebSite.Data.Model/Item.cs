using Bakalov.WebSite.Data.Model.Abstracts;
using Bakalov.WebSite.Data.Model.Contracts;
using System;
using System.Collections.Generic;

namespace Bakalov.WebSite.Data.Model
{
    public class Item : DataModel, IDeletable, IAuditable
    {
        private ICollection<ItemSpecification> itemSpecifications;

        public Item()
        {
            itemSpecifications = new HashSet<ItemSpecification>();
        }

        public string Name { get; set; }

        public string ShortDescription { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public decimal Price2 { get; set; }

        public decimal Discount { get; set; }

        public int FolderId { get; set; }

        public virtual Folder Folder { get; set; }

        public int? PromotionId { get; set; }

        public virtual Promotion Promotion{ get; set; }

        public int? CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public int? CarouselId { get; set; }

        public virtual Carousel Carousel { get; set; }

        public virtual ICollection<ItemSpecification> ItemSpecifications
        {
            get => itemSpecifications;
            set => itemSpecifications = value;
        }
    }
}
