using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace DXGrid_CustomEditors {
    public class DemoViewModel : INotifyPropertyChanged {
        List<Product> products;
        public DemoViewModel() {
            Products = GenerateData();
        }
        List<Product> GenerateData() {
            List<Product> data = new List<Product>();
            data.Add(new Product() { ProductName = "Chai", UnitPrice = 18, UnitsOnOrder = 10 });
            data.Add(new Product() { ProductName = "Ipoh Coffee", UnitPrice = 36.8, UnitsOnOrder = 12 });
            data.Add(new Product() { ProductName = "Outback Lager", UnitPrice = 12, UnitsOnOrder = 25 });
            data.Add(new Product() { ProductName = "Boston Crab Meat", UnitPrice = 18.4, UnitsOnOrder = 18 });
            data.Add(new Product() { ProductName = "Konbu", UnitPrice = 6, UnitsOnOrder = 24 });
            return data;
        }
        public List<Product> Products { 
            get { return products; }
            set {
                if(value == products)
                    return;
                products = value;
                NotifyPropertyChanged("Products");
            }
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String info) {
            if(PropertyChanged != null) {
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        #endregion
    }

    public class Product {
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsOnOrder { get; set; }
    }
}
