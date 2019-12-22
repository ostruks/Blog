using AutoMapper;
using BlogDAL.Entities;
using System;

namespace BlogBL.BLModels
{
    internal static class Mapping
    {
        private static IMapper _blMapper = new MapperConfiguration(
            conf =>
            {
                conf.CreateMap<ArticleBL, Article>();
                conf.CreateMap<CommentBL, Comment>();
                conf.CreateMap<AuthorBL, Author>();
                conf.CreateMap<Article, ArticleBL>();
                conf.CreateMap<Comment, CommentBL>();
                conf.CreateMap<Author, AuthorBL>();
            }).CreateMapper();

        internal static Article ArticleFromBlToDal(ArticleBL article)
        {
            return _blMapper.Map<ArticleBL, Article>(article);
        }

        internal static ArticleBL ArticleFromDalToBl(Article article)
        {
            return _blMapper.Map<Article, ArticleBL>(article);
        }
        internal static Comment CommentFromBlToDal(CommentBL comment)
        {
            return _blMapper.Map<CommentBL, Comment>(comment);
        }
        internal static CommentBL CommentFromDalToBl(Comment comment)
        {
            return _blMapper.Map<Comment, CommentBL>(comment);
        }
        internal static Author AuthorFromBlToDal(AuthorBL author)
        {
            return _blMapper.Map<AuthorBL, Author>(author);
        }
        internal static AuthorBL PublisherFromDalToBl(Author author)
        {
            return _blMapper.Map<Author, AuthorBL>(author);
        }
    }
}
