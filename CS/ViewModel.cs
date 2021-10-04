using DevExpress.Mvvm;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DXGrid_CustomEditors
{
    public class DemoViewModel : ViewModelBase {
        public DemoViewModel() {
            Products = new ObservableCollection<Product>(GenerateData());
        }
        static IEnumerable<Product> GenerateData() {
            yield return new Product() { ProductName = "Chai", UnitPrice = 18, UnitsOnOrder = 10 };
            yield return new Product() { ProductName = "Ipoh Coffee", UnitPrice = 36.8, UnitsOnOrder = 12 };
            yield return new Product() { ProductName = "Outback Lager", UnitPrice = 12, UnitsOnOrder = 25 };
            yield return new Product() { ProductName = "Boston Crab Meat", UnitPrice = 18.4, UnitsOnOrder = 18 };
            yield return new Product() { ProductName = "Konbu", UnitPrice = 6, UnitsOnOrder = 24 };
        }
        public ObservableCollection<Product> Products { 
            get { return GetValue<ObservableCollection<Product>>(nameof(Products)); }
            set { SetValue(value, nameof(Products)); }
        }
    }

    public class Product : BindableBase {
        public string ProductName {
            get { return GetValue<string>(nameof(ProductName)); }
            set { SetValue(value, nameof(ProductName)); }
        }
        public double UnitPrice {
            get { return GetValue<double>(nameof(UnitPrice)); }
            set { SetValue(value, nameof(UnitPrice)); }
        }
        public int UnitsOnOrder {
            get { return GetValue<int>(nameof(UnitsOnOrder)); }
            set { SetValue(value, nameof(UnitsOnOrder)); }
        }
    }
}
