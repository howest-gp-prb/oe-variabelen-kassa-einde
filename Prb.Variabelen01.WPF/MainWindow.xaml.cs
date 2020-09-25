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

namespace Prb.Variabelen01.WPF
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
        int totalAmount = 0;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtCustomer.Text = "";
            txtProductName.Text = "";
            txtAmount.Text = "";
            txtPrice.Text = "";
            tbkCart.Text = "";
            lblTotalAmount.Content = "";
        }

        private void btnAddToCart_Click(object sender, RoutedEventArgs e)
        {
            string customer = txtCustomer.Text;
            string productName = txtProductName.Text;
            int amount =int.Parse(txtAmount.Text);
            int price = int.Parse(txtPrice.Text);
            totalAmount += amount * price;
            string zin = customer;
            zin += " bestelt ";
            zin += amount;
            zin += " ";
            zin += productName;
            zin += " voor ";
            zin += price;
            zin += " euro/stuk";
            tbkCart.Text += zin + Environment.NewLine;
            lblTotalAmount.Content = "€" + totalAmount;

            txtCustomer.Text = "";
            txtProductName.Text = "";
            txtAmount.Text = "";
            txtPrice.Text = "";
        }
    }
}
