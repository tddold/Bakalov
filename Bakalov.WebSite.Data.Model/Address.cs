using Bakalov.WebSite.Data.Model.Abstracts;
using Bakalov.WebSite.Data.Model.Contracts;

namespace Bakalov.WebSite.Data.Model
{
    public class Address : DataModel,   IDeletable, IAuditable
    {
        public int UserId { get; set; }

        public  virtual User User { get; set; }

        public string Phone { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Street { get; set; }

        public int ZipKod { get; set; }

        public int Status { get; set; }
    }
}