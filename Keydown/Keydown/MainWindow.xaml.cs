using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Keydown
{
        public partial class MainWindow : Window
        {
            public MainWindow()
            {
                InitializeComponent();
            }

            private void Grid_KeyDown(object sender, KeyEventArgs e)
            {
                MessageBox.Show("Grid handler, bubbling up");
            }

            private void Grid_PreviewKeyDown(object sender, KeyEventArgs e)
            {
                MessageBox.Show("Grid handler, tunneling down");
                e.Handled = true; // CHẶN không cho sự kiện đi tiếp
            }

            private void rotatedButton_KeyDown(object sender, KeyEventArgs e)
            {
                MessageBox.Show("rotatedButton handler, bubbling up");
            }

            private void rotatedButton_PreviewKeyDown(object sender, KeyEventArgs e)
            {
                MessageBox.Show("rotatedButton handler, tunneling down");
            }

            private void Window_KeyDown(object sender, KeyEventArgs e)
            {
                MessageBox.Show("Window handler, bubbling up");
            }

            private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
            {
                MessageBox.Show("Window handler, tunneling down");
            }
        }
    }

