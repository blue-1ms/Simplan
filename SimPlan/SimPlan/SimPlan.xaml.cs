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

namespace SimPlan
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



        private void Click_New(object sender, RoutedEventArgs e)
        {
            NewPlan Simplan = new NewPlan();
            this.Visibility = Visibility.Hidden;
            Simplan.Show();


        }

        private void Click_Prev(object sender, RoutedEventArgs e)
        {
            PreviousPlan Simplan = new PreviousPlan();
            this.Visibility = Visibility.Hidden;
            Simplan.Show();
        }


    }
}
