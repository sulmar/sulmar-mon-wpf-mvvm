using System;

namespace MON.Battle.Models
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Photo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}
