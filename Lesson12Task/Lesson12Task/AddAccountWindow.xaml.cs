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
        public AccountNonDeposit Account { get; set; }
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

        private void Button_Save(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(TextBoxAmount.Text, out double amount))
            {
                if (amount < 0)
                {
                    MessageBox.Show("Сумма на счете не может быть отрицательной!");
                } 
                else
                {
                    this.Account = new AccountNonDeposit(amount, this.client.Id);
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Введите корректную сумму в поле \"Начальная Сумма\"");
            }
        }
    }
}
