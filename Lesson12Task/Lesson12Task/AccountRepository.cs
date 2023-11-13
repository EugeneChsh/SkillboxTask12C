using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12Task
{
    public class AccountRepository
    {
        public Client LoadedClient { get; private set; }
        public ObservableCollection<AccountNonDeposit> AccountList { get; private set; }
        private Repository repository;

        public AccountRepository() { }

        public AccountRepository(ObservableCollection<Client> _clientList, int _clientIndex, Repository _repository) 
        {
            this.LoadedClient = _clientList[_clientIndex];
            this.AccountList = this.LoadedClient.AccountList;
            this.repository = _repository;
        }

        public void AddAccount() 
        {
            AddAccountWindow addAccountWindow = new AddAccountWindow(this.LoadedClient);
            addAccountWindow.ShowDialog();
            AccountNonDeposit newAccount = addAccountWindow.Account;

            this.LoadedClient.AccountList.Add(newAccount);
            this.repository.LoadClientsIntoFile();
        }

        public void RemoveAccount(int selectedIndex)
        {
            this.LoadedClient.AccountList.RemoveAt(selectedIndex);
            this.repository.LoadClientsIntoFile();
        }

        public void StartTransaction()
        {
            TransactionWindow transactionWindow = new TransactionWindow(this.AccountList);
            transactionWindow.ShowDialog();
            this.repository.LoadClientsIntoFile();
        }
    }
}
