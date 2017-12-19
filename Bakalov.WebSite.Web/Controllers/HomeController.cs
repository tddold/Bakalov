using AutoMapper;
using AutoMapper.QueryableExtensions;
using Bakalov.WebSite.Services.Contrcts;
using Bakalov.WebSite.Web.Models.Home;
using System.Linq;
using System.Web.Mvc;

namespace Bakalov.WebSite.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPostsService postService;
        private readonly IMapper mapper;

        public HomeController(IPostsService postService, IMapper mapper)
        {
            this.postService = postService;
            this.mapper = mapper;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var post = postService
                .GetAll()
                .ProjectTo<PostViewModel>()
                .ToList();

            var viewModel = new HomeViewModel()
            {
                Posts = post
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Index(PostViewModel model)
        {
            //this.postService.Update();
            return this.RedirectToAction("Index");
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}