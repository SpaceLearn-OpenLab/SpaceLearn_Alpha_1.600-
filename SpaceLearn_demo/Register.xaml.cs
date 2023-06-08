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
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;
using System.Windows.Media.Animation;

namespace SpaceLearn_demo
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>

    
    public partial class Register : Window 
    {

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Submit(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Local;Initial Catalog=LRDATABASE;Integrated Security=True");
                con.Open();
                string add_data = "INSERT INTO user2(username, password) VALUES(@username,@password);"; //"SELECT * FROM [dbo].[user] where username=@username and password=@password";
                if(username.Text != "" && password.Password != "" && password1.Password != "")
                {
                    SqlCommand cmd = new SqlCommand(add_data, con);
                    cmd.Parameters.AddWithValue("@username", username.Text);
                    cmd.Parameters.AddWithValue("@password", password.Password);

                    if(password.Password == password1.Password)
                    {
                        if(password.Password.Length > 3 && password1.Password.Length > 3 && username.Text.Length > 3)
                        {
                            cmd.ExecuteNonQuery();
                            con.Close();

                            username.Text = "";
                            password.Password = "";
                            password1.Password = "";

                            MainWindow mw = new MainWindow();
                            this.Close();
                            mw.Show();
                        }
                        else
                        {
                            MessageBox.Show("Your username or passwords are too short");
                            username.BorderBrush = Brushes.Red;
                            password.BorderBrush = Brushes.Red;
                            password1.BorderBrush = Brushes.Red;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Passwords are not matching");
                        username.BorderBrush = Brushes.Red;
                        password.BorderBrush = Brushes.Red;
                        password1.BorderBrush = Brushes.Red;
                    }
                }
                else
                {
                    MessageBox.Show("Your passwords are not matching or your username is invalid");
                    username.BorderBrush = Brushes.Red;
                    password.BorderBrush = Brushes.Red;
                    password1.BorderBrush = Brushes.Red;
                }
            }
            catch
            {

            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var afterregister = new MainWindow();
            afterregister.Show();
            this.Close();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {

        }
    }
}
