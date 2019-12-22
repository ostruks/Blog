using BlogBL.BLModels;

namespace BlogBL.Service
{
    public interface IGenericService<BLModel>
        where BLModel : class
    {
        BLModel FindById(int id);
    }
}
