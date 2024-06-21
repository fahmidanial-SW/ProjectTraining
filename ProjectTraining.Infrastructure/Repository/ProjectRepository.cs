using Microsoft.EntityFrameworkCore;
using ProjectTraining.Application.ViewModel;
using ProjectTraining.Domain.Entities;
using ProjectTraining.Domain.Repository.Interface;
using ProjectTraining.Infrastructure.Data.Context;

namespace ProjectTraining.Infrastructure.Repository
{
    public class ProjectRepository(QUEDBContext queDB) : IProjectRepository
    {
        public async Task<List<TRAINING>> GetListAll()
        {
            return await queDB.TRAINING.ToListAsync();
        }
        public async Task Add(TRAINING input)
        {
            input.SysDateCreated = DateTime.UtcNow;
            input.SysDateModified = DateTime.UtcNow;

            await queDB.AddAsync(input);
            await queDB.SaveChangesAsync();
        }
    }
}
