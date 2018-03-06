using Bakalov.WebSite.Data.Model.Abstracts;
using Bakalov.WebSite.Data.Model.Contracts;
using System;

namespace Bakalov.WebSite.Data.Model
{
    public class Promotion : DataModel, IDeletable, IAuditable
    {
        public decimal Price { get; set; }

        public decimal OldPrice { get; set; }

        public int? ParentPromotionId { get; set; }

        public virtual Promotion ParentPromotion { get; set; }

        public string ImagePath { get; set; }

        public DateTime SatartDate{ get; set; }

        public DateTime EndDate { get; set; }

    }
}