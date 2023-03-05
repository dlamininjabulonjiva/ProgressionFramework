using MVVMPatternExample.Model;
using MVVMPatternExample.ViewModel;
using System.Windows;

namespace MVVMPatternExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ProductViewModel viewModel;

        public MainWindow()
        {
            InitializeComponent();

            viewModel = new ProductViewModel();
            DataContext = viewModel;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var productName = ProductNameTextBox.Text;
            var price = double.Parse(PriceTextBox.Text);

            if (viewModel.SelectedProduct != null)
            {
                viewModel.SelectedProduct.Name = productName;
                viewModel.SelectedProduct.Price = price;
            }
            else
            {
                var product = new ProductModel { Id = viewModel.Products.Count + 1, Name = productName, Price = price };
                viewModel.AddProduct(product);
            }

            ProductNameTextBox.Text = "";
            PriceTextBox.Text = "";
        }
    }
}
