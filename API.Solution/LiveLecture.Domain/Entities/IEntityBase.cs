using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveLecture.Domain.Entities
{
    public interface IEntityBase<TKey> : IEquatable<TKey>
    {
        public TKey Id { get; set; }
    }
}