namespace Farmers_Market_API.Interfaces
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T Add(T entity);
        T Update(T entity);
        T Delete(T entity);
        T GetById(int id);
    }
}
