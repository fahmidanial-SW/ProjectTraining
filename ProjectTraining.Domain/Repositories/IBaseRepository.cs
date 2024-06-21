namespace ProjectCost.Domain.Repository.Interface
{
    public interface IBaseRepository<T>
    {
        public Task<List<T>> GetListAll();
        public Task<T> GetById(Guid ID);
        public Task Add(T input);
        public Task Update(T input);
    }
}
