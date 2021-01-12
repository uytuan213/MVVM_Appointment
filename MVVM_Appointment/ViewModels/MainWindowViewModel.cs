using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Appointment.ViewModels
{
    class MainWindowViewModel : ViewModelBase
    {
        private Uri _currentPage;
        private List<CommandViewModel> _navigationCommands;

        public Uri CurrentPage
        {
            get => _currentPage;
            set
            {
                _currentPage = value;
                OnPropertyChanged(nameof(CurrentPage));
            }
        }

        public List<CommandViewModel> NavigationCommands { get => _navigationCommands; private set => _navigationCommands = value; }

        public MainWindowViewModel()
        {
            _currentPage = new Uri("Views/AddCustomer.xaml", UriKind.Relative);
            _navigationCommands = new List<CommandViewModel>()
            {
                new CommandViewModel("Add Customer", new RelayCommand(x => CurrentPage=new Uri("Views/AddCustomer.xaml", UriKind.Relative))),
                new CommandViewModel("Add Appointment", new RelayCommand(x => CurrentPage=new Uri("Views/AddAppointment.xaml", UriKind.Relative))),
                new CommandViewModel("All Appointments", new RelayCommand(x => CurrentPage=new Uri("Views/AllAppointments.xaml", UriKind.Relative))),
                new CommandViewModel("About me", new RelayCommand(x => CurrentPage=new Uri("Views/AboutMe.xaml", UriKind.Relative))),
            };
        }
    }
}
