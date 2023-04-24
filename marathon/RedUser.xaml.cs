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
    /// Логика взаимодействия для RedUser.xaml
    /// </summary>
    public partial class RedUser : Window
    {
        public RedUser()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InformationB informationB = new InformationB();
            informationB.Show();
            this.Hide();
        }
    }
}
