using Bakalov.WebSite.Data.Model.Abstracts;
using Bakalov.WebSite.Data.Model.Contracts;
using System;
using System.Collections.Generic;

namespace Bakalov.WebSite.Data.Model
{
    public class Order : DataModel, IDeletable, IAuditable
    {
        private ICollection<Item> items;

        public Order()
        {
            this.items = new HashSet<Item>();
        }

        public int ItemId { get; set; }

        public virtual ICollection<Item> Items
        {
            get => items;
            set => items = value;
        }

        public int UserId { get; set; }

        public virtual User User { get; set; }

        public int AddressId { get; set; }

        public virtual Address Address { get; set; }

        public int PaymentTypeId { get; set; }

        public virtual PaymentType PaymentType { get; set; }

        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }

        public int QuantityOfAdults { get; set; }

        public int QuantityOfRooms { get; set; }

        public bool HasChidren { get; set; }

        public bool Status { get; set; }

        public bool IsCompleted { get; set; }
    }
}
