using Autofac;
using MON.Battle.ViewModels;
using MON.Battle.WPFClient.Modules;

namespace MON.Battle.WPFClient
{

    // Install-Package AutoFac


    public class ViewModelLocator
    {
        private IContainer container;

        public ViewModelLocator()
        {
            ContainerBuilder containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterModule(new PersonModule());
            containerBuilder.RegisterModule(new VehicleModule());

            containerBuilder.RegisterType<ShellViewModel>().SingleInstance();

            container = containerBuilder.Build();
        }

        // public PersonsViewModel PersonsViewModel => new PersonsViewModel(new FakePersonService(new PersonFaker()));
        // public VehiclesViewModel VehiclesViewModel => new VehiclesViewModel(new FakeVehicleService(new VehicleFaker()));

        public ShellViewModel ShellViewModel => container.Resolve<ShellViewModel>();
        public PersonsViewModel PersonsViewModel => container.Resolve<PersonsViewModel>();
        public VehiclesViewModel VehiclesViewModel => container.Resolve<VehiclesViewModel>();
    }
}
