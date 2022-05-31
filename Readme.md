<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128653470/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1596)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WPF Data Grid - Use Custom Editors to Edit Cell Values

This example shows how to use custom editors ([ProgressBar](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.progressbar) and [Slider](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.slider)) to display and edit the **Units On Order** column's values.

![image](https://user-images.githubusercontent.com/65009440/171182860-0dab0ada-9b5c-4faa-ab66-0f7a28b19e32.png)

Custom editors are defined in templates:

* The [CellDisplayTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.ColumnBase.CellDisplayTemplate) property defines a template that displays column values.
* The [CellEditTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.ColumnBase.CellEditTemplate) property defines a template used to edit cell values.

## Files to Look At

* [Window1.xaml](./CS/Window1.xaml) / [Window1.xaml](./VB/Window1.xaml)
* [Window1.xaml.cs](./CS/Window1.xaml.cs) / [Window1.xaml.vb](./VB/Window1.xaml.vb)

## Documentation

* [Edit Cell Values in UI](http://docs.devexpress.com/WPF/6606/controls-and-libraries/data-grid/data-editing-and-validation/modify-cell-values/inplace-editors)
* [Assign Editors to Cells](http://docs.devexpress.com/WPF/401011/controls-and-libraries/data-grid/data-editing-and-validation/modify-cell-values/assign-an-editor-to-a-cell)

## More Examples

* [WPF Data Grid - Assign a ComboBox Editor to a Column](https://github.com/DevExpress-Examples/wpf-data-grid-assign-combobox-editor-to-column)
