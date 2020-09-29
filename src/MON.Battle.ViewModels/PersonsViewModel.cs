using MON.Battle.Fakers;
using MON.Battle.FakeServices;
using MON.Battle.IServices;
using MON.Battle.Models;
using System.Collections.Generic;

namespace MON.Battle.ViewModels
{
    public class PersonsViewModel : EntitiesViewModel<Person>
    {
        public PersonsViewModel(IPersonService entityService) : base(entityService)
        {
        }

        public IEnumerable<Person> Persons => Entities;

        public Person SelectedPerson
        {
            get => SelectedEntity;
            set => SelectedEntity = value;
        }

        //public PersonsViewModel()
        //    : base(new FakePersonService(new PersonFaker()))
        //{

        //}
    }

}
