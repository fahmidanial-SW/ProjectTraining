using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraining.Domain.Repositories
{
    public interface IDeleteRepository
    {
        public Task Delete(Guid ID);
    }
}
