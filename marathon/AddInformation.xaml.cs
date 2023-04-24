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
    /// Логика взаимодействия для AddInformation.xaml
    /// </summary>
    public partial class AddInformation : Window
    {
        public AddInformation()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MarathonInformation marathonInformation = new MarathonInformation();
            marathonInformation.Show();
            this.Hide();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SponsorList sponsorList = new SponsorList();
            sponsorList.Show();
            this.Hide();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            ResRace resRace = new ResRace();
            resRace.Show();
            this.Hide();
        }
    }
}
