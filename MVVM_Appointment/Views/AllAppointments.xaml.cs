using MVVM_Appointment.ViewModels;
using System;
using System.Collections.Generic;
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

namespace MVVM_Appointment.Views
{
    /// <summary>
    /// Interaction logic for AllAppointments.xaml
    /// </summary>
    public partial class AllAppointments : Page
    {
        public AllAppointments()
        {
            InitializeComponent();
            DataContext = new AppointmentViewModel("All Appointments");
        }
    }
}
