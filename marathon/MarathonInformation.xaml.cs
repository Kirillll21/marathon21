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
    /// Логика взаимодействия для MarathonInformation.xaml
    /// </summary>
    public partial class MarathonInformation : Window
    {
        public MarathonInformation()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddInformation addInformation = new AddInformation();
            addInformation.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            image image = new image();
            image.Show();
            this.Hide();
        }
    }
}
