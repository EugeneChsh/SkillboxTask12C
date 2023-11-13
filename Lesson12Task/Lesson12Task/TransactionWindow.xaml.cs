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
        public ObservableCollection<Account<decimal, decimal>> FirstAccountList { get; set; }
        public ObservableCollection<Account<decimal, decimal>> SecondAccountList { get; set; }

        private Account<decimal, decimal> selectedAccountForMinus;
        private Account<decimal, decimal> selectedAccountForPlus;

        public TransactionWindow(Client _LoadedClient)
        {
            InitializeComponent();
            this.SecondAccountList = new ObservableCollection<Account<decimal, decimal>>();
            this.LoadedClient = _LoadedClient;
            FillAccountList();
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

                    //for (int i = 0; i < this.LoadedAccountList.Count; i++)
                    //{
                    //    if (this.LoadedAccountList[i].AccountNumber == this.selectedAccountForMinus.AccountNumber)
                    //    {
                    //        this.LoadedAccountList[i].Ammount = this.LoadedAccountList[i].Ammount - transactionSum;
                    //        Console.WriteLine("this.selectedKeyForMinus: " + this.LoadedAccountList[i].Ammount);
                    //        continue;
                    //    }
                    //    if (this.LoadedAccountList[i].AccountNumber == this.selectedAccountForTransaction.AccountNumber)
                    //    {
                    //        this.LoadedAccountList[i].Ammount = this.LoadedAccountList[i].Ammount + transactionSum;
                    //        Console.WriteLine("this.selectedKeyForMinus: " + this.LoadedAccountList[i].Ammount);
                    //        continue;
                    //    }
                    //}

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
    }
}
