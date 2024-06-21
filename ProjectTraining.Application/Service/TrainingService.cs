using AutoMapper;
using ProjectTraining.Application.Service.Interface;
using ProjectTraining.Application.ViewModel;
using ProjectTraining.Domain.Entities;
using ProjectTraining.Domain.Repository.Interface;

namespace ProjectTraining.Application.Service
{
    public class TrainingService(IProjectRepository projectRepository, IMapper mapper) : ITrainingService
    {
        public async Task<List<ProjectViewModel_List>> GetListAll()
        {
            var projectList = await projectRepository.GetListAll();

            var result = mapper.Map<List<ProjectViewModel_List>>(projectList);

            return result;
        }
        public async Task Add (ProjectViewModel_Insert input)
        {
            var project = mapper.Map<TRAINING>(input);
            await projectRepository.Add(project);
        }
    }
}
