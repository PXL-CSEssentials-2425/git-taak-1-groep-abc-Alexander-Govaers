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

namespace Git_taak_1
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



        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            //this.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF0000"));

            Color colour = (Color)ColorConverter.ConvertFromString("#FF0000");
            this.Background = new SolidColorBrush(colour);


        }

        private void Image_MouseEnter_1(object sender, MouseEventArgs e)
        {
            Color colour = (Color)ColorConverter.ConvertFromString("#FFFF00");
            this.Background = new SolidColorBrush(colour);
        }

        private void Image_MouseEnter_2(object sender, MouseEventArgs e)
        {
            Color colour = (Color)ColorConverter.ConvertFromString("#008000");
            this.Background = new SolidColorBrush(colour);
        }

        private void Image_MouseEnter_3(object sender, MouseEventArgs e)
        {
            Color colour = (Color)ColorConverter.ConvertFromString("#0000FF");
            this.Background = new SolidColorBrush(colour);

        }
    }
}
