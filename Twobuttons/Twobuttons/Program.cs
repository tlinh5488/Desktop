using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media; 

namespace TwoControls
{
    class TwoControls : Window
    {
        private TextBox txtName;
        private const int MARGINSIZE = 10;

        [STAThread]
        static void Main(string[] args)
        {
            Application app = new Application();
            app.Run(new TwoControls());
        }

        public TwoControls()
        {
            Title = "Demo Hai Điều Khiển";
            Width = 288;

            // Tạo StackPanel
            StackPanel panel = new StackPanel();
            Content = panel;
            panel.Background = Brushes.Beige;
            panel.Margin = new Thickness(MARGINSIZE);

            // TextBox
            txtName = new TextBox();
            txtName.FontSize = 16;
            txtName.HorizontalAlignment = HorizontalAlignment.Center;
            txtName.Width = Width / 2;
            txtName.Margin = new Thickness(MARGINSIZE);
            panel.Children.Add(txtName);

            // Button
            Button btnGreet = new Button();
            btnGreet.Content = "Chào";
            btnGreet.FontSize = 16;
            btnGreet.HorizontalAlignment = HorizontalAlignment.Center;
            btnGreet.Margin = new Thickness(MARGINSIZE);
            btnGreet.Click += ButtonOnClick;
            panel.Children.Add(btnGreet);

            // Tự động điều chỉnh chiều cao
            SizeToContent = SizeToContent.Height;
        }

        void ButtonOnClick(object sender, RoutedEventArgs args)
        {
            MessageBox.Show("Hé Lô cục cưng, " + txtName.Text, "Lời chào");
        }
    }
}
