using MVVM_Appointment.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Appointment.DB
{
    public static class MockDB
    {
        private static ObservableCollection<Customer> _customers;
        private static ObservableCollection<Appointment> _appointments;
        private static List<string> _appointmentTimes;
        private static int _appId = 0;

        public static ObservableCollection<Customer> Customers { 
            get 
            {
                if (_customers == null)
                {
                    _customers = new ObservableCollection<Customer>()
                    {
                        new Customer("John", "Smith"),
                        new Customer("Leo", "Messi")
                    };
                }
                return _customers;
            }
        }
        public static ObservableCollection<Appointment> Appointments { 
            get
            {
                if (_appointments == null)
                {
                    _appointments = new ObservableCollection<Appointment>();
                }
                return _appointments;
            } 
        }

        public static List<string> AppointmentTimes
        {
            get
            {
                if (_appointmentTimes == null)
                {
                    _appointmentTimes = new List<string>()
                    {
                        "9:00 AM",
                        "9:30 AM",
                        "10:00 AM",
                        "10:30 AM",
                        "11:00 AM",
                        "11:30 AM",
                        "12:00 PM",
                        "12:30 PM",
                        "1:00 PM",
                        "1:30 PM",
                        "2:00 PM",
                        "2:30 PM",
                        "3:00 PM",
                        "3:30 PM",
                        "4:00 PM",
                        "4:30 PM"
                    };
                }
                return _appointmentTimes;
            }
        }

        public static void AddAppointment(Appointment appo)
        {
            appo.AppoId = ++_appId;
            Appointments.Add(appo);
        }
    }
}
