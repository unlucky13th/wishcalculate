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

namespace wishcal
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
        private void calculate_Click(object sender, RoutedEventArgs e)
        {
            int income = int.Parse(txtincome.Text); 
            int outcome = int.Parse(txtoutcome.Text);
            if (income <= outcome)
            {
                MessageBox.Show("You need to increase income!");
            }
            int price=int.Parse(txtprice.Text);
            int day = ((price / (income - outcome)+1));
            txtday.Text = day.ToString();
        }
    }
}
