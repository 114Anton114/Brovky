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
    /// Логика взаимодействия для PageAvtorization.xaml
    /// </summary>
    public partial class PageAvtorization : Page
    {
        public PageAvtorization()
        {
            InitializeComponent();
        }

        private void BtnAdmin_Click(object sender, RoutedEventArgs e)
        {
            FrmNavigationClass.frameNavigate.Navigate(new PageLogin());

        }

        private void BtnUser_Click(object sender, RoutedEventArgs e)
        {
            FrmNavigationClass.frameNavigate.Navigate(new PageUser());
        }
    }
}
