using Bogus;
using MON.Battle.IServices;

namespace MON.Battle.FakeServices
{
    public class FakePersonService : FakeEntityService<Models.Person>, IPersonService
    {
        public FakePersonService(Faker<Models.Person> faker) : base(faker)
        {
        }
    }
}
