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

namespace SpaceLearn_demo
{
    /// <summary>
    /// Interaction logic for QuizzMenu.xaml
    /// </summary>
    public partial class QuizzMenu : Window
    {
        public QuizzMenu()
        {
            InitializeComponent();
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            Button1.Background = Brushes.Gray;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            Button1.Background = Brushes.Transparent;
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            var QuizzMenu = new Quizz();
            QuizzMenu.Show();
            this.Close();
        }
    }
}
