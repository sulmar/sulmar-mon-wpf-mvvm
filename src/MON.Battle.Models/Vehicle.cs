using System.Security.Authentication.ExtendedProtection;

namespace MON.Battle.Models
{

    public class Vehicle : BaseEntity
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public bool IsRemoved { get; set; }
    }
}
