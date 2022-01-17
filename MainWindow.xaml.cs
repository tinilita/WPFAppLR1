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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            string s = inputTextBox.Text;
            double x;
            if (double.TryParse(s, out x))
            {
                 x = Math.Sqrt(x);
                string str =Convert.ToString(x);
                inputTextBox.Text = str;
               // inputTextBox.Text = "You entered the valid integer {0}, x";
            }
            else
            {
                MessageBox.Show("Invalid input!");
            }
        }
    }
}
