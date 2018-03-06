using Bakalov.WebSite.Data.Model.Abstracts;
using Bakalov.WebSite.Data.Model.Contracts;

namespace Bakalov.WebSite.Data.Model
{
    public class OrderInvoiceData : DataModel, IDeletable, IAuditable
    {
        public int OrderId { get; set; }

        public virtual Order Order { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public string Mol { get; set; }

        public int Eik { get; set; }

        public int Dds { get; set; }
    }
}
