using MON.Battle.IServices;
using MON.Battle.Models;
using System.Collections.Generic;

namespace MON.Battle.ViewModels
{
    public abstract class ViewModelBase
    {

    }

    public class VehiclesViewModel : ViewModelBase
    {
        public IEnumerable<Vehicle> Vehicles { get; set; }

        public Vehicle SelectedVehicle { get; set; }

        private readonly IVehicleService vehicleService;

        //public VehiclesViewModel()
        //    : this(new FakeVehicleService(new VehicleFaker()))
        //{ }

        public VehiclesViewModel(IVehicleService vehicleService)
        {
            this.vehicleService = vehicleService;

            Vehicles = this.vehicleService.Get();
        }
    }

}
