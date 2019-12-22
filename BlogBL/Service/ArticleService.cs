using BlogBL.BLModels;
using BlogBL.Service;
using BlogDAL.Entities;
using BlogDAL.Repository;
using System;

namespace BlogBL
{
    // TODO: make it with generic services
    public class ArticleService<T> : IGenericService<T> where T : class
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
            return Mapping.ArticleFromDalToBl(_repository.FindById(id));
        }

        T IGenericService<T>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
