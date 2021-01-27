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

namespace Demo_Wpf_SwapImages
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            InitializeWindow();
        }

        private void InitializeWindow()
        {
            RadioButton_Dog.IsChecked = true;
        }

        private void ImageChoice_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            string imageChoice = radioButton.Name;

            switch (imageChoice)
            {
                case "RadioButton_Dog":
                    Image.Source = new BitmapImage(new Uri(@"/Images/dog.jpg", UriKind.Relative));
                    break;

                case "RadioButton_Cat":
                    Image.Source = new BitmapImage(new Uri(@"/Images/cat.jpg", UriKind.Relative));
                    break;

                case "RadioButton_Fish":
                    Image.Source = new BitmapImage(new Uri(@"/Images/fish.jpg", UriKind.Relative));
                    break;

                default:
                    throw new Exception("Unknown Image Choice");
            }
        }
    }
}
