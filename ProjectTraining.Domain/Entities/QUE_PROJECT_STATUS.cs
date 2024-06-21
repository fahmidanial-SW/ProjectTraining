using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectCost.Domain.Enum;

namespace ProjectCost.Domain.Entities
{
    public class QUE_PROJECT_STATUS : BaseDomainEntity
    {
        public Guid ProjectID { get; set; }
        public QUE_PROJECT_STATUS_ENUM? Status { get; set; }
    }
}
