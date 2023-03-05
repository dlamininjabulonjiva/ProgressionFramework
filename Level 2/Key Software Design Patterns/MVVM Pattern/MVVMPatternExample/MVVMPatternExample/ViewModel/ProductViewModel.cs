using MVVMPatternExample.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MVVMPatternExample.ViewModel
{
    public class ProductViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<ProductModel> products;
        private ProductModel _selectedProduct;

        public ObservableCollection<ProductModel> Products
        {
            get { return products; }
            set
            {
                products = value;
                OnPropertyChanged(nameof(Products));
            }
        }

        public ProductModel SelectedProduct
        {
            get { return _selectedProduct; }
            set
            {
                _selectedProduct = value;
                OnPropertyChanged(nameof(SelectedProduct));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ProductViewModel()
        {
            // Load products from database
            Products = new ObservableCollection<ProductModel>();
            Products.Add(new ProductModel { Id = 1, Name = "Product A", Price = 10.0 });
            Products.Add(new ProductModel { Id = 2, Name = "Product B", Price = 20.0 });
            Products.Add(new ProductModel { Id = 3, Name = "Product C", Price = 30.0 });
        }

        public void AddProduct(ProductModel product)
        {
            // Add product to database
            Products.Add(product);
        }
    }
}
