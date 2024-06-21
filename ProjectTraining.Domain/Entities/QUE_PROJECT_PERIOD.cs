using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTraining.Domain.Entities
{
    public class QUE_PROJECT_PERIOD : BaseDomainEntity
    {
        public Guid ProjectID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int ProjectDuration { get; set; }
    }
}
