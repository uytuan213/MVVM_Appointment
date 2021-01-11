using MVVM_Appointment.DB;
using MVVM_Appointment.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Navigation;

namespace MVVM_Appointment.ViewModels
{
    class AppointmentViewModel : ViewModelBase
    {
        private ESorting fNameSorting = ESorting.None;
        private ESorting lNameSorting = ESorting.None;
        private Customer _selectedCustomer;
        private DateTime _selectedDate;
        private string _selectedTime;
        private ObservableCollection<Appointment> _appointments;

        public ICommand cmdAddAppointment { get; }
        public ICommand cmdColumnSort { get; }
        public ICommand cmdSaveChanges { get; }

        public List<Customer> Customers { get; private set; }
        public List<string> AppointmentTimes { get; private set; }
        //public int AppointmentCount { get => MockDB.Appointments.Count(); }

        

        public ObservableCollection<Appointment> Appointments { get => _appointments; set => _appointments = value; }
        public Appointment Appointment { get; private set; }
        public Customer SelectedCustomer { get => _selectedCustomer; set => _selectedCustomer = value; }
        public DateTime SelectedDate { get => _selectedDate; set => _selectedDate = value; }
        public string SelectedTime { get => _selectedTime; set => _selectedTime = value; }

        public AppointmentViewModel(string displayName) : base(displayName)
        {
            Customers = MockDB.Customers.ToList();
            AppointmentTimes = MockDB.AppointmentTimes;
            Appointments = MockDB.Appointments;
            SelectedDate = DateTime.Now;
            SelectedTime = MockDB.AppointmentTimes[0];
            cmdAddAppointment = new RelayCommand(param => HandleAddAppointment(), param => CanAddAppointmentExecute());
            cmdColumnSort = new RelayCommand(param => HandleListViewColumnSort(param));
            cmdSaveChanges = new RelayCommand(param => HandleDataGridSaveChanges(), param => CanSaveChangesExecute());
        }

        private bool CanAddAppointmentExecute()
        {
            return SelectedCustomer != null;
        }

        private bool CanSaveChangesExecute()
        {
            throw new NotImplementedException();
        }

        private void HandleDataGridSaveChanges()
        {
            throw new NotImplementedException();
        }

        private void HandleListViewColumnSort(object param)
        {
            var tag = param.ToString();
            if (tag == "CustFirstName")
            {
                if (fNameSorting == ESorting.None || fNameSorting == ESorting.Descending)
                {
                    Customers = Customers.OrderBy(c => c.CustFirstName).ToList();
                    //Customers.Sort((x, y) => x.CustFirstName.CompareTo(y.CustFirstName));
                    fNameSorting = ESorting.Ascending;
                }
                else
                {
                    Customers = Customers.OrderByDescending(c => c.CustFirstName).ToList();
                    //Customers.Sort((x, y) => y.CustFirstName.CompareTo(x.CustFirstName));
                    fNameSorting = ESorting.Descending;
                }
            }
            else
            {
                if (lNameSorting == ESorting.None || lNameSorting == ESorting.Descending)
                {
                    Customers = Customers.OrderBy(c => c.CustLastName).ToList();
                    //Customers.Sort((x, y) => x.CustLastName.CompareTo(y.CustLastName));
                    lNameSorting = ESorting.Ascending;
                }
                else
                {
                    Customers = Customers.OrderByDescending(c => c.CustLastName).ToList();
                    //Customers.Sort((x, y) => y.CustLastName.CompareTo(x.CustLastName));
                    lNameSorting = ESorting.Descending;
                }
            }
            OnPropertyChanged("Customers");
        }

        private void HandleAddAppointment()
        {
            Appointment = new Appointment();
            Appointment.AppoCustomer = SelectedCustomer;
            Appointment.AppoDate = SelectedDate;
            Appointment.AppoTime = SelectedTime;
            MockDB.AddAppointment(Appointment);
            OnPropertyChanged("Appointments");
            MessageBox.Show("Appointment Added!");
        }
    }

    internal enum ESorting
    {
        None,
        Ascending,
        Descending
    }
}
