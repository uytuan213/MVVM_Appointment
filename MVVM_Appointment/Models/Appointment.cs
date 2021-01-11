using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Appointment.Models
{
    public class Appointment : ModelBase
    {
        private int _appoId;
        private DateTime _appoDate;
        private string _appoTime;
        private Customer _appoCustomer;

        public int AppoId { get => _appoId; set => _appoId = value; }

        public DateTime AppoDate
        {
            get => _appoDate;
            set
            {
                /*if (value < DateTime.Now)
                {
                    throw new ArgumentException("Appointment date/time must be in the future!");
                }*/
                if (_appoDate!= value)
                {
                    _appoDate= value;
                    OnPropertyChanged();
                }
            }
        }

        public Customer AppoCustomer
        {
            get => _appoCustomer;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Customer cannot be null to book appointment!");
                }
                if (_appoCustomer != value)
                {
                    _appoCustomer = value;
                    OnPropertyChanged();
                }
            }
        }

        public string AppoTime
        {
            get => _appoTime;
            set
            {
                _appoTime = value;
                OnPropertyChanged();
            }
        }
    }
}
