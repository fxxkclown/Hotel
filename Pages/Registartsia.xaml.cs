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

namespace Hotel.Pages
{
    /// <summary>
    /// Логика взаимодействия для Registartsia.xaml
    /// </summary>
    public partial class Registartsia : Page
    {
        public Registartsia()
        {
            InitializeComponent();
        }

        private void reg_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ваша заявка на регистрацию отправлена на проверку менеджеру ");
        }

        private void Avt_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Avtoriz());
        }
    }
}
