using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraining.Domain.Entities
{
    public class QUE_PROJECT_CEILING : BaseDomainEntity
    {
        public Guid ProjectID { get; set; }
        public decimal CeilingAmount { get; set; }
    }
}
