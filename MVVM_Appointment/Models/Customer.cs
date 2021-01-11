using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Appointment.Models
{
    public class Customer : ModelBase
    {
        private string _custFirstName;
        private string _custLastName;

        public string CustFirstName { 
            get => _custFirstName;
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("First name cannot be null!");
                }
                if(_custFirstName != value)
                {
                    _custFirstName = value;
                    OnPropertyChanged();
                }
            }
        }

        public string CustLastName
        {
            get => _custLastName;
            set
            {
                if (value == null)
                {
                    throw new NullReferenceException("First name cannot be null!");
                }
                if (_custLastName != value)
                {
                    _custLastName = value;
                    OnPropertyChanged();
                }

            }
        }

        public Customer(string firstName, string lastName)
        {
            _custFirstName = firstName;
            _custLastName = lastName;
        }

        public override string ToString()
        {
            return $"{CustFirstName} {CustLastName}";
        }
    }
}
