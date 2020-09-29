using Bogus;
using MON.Battle.Models;
using System;

namespace MON.Battle.Fakers
{
    // Install-Package Bogus
    public class VehicleFaker : Faker<Vehicle>
    {
        public VehicleFaker()
        {
            RuleFor(p => p.Id, f => f.Random.Guid());
            RuleFor(p => p.Model, f => f.Vehicle.Model());
            RuleFor(p => p.Color, f => f.Commerce.Color());
            RuleFor(p => p.IsRemoved, f => f.Random.Bool(0.2f));
        }
    }
}
