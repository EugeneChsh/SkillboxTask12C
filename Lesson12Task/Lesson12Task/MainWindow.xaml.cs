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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lesson12Task
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Repository repository;
        public MainWindow()
        {
            InitializeComponent();
            this.repository = new Repository();
            DataContext = this.repository;
        }

        private void Button_AddClient(object sender, RoutedEventArgs e)
        {
            this.repository.AddClient();
        }

        private void Button_AccountManagement(object sender, RoutedEventArgs e)
        {
            if (DataGridClients.SelectedItem != null)
            {
                int selectedIndex = DataGridClients.SelectedIndex;
                this.repository.StartAccountManagement(selectedIndex);
            } else
            {
                MessageBox.Show("Выберите клиента!");
            }
        }
        
        void Button_DeleteClient(object sender, RoutedEventArgs e)
        {
            if (DataGridClients.SelectedItem != null)
            {
                int selectedIndex = DataGridClients.SelectedIndex;
                this.repository.RemoveClient(selectedIndex);
            }
        }
    }
}
