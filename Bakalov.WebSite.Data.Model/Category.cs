using Bakalov.WebSite.Data.Model.Abstracts;
using Bakalov.WebSite.Data.Model.Contracts;
using System.Collections.Generic;

namespace Bakalov.WebSite.Data.Model
{
    public class Category : DataModel, IDeletable, IAuditable
    {
        private ICollection<Category> categories;
        private ICollection<Item> items;

        public Category()
        {
            categories = new HashSet<Category>();
            items = new HashSet<Item>();
        }

        public int? ParentCategoryId { get; set; }

        public virtual Category ParentCategory { get; set; }

        public int ItemId { get; set; }

        public virtual ICollection<Item> Item
        {
            get => items;
            set => items = value;
        }

        public int CategoryId { get; set; }

        public virtual ICollection<Category> Categories
        {
            get => categories;
            set => categories = value;
        }

        public string  ImagePath { get; set; }

    }
}