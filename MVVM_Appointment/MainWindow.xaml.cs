using MVVM_Appointment.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MVVM_Appointment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ObservableCollection<CommandViewModel> commands = new ObservableCollection<CommandViewModel>()
            {
                new CommandViewModel("Add Customer", new RelayCommand(x => mainFrame.Source=new Uri("Views/AddCustomer.xaml", UriKind.Relative))),
                new CommandViewModel("Add Appointment", new RelayCommand(x => mainFrame.Source=new Uri("Views/AddAppointment.xaml", UriKind.Relative))),
                new CommandViewModel("All Appointments", new RelayCommand(x => mainFrame.Source=new Uri("Views/AllAppointments.xaml", UriKind.Relative))),
                new CommandViewModel("About me", new RelayCommand(x => mainFrame.Source=new Uri("Views/AboutMe.xaml", UriKind.Relative))),
            };
            lstCommands.ItemsSource = commands;
        }
    }
}
