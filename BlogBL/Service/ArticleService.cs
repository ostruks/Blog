using BlogBL.BLModels;
using BlogBL.Service;
using BlogDAL.Entities;
using BlogDAL.Repository;

namespace BlogBL
{
    // TODO: make it with generic services
    public class ArticleService : GenericService<ArticleBL, Article>, IArticleService
    {
        private readonly IGenericRepository<Article> _repository;
        public ArticleService()
        { 
            _repository = new GenericRepository<Article>(); 
        }
        public ArticleBL GetById(int id)
        {
            // TODO: Install mapper\
            // TODO: finish mapping all fields
            return Mapping<ArticleBL, Article>.FromDalToBl(_repository.FindById(id));
        }
    }
}
