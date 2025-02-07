namespace ManufacturingAPI.Interfaces
{
    public interface IDataAccessRepository
    {
        Task<IEnumerable<T>> GetAll<T, P>(string query, P parameters);
        Task<T> GetSingle<T, P>(string query, P parameters);
        Task<Int32> Insert<P>(string query, P parameters);
        Task<Int32> Update<P>(string query, P parameters);
        Task<Int32> Delete<P>(string query, P parameters);



    }
}
