using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Task
{
    public class Repository
    {
        private readonly string fileName = "clients.json";
        private ObservableCollection<Client> clientList = new ObservableCollection<Client>();

        public Repository() 
        {
            ReadClientsFromFile();
        }

        private void ReadClientsFromFile()
        {
            string clientJson = JsonConvert.SerializeObject(this.clientList); ;
            if (File.Exists(fileName))
            {
                clientJson = File.ReadAllText(fileName);
            }
            else
            {
                File.WriteAllText(fileName, clientJson);
            }
            this.clientList = JsonConvert.DeserializeObject<ObservableCollection<Client>>(clientJson);
        }

        public void LoadClientsIntoFile()
        {
            string clientJson = JsonConvert.SerializeObject(this.clientList);
            File.WriteAllText(fileName, clientJson);
        }

        public void AddClient()
        {
            AddClientWindow clientFormWindow = new AddClientWindow();
            clientFormWindow.ShowDialog();

            Client newClient = clientFormWindow.Client;

            this.clientList.Add(newClient);

            LoadClientsIntoFile();
        }

        public void StartAccountManagement(int selectedIndex)
        {
            AccountFormWindow clientFormWindow = new AccountFormWindow(this.clientList, selectedIndex, this);
            clientFormWindow.ShowDialog();
        }

        public void RemoveClient(int selectedIndex)
        {

            this.clientList.RemoveAt(selectedIndex);
            LoadClientsIntoFile();
        }

        public ObservableCollection<Client> ClientList 
        {
            get
            {
                return this.clientList;
            }
        }
    }
}
