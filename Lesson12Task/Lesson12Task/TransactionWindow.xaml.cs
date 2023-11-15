using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Lesson12Task
{
    /// <summary>
    /// Логика взаимодействия для TransactionWindow.xaml
    /// </summary>
    public partial class TransactionWindow : Window
    {
        private Client LoadedClient;

        ObservableCollection<Client> ClientList;
        public ObservableCollection<Account<decimal, decimal>> FirstAccountList { get; set; }
        public ObservableCollection<Account<decimal, decimal>> SecondAccountList { get; set; }

        private Account<decimal, decimal> selectedAccountForMinus;
        private Account<decimal, decimal> selectedAccountForPlus;

        /// <summary>
        /// Для транзакций между своими счетами
        /// </summary>
        /// <param name="_LoadedClient"></param>
        public TransactionWindow(Client _LoadedClient)
        {
            InitializeComponent();
            this.SecondAccountList = new ObservableCollection<Account<decimal, decimal>>();
            this.LoadedClient = _LoadedClient;
            FillAccountList();
            DataContext = this;
        }

        /// <summary>
        /// Для транзакций между клиентами
        /// </summary>
        /// <param name="_LoadedClient"></param>
        /// <param name="_clientList"></param>
        public TransactionWindow(Client _LoadedClient, ObservableCollection<Client> _clientList)
        {
            InitializeComponent();
            this.SecondAccountList = new ObservableCollection<Account<decimal, decimal>>();
            this.ClientList = _clientList;
            this.LoadedClient = _LoadedClient;
            FillAccountListOther();
            DataContext = this;
        }

        private void ComboBox_AccountForMinusChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxAccountForMinus.SelectedItem != null)
            {
                this.selectedAccountForMinus = (Account<decimal, decimal>)ComboBoxAccountForMinus.SelectedItem;
                FillSecondAccountListForTransaction();
            }
        }

        private void ComboBox_AccountForTransactionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxAccountForTransaction.SelectedItem != null)
            {
                this.selectedAccountForPlus = (Account<decimal, decimal>)ComboBoxAccountForTransaction.SelectedItem;

            }
        }

        private void Button_DoTransaction(object sender, RoutedEventArgs e)
        {
            string vaueForTransaction = TextBoxTransactionSumm.Text;
            if (decimal.TryParse(vaueForTransaction, out decimal transactionSum))
            {
                if (this.selectedAccountForMinus.Balance - transactionSum < 0)
                {
                    MessageBox.Show("Недостаточно средств на счете!");
                }
                else
                {
                    this.selectedAccountForMinus.Deposit(transactionSum * -1);
                    this.selectedAccountForPlus.Deposit(transactionSum);

                    Close();
                }
            }
            else
            {
                MessageBox.Show("Введите сумму корректно");
            }
        }

        private void FillSecondAccountListForTransaction()
        {
            foreach (Account<decimal, decimal> account in this.FirstAccountList)
            {
                if (account.AccountNumber != selectedAccountForMinus.AccountNumber)
                {
                    this.SecondAccountList.Add(account);
                }
            }
        }

        private void FillAccountList()
        {
            this.FirstAccountList = new ObservableCollection<Account<decimal, decimal>>();
            if (this.LoadedClient.DepositAccount != null)
            {
                this.FirstAccountList.Add(this.LoadedClient.DepositAccount);
            }
            if (this.LoadedClient.NonDepositAccount != null)
            {
                this.FirstAccountList.Add(this.LoadedClient.NonDepositAccount);
            }
        }

        private void FillAccountListOther()
        {
            this.FirstAccountList = new ObservableCollection<Account<decimal, decimal>>();
            if (this.LoadedClient.NonDepositAccount != null)
            {
                this.FirstAccountList.Add(this.LoadedClient.NonDepositAccount);
            }

            foreach (Client client in this.ClientList)
            {
                if (client.NonDepositAccount != null && this.FirstAccountList[0].AccountNumber != client.NonDepositAccount.AccountNumber)
                {
                    this.SecondAccountList.Add(client.NonDepositAccount);
                }
            }
        }
    }
}
