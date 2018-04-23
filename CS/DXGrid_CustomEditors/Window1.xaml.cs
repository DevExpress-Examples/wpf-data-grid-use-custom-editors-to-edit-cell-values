using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Markup;

namespace DXGrid_CustomEditors {
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
            grid.DataSource = Products.GetData();
        }

        private void grid_CustomUnboundColumnData(object sender, DevExpress.Xpf.Grid.GridColumnDataEventArgs e) {
            if (e.Column.FieldName == "Total") {
                e.Value = Convert.ToInt32(grid.GetCellValue(grid.GetRowHandleByListIndex(e.ListSourceRowIndex), "UnitPrice")) *
                    Convert.ToDouble(grid.GetCellValue(grid.GetRowHandleByListIndex(e.ListSourceRowIndex), "UnitsOnOrder"));
            }
        }
    }

    public class Products {
        public static List<Product> GetData() {
            List<Product> data = new List<Product>();
            data.Add(new Product() { ProductName = "Chai", UnitPrice = 18, UnitsOnOrder = 10 });
            data.Add(new Product() { ProductName = "Ipoh Coffee", UnitPrice=36.8, UnitsOnOrder = 12 });
            data.Add(new Product() { ProductName = "Outback Lager", UnitPrice=12, UnitsOnOrder = 25 });
            data.Add(new Product() { ProductName = "Boston Crab Meat", UnitPrice=18.4, UnitsOnOrder = 18 });
            data.Add(new Product() { ProductName = "Konbu", UnitPrice=6, UnitsOnOrder = 24 });
            return data;
        }
    }
    public class Product {
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsOnOrder { get; set; }
    }

    public class IntToDoubleConverter : MarkupExtension, IValueConverter {
        public override object ProvideValue(IServiceProvider serviceProvider) {
            return this;
        }
        object IValueConverter.Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            return Convert.ToDouble(value);
        }
        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture) {
            return Convert.ToInt32(value);
        }
    }
}
