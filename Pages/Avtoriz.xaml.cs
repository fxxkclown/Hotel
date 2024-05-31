using Hotel.ApplicationData;
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
    /// Логика взаимодействия для Avtoriz.xaml
    /// </summary>
    public partial class Avtoriz : Page
    {
        public Avtoriz()
        {
            InitializeComponent();
        }

        private void Avtorizatsia_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = Entities.GetContext().user.FirstOrDefault(x => x.login == Login.Text && x.password == Password.Text);
                if (userObj == null)
                {
                    MessageBox.Show("Такого пользователя нет!", "Ошибка авторизации!", MessageBoxButton.OK, MessageBoxImage.Error);

                }

                else
                {
                    switch (userObj.userroleid)
                    {
                        case 1:
                            MessageBox.Show("Здравствуйте, Сотрудник обслуживания номеров " + userObj.firstname + "!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                            Manager.MainFrame.Navigate(new SotrydnikObslyzNomer());
                            break;

                        case 2:
                            MessageBox.Show("Здравствуйте, Менеджер " + userObj.firstname + "!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                            Manager.MainFrame.Navigate(new ManagerPage());
                            break;

                        case 3:
                            MessageBox.Show("Здравствуйте, Сотрудник предоставления услуг отеля " + userObj.firstname + "!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                            Manager.MainFrame.Navigate(new SotrydnikYslygiOtela());
                            break;
                        default:
                            MessageBox.Show("Данные не обнаружены!");
                            break;
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ошибка" + Ex.Message.ToString() + "Критическая ошибка", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new Registartsia());
        }
    }
}
