using Brovky.NvgPage;
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

namespace Brovky.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (PsbLogin.Password == "0000")
                {
                    MessageBox.Show("Информация корректна. Вход в режим Администратора активен.", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                    FrmNavigationClass.frameNavigate.Navigate(new PageAdmin());
                }
                else
                {
                    MessageBox.Show("Информация НЕ корректна. Вход в режим Администратора не выполним!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
