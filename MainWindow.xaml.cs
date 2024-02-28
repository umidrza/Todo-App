using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Todo_App
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string todoText = todoInput.Text;

            if (!string.IsNullOrEmpty(todoText))
            {
                TextBlock todoItem = new TextBlock
                {
                    Text = todoText,
                    Margin = new Thickness(10),
                    Foreground = new SolidColorBrush(Colors.White),
                };

                todoList.Children.Add(todoItem);

                todoInput.Clear();
            }
        }
    }
}
