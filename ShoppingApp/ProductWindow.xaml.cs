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
using System.Windows.Shapes;

namespace ShoppingApp
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {

        public Product product { get; set; }
        public ProductWindow(Product product)
        {
            InitializeComponent();
            this.DataContext = this;
            this.product = product;
        }

        private void EditImageBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
