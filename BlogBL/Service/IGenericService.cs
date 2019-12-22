namespace BlogBL.Service
{
    public interface IGenericService<T> where T : class
    {
        T GetById(int id);
    }
}
