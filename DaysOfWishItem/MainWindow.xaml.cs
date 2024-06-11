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

namespace DaysOfWishItem
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

        private void Calculate(object sender, RoutedEventArgs e)
        {
            float income = float.Parse(txtIncome.Text);
            float expenses = float.Parse(txtExpenses.Text);
            if (expenses > income)
            {
                MessageBox.Show("รายจ่ายของคุณไม่ควรมากกว่ารายได้!!!");
                return;
            }
            float price = float.Parse(txtPrice.Text);
            int days = (int)Math.Ceiling(price / (income - expenses));
            txtDays.Text = days.ToString();
        }
    }
}
