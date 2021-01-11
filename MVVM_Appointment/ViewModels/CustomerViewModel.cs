using MVVM_Appointment.DB;
using MVVM_Appointment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace MVVM_Appointment.ViewModels
{
    class CustomerViewModel : ViewModelBase
    {
        public int CustomerCount { get => MockDB.Customers.Count(); }
        public ICommand cmdAddCustomer { get; }
        public CustomerViewModel(string displayName) : base(displayName)
        {
            cmdAddCustomer = new RelayCommand(param => HandleAddCustomer(param), param => CanAddCustomerExecute(param));
        }

        private bool CanAddCustomerExecute(object param)
        {
            var paramArr = (object[])param;
            var fName = paramArr[0].ToString();
            var lName = paramArr[1].ToString();
            return !(string.IsNullOrEmpty(fName) || string.IsNullOrEmpty(lName));
        }

        private void HandleAddCustomer(object param)
        {
            var paramArr = (object[])param;
            var fName = paramArr[0].ToString();
            var lName = paramArr[1].ToString();
            MockDB.Customers.Add(new Customer(fName, lName));
            OnPropertyChanged("CustomerCount");
            MessageBox.Show("Customer Added!");
        }
    }
}
