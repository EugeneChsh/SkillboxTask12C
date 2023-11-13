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
using System.Windows.Shapes;

namespace Lesson12Task
{
    /// <summary>
    /// Логика взаимодействия для AddAccountWindow.xaml
    /// </summary>
    public partial class AddAccountWindow : Window
    {
        private Client client;
        public Account<decimal, decimal> Account { get; set; }
        private Boolean isDepositAccount = false;

        public AddAccountWindow()
        {
            InitializeComponent();
        }

        public AddAccountWindow(Client _client)
        {
            InitializeComponent();
            this.client = _client;
            LabelOwnerFIO.Content = ($"ФИО Владельца: {this.client.FIO}");
        }

        // очень длинный метод, аж самому не по себе, правда
        private void Button_Save(object sender, RoutedEventArgs e)
        {
            if (decimal.TryParse(TextBoxAmount.Text, out decimal balance))
            {
                if (balance < 0)
                {
                    MessageBox.Show("Сумма на счете не может быть отрицательной!");
                } 
                else
                {
                    if (isDepositAccount)
                    {
                        if (this.client.DepositAccount == null)
                        {
                            this.Account = new DepositAccount<decimal, decimal>(balance, this.client.Id, "депозитный", true);
                            this.client.DepositAccount = (DepositAccount<decimal, decimal>)this.Account;
                        }
                        else
                        {
                            MessageBox.Show("Депозитный счет уже создан");
                        }
                    } 
                    else
                    {
                        if (this.client.NonDepositAccount == null)
                        {
                            this.Account = new NonDepositAccount<decimal, decimal>(balance, this.client.Id, "недепозитный", false);
                            this.client.NonDepositAccount = (NonDepositAccount<decimal, decimal>)this.Account;
                        }
                        else
                        {
                            MessageBox.Show("Недепозитный счет уже создан");
                        }
                    }
                    
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Введите корректную сумму в поле \"Начальная Сумма\"");
            }
        }

        private void RadioButtonNonDeposit_Click(object sender, RoutedEventArgs e)
        {
            isDepositAccount = false;
        }

        private void RadioButtonDeposit_Click(object sender, RoutedEventArgs e)
        {
            isDepositAccount = true;
        }
    }
}
