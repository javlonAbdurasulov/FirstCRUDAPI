namespace FirstCRUDAPI.Services.Interfaces
{
    public interface ICRUDBase<T>
    {
        string create(T model);
        IEnumerable<T> read();
        string update(T model);
        string delete(int id);  
    }
}
