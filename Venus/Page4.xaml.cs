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

namespace Venus
{
    /// <summary>
    /// Page4.xaml の相互作用ロジック
    /// </summary>
    public partial class Page4 : Page
    {
        public Page4()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            var page5 = new Page5();
            NavigationService.Navigate(page5);//ここでページ移動
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var page8 = new Page8();
            NavigationService.Navigate(page8);//ここでページ移動
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var page2 = new Page2();
            NavigationService.Navigate(page2);//ここでページ移動
        }
    }
}
