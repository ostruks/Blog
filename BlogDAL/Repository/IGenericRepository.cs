using NPoco;
using NPoco.Linq;
using System.Collections.Generic;

namespace BlogDAL.Repository
{
    public interface IGenericRepository<T> where T : class
    {
        void CreateBulk(IEnumerable<T> items);
        int Create(T item);
        T FindById(int id);
        T FindById(string id);
        IQueryProviderWithIncludes<T> Get();
        void Remove(T item);
        void Update(T item);
        void Dispose();
        List<T> GetDataWithQuery(string query, params object[] args);
        List<T> GetDataWithQuery(Sql sql);
        List<T> GetProperty<T>(string query, params object[] args);
        Page<T> GetDataByPage(long page, long itemPerPage, Sql sql);
    }
}
