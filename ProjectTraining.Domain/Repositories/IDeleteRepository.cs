using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCost.Domain.Repositories
{
    public interface IDeleteRepository
    {
        public Task Delete(Guid ID);
    }
}
