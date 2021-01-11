using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVM_Appointment.ViewModels
{
    class CommandViewModel : ViewModelBase
    {
        public ICommand Command { get; private set; }

        public CommandViewModel(string displayName, ICommand command)
        {
            if (command == null)
                throw new ArgumentNullException();
            base.DisplayName = displayName;
            this.Command = command;
        }
    }
}
