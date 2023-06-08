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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SpaceLearn_demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void arrow_Click(object sender, RoutedEventArgs e)
        {
            text01.Visibility= Visibility.Collapsed;
            text02.Visibility= Visibility.Collapsed;
            text03.Visibility= Visibility.Collapsed;
            text04.Visibility= Visibility.Collapsed;
            text05.Visibility= Visibility.Collapsed;
            text06.Visibility= Visibility.Collapsed;
            
            dart.Visibility= Visibility.Collapsed;

            second.Visibility = Visibility.Visible;

        }

        private void BTN_01_Click(object sender, RoutedEventArgs e)
        {

        }

        private void arrowbtn1_Click(object sender, RoutedEventArgs e)
        {
            second.Visibility= Visibility.Collapsed;

            dart.Visibility = Visibility.Visible;
            text01.Visibility= Visibility.Visible;
            text02.Visibility= Visibility.Visible;
            text03.Visibility= Visibility.Visible;
            text04.Visibility= Visibility.Visible;
            text05.Visibility= Visibility.Visible;
            text06.Visibility= Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var MainWindow = new QuizzMenu();
            MainWindow.Show();
            this.Close();
        }
    }
}
