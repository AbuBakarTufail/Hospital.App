namespace Hospital.Library.Repository;

public interface ICommon<T>
{
    public Task<List<T>> GetList();
    public Task<T?> GetById(int id);
    public Task<bool> SaveUpdate(T record);
    public Task<bool> DeleteById(int id);
}
