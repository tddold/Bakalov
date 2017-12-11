using System;

namespace Bakalov.WebSite.Data.Model.Contracts
{
    public    interface IAuditable
    {
         DateTime? CreatedOn { get; set; }

         DateTime? ModifiedOn { get; set; }
    }
}
