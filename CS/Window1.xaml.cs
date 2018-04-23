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
        }
        private void grid_CustomUnboundColumnData(object sender, DevExpress.Xpf.Grid.GridColumnDataEventArgs e) {
            if (e.Column.FieldName == "Total") {
                e.Value = Convert.ToInt32(grid.GetCellValueByListIndex(e.ListSourceRowIndex, "UnitPrice")) *
                    Convert.ToDouble(grid.GetCellValueByListIndex(e.ListSourceRowIndex, "UnitsOnOrder"));
            }
        }
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
