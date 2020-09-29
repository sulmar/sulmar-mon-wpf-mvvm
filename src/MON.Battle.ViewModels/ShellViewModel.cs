using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Windows.Input;

namespace MON.Battle.ViewModels
{
    public class ShellViewModel : ViewModelBase
    {
        //public ICommand ShowVehiclesCommand { get; }
        //public ICommand ShowPersonsCommand { get; }

        public ICommand ShowViewCommand { get; }

        public ShellViewModel()
        {
            //ShowVehiclesCommand = new DelegateCommand(ShowVehicles, CanShowVehicles);
            //ShowPersonsCommand = new DelegateCommand(ShowPersons);

            ShowViewCommand = new DelegateCommmand<string>(ShowView);
        }

        //private void ShowVehicles()
        //{

        //}

        //private bool CanShowVehicles()
        //{
        //    return true;
        //}

        //private void ShowPersons()
        //{

        //}

        private void ShowView(string viewName)
        {

        }

    }
}
