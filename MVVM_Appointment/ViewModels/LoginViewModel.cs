using MVVM_Appointment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Appointment.ViewModels
{
    class LoginViewModel : ViewModelBase
    {
        private List<Customer> customers;
        public ICommand cmdLogin { get; private set; }

        public LoginViewModel(string displayName) : base(displayName)
        {
            cmdLogin = new RelayCommand(param => HandleLogin(param));
        }

        private void HandleLogin(object param)
        {
            var paramArr = (object[])param;
            var username = paramArr[0].ToString();
            var password = paramArr[1].ToString();
            /*var customer = customers.Where(c => c.Username == username).FirstOrDefault();
            if (customer == null)
            {
                // Show fail message
            }
            else
            {
                // TODO: hash password before comparing
                if (customer.Password == password)
                {
                    // Change the control panel items and show empty page
                }
                else
                {
                    // Show fail message
                }
            }*/
        }
    }
}
