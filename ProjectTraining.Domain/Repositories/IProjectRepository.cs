using ProjectCost.Domain.Entities;
using ProjectCost.Domain.Repositories;

namespace ProjectCost.Domain.Repository.Interface
{
    public interface IProjectRepository : IBaseRepository<QUE_PROJECT>, IDeleteRepository
    {
    }
}
