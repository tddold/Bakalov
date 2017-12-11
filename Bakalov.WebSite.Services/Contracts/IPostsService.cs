using System.Linq;
using Bakalov.WebSite.Data.Model;

namespace Bakalov.WebSite.Services.Contrcts
{
    public interface IPostsService
    {
        IQueryable<Post> GetAll();
    }
}