using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Local;Initial Catalog=LRDATABASE;Integrated Security=True");
                con.Open();
                string add_data = "SELECT * FROM user2 where username=@username and password=@password"; //"SELECT * FROM [dbo].[user] where username=@username and password=@password";
                SqlCommand cmd = new SqlCommand(add_data, con);
                cmd.Parameters.AddWithValue("@username", username.Text);
                cmd.Parameters.AddWithValue("@password", password.Password);
                cmd.ExecuteNonQuery();

                var a = cmd.ExecuteScalar();

                //int Count = Convert.ToInt32(cmd.ExecuteScalar());

                con.Close();

                username.Text = "";
                password.Password = "";
                if(a != null)
                {
                    MainWindow mw = new MainWindow();
                    this.Close();
                    mw.Show();
                }
                else
                {

                    MessageBox.Show("Your password or username is incorrect");
                    username.BorderBrush = Brushes.Red;
                    password.BorderBrush = Brushes.Red;

                }
            }
               
            catch
            {

            }

        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            var Login = new MainWindow();
            Login.Show();
            this.Close();
            
        }

        private void Button_Register(object sender, RoutedEventArgs e)
        {
            var Register = new Register();
            Register.Show();
            this.Close();
        }
    }
}
