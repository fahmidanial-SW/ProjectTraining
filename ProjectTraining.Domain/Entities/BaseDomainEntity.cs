using System.ComponentModel.DataAnnotations;

namespace ProjectTraining.Domain.Entities
{
    public abstract class BaseDomainEntity
    {
        protected BaseDomainEntity()
        {
        }

        [Key]
        public Guid ID { get; set; }
        public bool IsDeleted { get; protected set; }
        public string? SysUserCreated { get; set; }
        public DateTime? SysDateCreated { get; set; }
        public string? SysUserModified { get; set; }
        public DateTime? SysDateModified { get; set; }

    }
}
