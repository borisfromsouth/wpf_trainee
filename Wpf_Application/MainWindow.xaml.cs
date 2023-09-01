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

namespace Wpf_Application
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            #region Test

            //Grid grid = new Grid();  
            //this.Content = grid;  // содержимое окна 

            //Button button = new Button();
            //button.FontSize = 26;

            //WrapPanel wrapPanel = new WrapPanel();

            //TextBlock textBlock = new TextBlock();
            //textBlock.Text = "Multi";
            //textBlock.Foreground = Brushes.Blue;
            //wrapPanel.Children.Add(textBlock);

            //textBlock = new TextBlock();
            //textBlock.Text = "Color";
            //textBlock.Foreground = Brushes.Red;
            //wrapPanel.Children.Add(textBlock);

            //textBlock = new TextBlock();
            //textBlock.Text = "Button";
            //textBlock.Foreground = Brushes.White;
            //wrapPanel.Children.Add(textBlock);

            //button.Content = wrapPanel;
            //grid.Children.Add(button);

            #endregion


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // По клику на копку в дизайнере создастся метод обработки события
            MessageBox.Show("tHANKS FOR Click ME!");
        }
    }
}
