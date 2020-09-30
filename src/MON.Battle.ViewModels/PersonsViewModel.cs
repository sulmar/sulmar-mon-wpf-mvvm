using MON.Battle.Fakers;
using MON.Battle.FakeServices;
using MON.Battle.IServices;
using MON.Battle.Models;
using System.Collections.Generic;
using System.Windows.Input;

namespace MON.Battle.ViewModels
{

    public class PersonsViewModel : EntitiesViewModel<Person>
    {
        public PersonsViewModel(IPersonService entityService) : base(entityService)
        {
            UpdateCommand = new DelegateCommand(Update);
        }

        public IEnumerable<Person> Persons => Entities;

        public Person SelectedPerson
        {
            get => SelectedEntity;
            set => SelectedEntity = value;
        }

        public ICommand UpdateCommand { get; }

        //public PersonsViewModel()
        //    : base(new FakePersonService(new PersonFaker()))
        //{

        //}

        private void Update()
        {
            SelectedPerson.FirstName = "John";
        }
    }

}
