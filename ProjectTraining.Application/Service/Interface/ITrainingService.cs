using ProjectTraining.Application.ViewModel;
using ProjectTraining.Domain.Entities;

namespace ProjectTraining.Application.Service.Interface
{
    public interface ITrainingService
    {
        Task<List<ProjectViewModel_List>> GetListAll();
        Task Add(ProjectViewModel_Insert input);
    }
}
