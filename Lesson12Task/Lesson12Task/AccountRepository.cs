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
        public ObservableCollection<Client> ClientList { get; private set; }
        public ObservableCollection<Account<decimal, decimal>> AccountList { get; private set; }
        private Repository repository;

        public AccountRepository() { }

        public AccountRepository(ObservableCollection<Client> _clientList, int _clientIndex, Repository _repository) 
        {
            this.ClientList = _clientList;
            this.LoadedClient = _clientList[_clientIndex];
            FillAccountList();
            this.repository = _repository;
        }

        public void AddAccount() 
        {
            AddAccountWindow addAccountWindow = new AddAccountWindow(this.LoadedClient);
            addAccountWindow.ShowDialog();
            this.AccountList.Add(addAccountWindow.Account);

            this.repository.LoadClientsIntoFile();
        }

        public void RemoveAccount(int selectedIndex)
        {
            this.LoadedClient.RemoveAccount(this.AccountList[selectedIndex]);
            this.AccountList.Remove(this.AccountList[selectedIndex]);
            this.repository.LoadClientsIntoFile();
        }

        public void StartTransactionMain()
        {
            TransactionWindow transactionWindow = new TransactionWindow(this.LoadedClient);
            transactionWindow.ShowDialog();
            this.repository.LoadClientsIntoFile();
        }

        public void StartTransactionOther()
        {
            TransactionWindow transactionWindow = new TransactionWindow(this.LoadedClient, this.ClientList);
            transactionWindow.ShowDialog();
            this.repository.LoadClientsIntoFile();
        }

        private void FillAccountList()
        {
            this.AccountList = new ObservableCollection<Account<decimal, decimal>>();
            if (this.LoadedClient.DepositAccount != null)
            {
                this.AccountList.Add(this.LoadedClient.DepositAccount);
            }
            if (this.LoadedClient.NonDepositAccount != null)
            {
                this.AccountList.Add(this.LoadedClient.NonDepositAccount);
            }
        }
    }
}
