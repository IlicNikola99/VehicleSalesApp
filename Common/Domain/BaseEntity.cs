using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Domain
{
    [Serializable]
    public class BaseEntity
    {
        public Guid Id { get; } = Guid.NewGuid();
        public DateTime CreatedOn { get; } = DateTime.Now;
    }
}
