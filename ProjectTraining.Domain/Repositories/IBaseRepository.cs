namespace ProjectTraining.Domain.Repository.Interface
{
    public interface IBaseRepository<T>
    {
        public Task<List<T>> GetListAll();
        public Task Add(T input);
    }
}
