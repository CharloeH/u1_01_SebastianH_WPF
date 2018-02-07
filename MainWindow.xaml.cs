/*Sebastian Horton
 * Tuesday Febuary 6th, 2018 
 * u1_01_Sebastian_WPF 
 * Hello World - my first program*/
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

namespace u1_01_SebastianH_WPF
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

        private void btnClickMe_Click(object sender, RoutedEventArgs e)
        {
            lblOutput.Content = "naistsabeS si eman my ,dlroW olleH ";
        }

        private void btnClickMe2_Click(object sender, RoutedEventArgs e)
           
        {
            lblOutput.Content = "Hello World, my name is Sebastian";
        }
    }
}
