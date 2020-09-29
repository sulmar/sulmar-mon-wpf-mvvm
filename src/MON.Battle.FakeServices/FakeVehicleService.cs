using Bogus;
using MON.Battle.Fakers;
using MON.Battle.IServices;
using MON.Battle.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace MON.Battle.FakeServices
{
    public class FakeVehicleService : FakeEntityService<Vehicle>, IVehicleService
    {
        public FakeVehicleService(Faker<Vehicle> faker) : base(faker)
        {
        }
    }
}
