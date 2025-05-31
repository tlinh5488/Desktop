using System;
using System.Windows;
using System.Windows.Controls;

namespace Calculator
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(txtOp1.Text);
                int num2 = Convert.ToInt32(txtOp2.Text);
                int answer = num1 + num2;
                txtAns.Text = answer.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input! Please enter integers.");
            }
        }

        private void btnSubtract_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(txtOp1.Text);
                int num2 = Convert.ToInt32(txtOp2.Text);
                int answer = num1 - num2;
                txtAns.Text = answer.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input! Please enter integers.");
            }
        }

        private void chkCenter_Checked(object sender, RoutedEventArgs e)
        {
            bool isChecked = (bool)chkCenter.IsChecked;
            var alignment = isChecked ? TextAlignment.Center : TextAlignment.Left;

            txtOp1.TextAlignment = alignment;
            txtOp2.TextAlignment = alignment;
            txtAns.TextAlignment = alignment;
        }
    }
}
