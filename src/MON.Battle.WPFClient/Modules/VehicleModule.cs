using Autofac;
using Bogus;
using MON.Battle.Fakers;
using MON.Battle.FakeServices;
using MON.Battle.IServices;
using MON.Battle.ViewModels;

namespace MON.Battle.WPFClient.Modules
{
    public class VehicleModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<VehiclesViewModel>().SingleInstance();
            builder.RegisterType<FakeVehicleService>().As<IVehicleService>().SingleInstance();
            builder.RegisterType<VehicleFaker>().As<Faker<Models.Vehicle>>().SingleInstance();
        }
    }
}
