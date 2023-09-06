using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;

namespace Wpf_Application
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Sum SumObj { get; set; }

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

            #region BindingText

            //SumObj = new Sum { Num1 = "1", Num2 = "3" };
            //this.DataContext = SumObj;

            #endregion

            List<Match> matches = new List<Match>
            {
                new Match { Team1 = "Bayern Munich", Team2 = "Real Madrid", Score1 = 3, Score2 = 2, Completion = 85 }
            };

            lbMatches.ItemsSource = matches;
        }

        #region RoutedEvents

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // По клику на копку в дизайнере создастся метод обработки события
            MessageBox.Show("tHANKS FOR Click ME! - Direct Event");
        }

        private void Button_MouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("MouseUp - Bubbling Event");
        }

        private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("PreviewMouseUp - Tunnel Event");
        }

        #endregion


    }

    class Match
    {
        public int Score1 { get; set; }
        public int Score2 { get; set; }
        public string Team1 { get; set; }
        public string Team2 { get; set; }
        public int Completion { get; set; }

    }
}
