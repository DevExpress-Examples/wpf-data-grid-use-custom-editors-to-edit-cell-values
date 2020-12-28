using DevExpress.Mvvm;
using System.Collections.ObjectModel;

namespace DXGrid_CustomEditors
{
    public class DemoViewModel : ViewModelBase {
        ObservableCollection<Product> _products;
        public DemoViewModel() {
            Products = GenerateData();
        }
        ObservableCollection<Product> GenerateData() {
            ObservableCollection<Product> data = new ObservableCollection<Product>();
            data.Add(new Product() { ProductName = "Chai", UnitPrice = 18, UnitsOnOrder = 10 });
            data.Add(new Product() { ProductName = "Ipoh Coffee", UnitPrice = 36.8, UnitsOnOrder = 12 });
            data.Add(new Product() { ProductName = "Outback Lager", UnitPrice = 12, UnitsOnOrder = 25 });
            data.Add(new Product() { ProductName = "Boston Crab Meat", UnitPrice = 18.4, UnitsOnOrder = 18 });
            data.Add(new Product() { ProductName = "Konbu", UnitPrice = 6, UnitsOnOrder = 24 });
            return data;
        }
        public ObservableCollection<Product> Products { 
            get { return _products; }
            set {
                if(value == _products)
                    return;
                _products = value;
                this.RaisePropertyChanged("Products");
            }
        }
    }

    public class Product : BindableBase {
        public string ProductName {
            get { return GetProperty<string>(() => ProductName); }
            set { SetProperty(() => ProductName, value); }
        }
        public double UnitPrice {
            get { return GetProperty<double>(() => UnitPrice); }
            set { SetProperty(() => UnitPrice, value); }
        }
        public int UnitsOnOrder {
            get { return GetProperty<int>(() => UnitsOnOrder); }
            set { SetProperty(() => UnitsOnOrder, value); }
        }
    }
}
