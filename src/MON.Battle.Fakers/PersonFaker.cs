using Bogus;

namespace MON.Battle.Fakers
{
    public class PersonFaker : Faker<Models.Person>
    {
        public PersonFaker()
        {
            RuleFor(p => p.Id, f => f.Random.Guid());
            RuleFor(p => p.FirstName, f => f.Person.FirstName);
            RuleFor(p => p.LastName, f => f.Person.LastName);
            RuleFor(p => p.Photo, f => f.Person.Avatar);

            // john.smith@mon.gov.pl
            RuleFor(p => p.Email, (f, p) => $"{p.FirstName}.{p.LastName}@mon.gov.pl");
            // RuleFor(p => p.Email, f => f.Person.Email);
            RuleFor(p => p.DateOfBirth, f => f.Person.DateOfBirth);
        }
    }
}
