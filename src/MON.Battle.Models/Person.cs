using System;
using System.ComponentModel;

namespace MON.Battle.Models
{

    public class Person : BaseEntity
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FullName));
            }
        }
        public string LastName
        {
            get => lastName; set
            {
                lastName = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(FullName));
            }
        }
        public string Photo { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}
