using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
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
            OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = true };
            bool? response = openFileDialog.ShowDialog();
            if (response == true)
            {
                string[] files = openFileDialog.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                    string filename = System.IO.Path.GetFullPath(files[i]);
                    FileInfo fileInfo = new FileInfo(files[i]);

                    product.ImagePath = filename;
                }
            }
        }
    }
}
