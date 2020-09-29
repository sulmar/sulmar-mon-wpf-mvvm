using System;

namespace MON.Battle.Models
{
    public abstract class Base
    {
    }

    public abstract class BaseEntity : Base
    {
        public Guid Id { get; set; }
    }
}
