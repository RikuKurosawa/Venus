﻿using System;
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
    /// Page5.xaml の相互作用ロジック
    /// </summary>
    public partial class Page5 : Page
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
            var page6 = new Page6();
            NavigationService.Navigate(page6);//ここでページ移動
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var page2 = new Page2();
            NavigationService.Navigate(page2);//ここでページ移動
        }
    }
}
