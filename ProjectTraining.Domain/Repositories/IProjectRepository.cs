using ProjectTraining.Domain.Entities;
using ProjectTraining.Domain.Repositories;

namespace ProjectTraining.Domain.Repository.Interface
{
    public interface IProjectRepository : IBaseRepository<TRAINING>, IDeleteRepository
    {
    }
}
