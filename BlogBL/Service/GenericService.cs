using BlogBL.BLModels;
using BlogDAL.Repository;

namespace BlogBL.Service
{
    public abstract class GenericService<BLModel, DModel> : IGenericService<BLModel>
        where BLModel : class
        where DModel : class
    {
        private readonly IGenericRepository<DModel> _repositroy;
        public GenericService()
        {
            _repositroy = new GenericRepository<DModel>();
        }
        public virtual BLModel FindById(int id)
        {
            var entity = _repositroy.FindById(id);
            return Mapping<BLModel, DModel>.FromDalToBl(entity);
        }
    }
}
