using MenuPlanner.Common;
using MenuPlanner.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace MenuPlanner.ViewModels
{
    public class ClientViewModel : INotifyPropertyChanged
    {
        public Client Client { get; set; } = new Client();

        public string FullName { get { return $"{Client.FirstName} {Client.LastName}"; } }

        public ClientViewModel()
        {
            ClientSqlRepository repository = new ClientSqlRepository();
            Client = repository.Get(1);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        
        private void InvokePropertyChanged(string propertyName)
        {
            var e = new PropertyChangedEventArgs(propertyName);
            PropertyChangedEventHandler changed = PropertyChanged;
            if (changed != null) changed(this, e);
        }

        private void GetClientFromDatabase(int id)
        {
            var clientRepository = new ClientSqlRepository();
            Client = clientRepository.Get(id);
        }

    }
}
