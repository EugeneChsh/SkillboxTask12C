using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
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
    /// Логика взаимодействия для AccountFormWindow.xaml
    /// </summary>
    public partial class AccountFormWindow : Window
    {
        public AccountRepository accountRepository;
        
        public AccountFormWindow(ObservableCollection<Client> _clientList, int _clientIndex, Repository _repository)
        {
            InitializeComponent();
            this.accountRepository = new AccountRepository(_clientList, _clientIndex, _repository);
            LabelOwnerFIO.Content = ($"ФИО Владельца: {this.accountRepository.LoadedClient.FIO}");
            DataContext = this.accountRepository;
        }

        private void Button_AddAccount(object sender, RoutedEventArgs e)
        {
            this.accountRepository.AddAccount();
        }
        
        private void Button_RemoveAccount(object sender, RoutedEventArgs e)
        {
            int selectedIndex = DataGridAccounts.SelectedIndex;
            this.accountRepository.RemoveAccount(selectedIndex);
        }

        private void Button_StartTransactionMain(object sender, RoutedEventArgs e)
        {
            this.accountRepository.StartTransactionMain();
            DataGridAccounts.Items.Refresh();
        }

        private void Button_StartTransactionOther(object sender, RoutedEventArgs e)
        {
            this.accountRepository.StartTransactionOther();
            DataGridAccounts.Items.Refresh();
        }

        private void Button_Return(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
