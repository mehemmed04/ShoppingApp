using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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

namespace ShoppingApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public List<Product> Products
        {
            get { return (List<Product>)GetValue(ProductsProperty); }
            set { SetValue(ProductsProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Products.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ProductsProperty =
            DependencyProperty.Register("Products", typeof(List<Product>), typeof(MainWindow));


        public MainWindow()
        {
            InitializeComponent();
            Products = GetProducts();
            this.DataContext = this;
        }



        public List<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                     ImagePath="Images/Products/product1.png",
                     ProductName ="Amsterdam eBike",
                     ProductPrice = 2698
                },
                new Product
                {
                     ImagePath="Images/Products/product2.png",
                     ProductName ="Hoodie",
                     ProductPrice = 22.12
                },
                new Product
                {
                     ImagePath="Images/Products/product3.png",
                     ProductName ="428 HDR Heavy",
                     ProductPrice = 49.88
                },
                new Product
                {
                     ImagePath="Images/Products/product4.png",
                     ProductName ="Luxury Bus seating",
                     ProductPrice = 825.7
                },
                new Product
                {
                     ImagePath="Images/Products/product5.png",
                     ProductName ="Fuel Off-Road",
                     ProductPrice = 214.5
                },
                new Product
                {
                     ImagePath="Images/Products/product7.png",
                     ProductName ="T-shirt",
                     ProductPrice = 12.99
                },
                new Product
                {
                     ImagePath="Images/Products/product6.png",
                     ProductName ="Sour Bicycles",
                     ProductPrice = 298
                },
                new Product
                {
                     ImagePath="Images/Products/product8.png",
                     ProductName ="DJI Mavic 3",
                     ProductPrice = 1929
                },
                new Product
                {
                     ImagePath="Images/Products/product9.png",
                     ProductName ="Iphone 13 Pro Max",
                     ProductPrice = 1099.99
                },
                new Product
                {
                     ImagePath="Images/Products/product10.png",
                     ProductName ="Asus Zenbook Pro",
                     ProductPrice = 2234.89
                },
                new Product
                {
                     ImagePath="Images/Products/product11.png",
                     ProductName ="Iphone 14 Pro Max Case",
                     ProductPrice = 49.99
                },
                new Product
                {
                     ImagePath="Images/Products/product12.png",
                     ProductName ="Macbook 13 Pro",
                     ProductPrice = 3456
                },
                new Product
                {
                     ImagePath="Images/Products/product13.png",
                     ProductName ="Samsung S22 Ultra",
                     ProductPrice = 1250
                },
     
            };
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }

        private void minimizeBtn_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void CloseBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public bool IsFullScreen { get; set; }
        private void maximizeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (IsFullScreen)
            {
                WindowState = WindowState.Normal;
                IsFullScreen = false;
            }
            else
            {
                WindowState = WindowState.Maximized;
                IsFullScreen = true;
            }
        }

        private void ListViewProducts_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var product = ListViewProducts.SelectedItem as Product;
            ProductWindow productWindow = new ProductWindow(product);
            productWindow.ShowDialog();
        }

        private void AddToBasketBtn_Click(object sender, RoutedEventArgs e)
        {
            var product = ListViewProducts.SelectedItem as Product;
            MessageBox.Show($"Succesfully added to Basket");
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (SearchTextBox.Text == String.Empty)
            {
                Products=GetProducts();
                return;
            }
            Products = Products.Where(p =>
            {
                return p.ProductName.Contains(SearchTextBox.Text);
            }).ToList();
        }
    }
}
