using System.Collections.Generic;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace Wpf_Application
{
    //==================================================================================================================================================================================================
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    //public partial class MainWindow : Window
    //{
    //    public Sum SumObj { get; set; }

    //    public MainWindow()
    //    {
    //        InitializeComponent();

    //        #region Test

    //        //Grid grid = new Grid();  
    //        //this.Content = grid;  // содержимое окна 

    //        //Button button = new Button();
    //        //button.FontSize = 26;

    //        //WrapPanel wrapPanel = new WrapPanel();

    //        //TextBlock textBlock = new TextBlock();
    //        //textBlock.Text = "Multi";
    //        //textBlock.Foreground = Brushes.Blue;
    //        //wrapPanel.Children.Add(textBlock);

    //        //textBlock = new TextBlock();
    //        //textBlock.Text = "Color";
    //        //textBlock.Foreground = Brushes.Red;
    //        //wrapPanel.Children.Add(textBlock);

    //        //textBlock = new TextBlock();
    //        //textBlock.Text = "Button";
    //        //textBlock.Foreground = Brushes.White;
    //        //wrapPanel.Children.Add(textBlock);

    //        //button.Content = wrapPanel;
    //        //grid.Children.Add(button);

    //        #endregion

    //        #region BindingText

    //        //SumObj = new Sum { Num1 = "1", Num2 = "3" };
    //        //this.DataContext = SumObj;

    //        #endregion

    //        List<Match> matches = new List<Match>() {
    //            new Match { Team1 = "Bayern Munich", Team2 = "Real Madrid", Score1 = 3, Score2 = 2, Completion = 85 },
    //            new Match { Team1 = "PSG", Team2 = "Barca", Score1 = 3, Score2 = 2, Completion = 50 },
    //            new Match { Team1 = "BVB Dortmund", Team2 = "AS Roma", Score1 = 0, Score2 = 1, Completion = 25 },
    //            new Match { Team1 = "Man United", Team2 = "La Galaxt", Score1 = 1, Score2 = 1, Completion = 35 }
    //        };

    //        lbMatches.ItemsSource = matches;
    //    }

    //    #region RoutedEvents

    //    //private void Button_Click_1(object sender, RoutedEventArgs e)
    //    //{
    //    //    // По клику на копку в дизайнере создастся метод обработки события
    //    //    MessageBox.Show("tHANKS FOR Click ME! - Direct Event");
    //    //}

    //    //private void Button_MouseUp(object sender, MouseButtonEventArgs e)
    //    //{
    //    //    MessageBox.Show("MouseUp - Bubbling Event");
    //    //}

    //    //private void Button_PreviewMouseUp(object sender, MouseButtonEventArgs e)
    //    //{
    //    //    MessageBox.Show("PreviewMouseUp - Tunnel Event");
    //    //}

    //    #endregion

    //    private void Button_Click(object sender, RoutedEventArgs e)
    //    {
    //        if(lbMatches.SelectedItem != null)
    //        {
    //            MessageBox.Show("Selected Match: " + (lbMatches.SelectedItem as Match).Team1 + " " 
    //                + (lbMatches.SelectedItem as Match).Score1 + " " 
    //                + (lbMatches.SelectedItem as Match).Team2 + " " 
    //                + (lbMatches.SelectedItem as Match).Score2 + " ");
    //        }
    //    }
    //}

    //class Match
    //{
    //    public int Score1 { get; set; }
    //    public int Score2 { get; set; }
    //    public string Team1 { get; set; }
    //    public string Team2 { get; set; }
    //    public int Completion { get; set; }

    //}

    //=================================================================================================================================================================================================
    // Комбобокс с цветами Color

    //public partial class MainWindow : Window
    //{
    //    public MainWindow()
    //    {
    //        InitializeComponent();

    //        comboBoxColors.ItemsSource = typeof(Colors).GetProperties();
    //    }
    //}

    //=================================================================================================================================================================================================

    //public partial class MainWindow : Window
    //{
    //    delegate void CheckStatenment();
    //    event CheckStatenment IsAll;

    //    public MainWindow()
    //    {
    //        InitializeComponent();

    //        IsAll += CheckIsAll;
    //    }

    //    private void checkBoxAll_CheckedChanged(object sender, RoutedEventArgs e)
    //    {
    //        bool vlaue = (bool)cbAllTopings.IsChecked;
    //        cbSalami.IsChecked = vlaue;
    //        cbMushrooms.IsChecked = vlaue;
    //        cbMozzarella.IsChecked = vlaue;
    //    }

    //    private void checkBoxSingle_CheckedChanged(object sender, RoutedEventArgs e)
    //    {
    //        cbAllTopings.IsChecked = null;
    //        IsAll.Invoke();
    //    }

    //    private void CheckIsAll ()
    //    {
    //        if((bool)cbSalami.IsChecked && (bool)cbMushrooms.IsChecked && (bool)cbMozzarella.IsChecked)
    //        {
    //            cbAllTopings.IsChecked = true;
    //        }
    //        else if((bool)cbSalami.IsChecked || (bool)cbMushrooms.IsChecked || (bool)cbMozzarella.IsChecked)
    //        {
    //            cbAllTopings.IsChecked = null;
    //        }
    //        else
    //        {
    //            cbAllTopings.IsChecked = false;
    //        }
    //    }
    //}

    //=================================================================================================================================================================================================

    //public partial class MainWindow : Window
    //{
    //    delegate void CheckStatenment();
    //    event CheckStatenment IsAll;

    //    public MainWindow()
    //    {
    //        InitializeComponent();


    //    }

    //    private void RadioButton_Checked(object sender, RoutedEventArgs e)
    //    {
    //        MessageBox.Show("Please say Yes");
    //    }
    //}

    //=================================================================================================================================================================================================

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
    }
}
