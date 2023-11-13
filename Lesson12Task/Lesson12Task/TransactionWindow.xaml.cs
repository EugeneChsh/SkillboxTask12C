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
        public ObservableCollection<AccountNonDeposit> LoadedAccountList { get; set; }
        public ObservableCollection<AccountNonDeposit> SecondAccountList { get; set; }

        private AccountNonDeposit selectedAccountForMinus;
        private AccountNonDeposit selectedAccountForTransaction;

        public TransactionWindow(ObservableCollection<AccountNonDeposit> _accountList)
        {
            InitializeComponent();
            this.LoadedAccountList = _accountList;
            SecondAccountList = new ObservableCollection<AccountNonDeposit>();
            DataContext = this;
        }

        private void ComboBox_AccountForMinusChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxAccountForMinus.SelectedItem != null)
            {
                this.selectedAccountForMinus = (AccountNonDeposit)ComboBoxAccountForMinus.SelectedItem;
                FillSecondAccountListForTransaction();
            }
        }

        private void ComboBox_AccountForTransactionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ComboBoxAccountForTransaction.SelectedItem != null)
            {
                this.selectedAccountForTransaction = (AccountNonDeposit)ComboBoxAccountForTransaction.SelectedItem;

            }
        }

        private void Button_DoTransaction(object sender, RoutedEventArgs e)
        {
            string vaueForTransaction = TextBoxTransactionSumm.Text;
            if (double.TryParse(vaueForTransaction, out double transactionSum))
            {
                if (this.selectedAccountForMinus.Ammount - transactionSum < 0)
                {
                    MessageBox.Show("Недостаточно средств на счете!");
                } 
                else
                {
                    for (int i = 0; i < this.LoadedAccountList.Count; i++)
                    {
                        if (this.LoadedAccountList[i].AccountNumber == this.selectedAccountForMinus.AccountNumber)
                        {
                            this.LoadedAccountList[i].Ammount = this.LoadedAccountList[i].Ammount - transactionSum;
                            Console.WriteLine("this.selectedKeyForMinus: " + this.LoadedAccountList[i].Ammount);
                            continue;
                        }
                        if (this.LoadedAccountList[i].AccountNumber == this.selectedAccountForTransaction.AccountNumber)
                        {
                            this.LoadedAccountList[i].Ammount = this.LoadedAccountList[i].Ammount + transactionSum;
                            Console.WriteLine("this.selectedKeyForMinus: " + this.LoadedAccountList[i].Ammount);
                            continue;
                        }
                    }

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
            foreach (AccountNonDeposit account in this.LoadedAccountList)
            {
                if (account.AccountNumber != selectedAccountForMinus.AccountNumber)
                {
                    this.SecondAccountList.Add(account);
                }
            }
        }
    }
}
