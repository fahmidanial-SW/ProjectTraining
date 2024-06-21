using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCost.Domain.Entities
{
    public class QUE_PROJECT_MANAGER : BaseDomainEntity
    {
        public required Guid ProjectID { get; set; }
        public required string Manager { get; set; }
    }
}
