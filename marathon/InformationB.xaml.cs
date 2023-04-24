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

namespace marathon
{
    /// <summary>
    /// Логика взаимодействия для InformationB.xaml
    /// </summary>
    public partial class InformationB : Window
    {
        public InformationB()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            RedUser redUser = new RedUser();
            redUser.Show();
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MyResults myResults = new MyResults();
            myResults.Show();
            this.Hide();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            RegMarathon regMarathon = new RegMarathon();
            regMarathon.Show();
            this.Hide();
        }
    }
}
