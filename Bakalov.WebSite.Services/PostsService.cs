using Bakalov.WebSite.Data.SaveContext;
using Bakalov.WebSite.Data.Model;
using Bakalov.WebSite.Data.Repositories;
using Bakalov.WebSite.Services.Contrcts;
using System.Linq;

namespace Bakalov.WebSite.Services
{
    public class PostsService: IPostsService
    {
        private readonly IEfRepository<Post> postRepo;
        private readonly ISaveContext context;

        public PostsService(IEfRepository<Post> postRepo, ISaveContext context)
        {
            this.postRepo = postRepo;
            this.context = context;
        }

        public IQueryable<Post> GetAll()
        {
            return postRepo.All;
        }

        public void Update(Post post)
        {
            this.postRepo.Update(post);
            this.context.Commit();
        }
    }
}
