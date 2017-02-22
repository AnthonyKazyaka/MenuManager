using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuPlanner.Repository;

namespace MenuPlanner.ViewModels
{
    public class ClientsTableViewModel : INotifyPropertyChanged
    {
        private ClientSqlRepository clientRepository = new ClientSqlRepository();

        //public 

        public event PropertyChangedEventHandler PropertyChanged;

        private void InvokePropertyChanged(string propertyName)
        {
            var e = new PropertyChangedEventArgs(propertyName);
            PropertyChangedEventHandler changed = PropertyChanged;
            if (changed != null) changed(this, e);
        }
    }
}
