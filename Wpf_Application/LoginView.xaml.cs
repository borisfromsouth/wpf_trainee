using System.Windows;
using System.Windows.Controls;

namespace Wpf_Application
{
    /// <summary>
    /// Логика взаимодействия для LoginView.xaml
    /// </summary>
    public partial class LoginView : UserControl
    {
        public LoginView()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // подмена содержимого главного окна на пользовательский view
            Window window = Window.GetWindow(this);
            window.Content = new InvoiceView();
        }
    }
}
