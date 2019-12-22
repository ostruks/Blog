using AutoMapper;
using BlogBL;
using BlogBL.BLModels;
using BlogEducationALvl.Models;
using System.Web.Mvc;

namespace BlogEducationALvl.Controllers
{
    public class ArticleController : Controller
    {
        private readonly ArticleService<ArticleBL> _articleService;
        public ArticleController()
        {
            _articleService = new ArticleService<ArticleBL>();
        }

        // GET: Article
        public ActionResult Index()
        {
            return View();
        }

        // GET: Article/Details/5
        // TODO: add view for this action 
        public ActionResult Details(int id)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<ArticleBL, DetailsArticleViewModel>()
                .ForMember("Title", opt => opt.MapFrom(c => c.Title))
                .ForMember("SubTitle", opt => opt.MapFrom(c => c.SubTitle))
                .ForMember("Body", opt => opt.MapFrom(c => c.Body))
                .ForMember("Image", opt => opt.MapFrom(c => c.Image))
                .ForMember("AuthorNick", opt => opt.MapFrom(c => c.AuthorId + ""))
                .ForMember("Date", opt => opt.MapFrom(c => c.Date))
                .ForMember("IsActive", opt => opt.MapFrom(c => c.IsActive));
            });
            IMapper mapper = config.CreateMapper();
            ArticleBL article = _articleService.GetById(id);
            DetailsArticleViewModel dest = mapper.Map<ArticleBL, DetailsArticleViewModel>(article);

            return View(dest);
        }

        // GET: Article/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Article/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Article/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Article/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Article/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Article/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
