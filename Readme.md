<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2942)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Reporting for WPF - Create a Document Sections Based on the Input Values

This example illustrates how to generate a document according to user input. To pass specific values to the document's detail section, assign these values to the `e.Data` parameter of the [SimpleLink.CreateDetail](https://docs.devexpress.com/WPF/DevExpress.Xpf.Printing.SimpleLink.CreateDetail) event. As for the report page header (footer) sections, override their `DataContext` that is accessible through the corresponding Link properties. For instance, use the [TemplatedLink.PageHeaderData](https://docs.devexpress.com/WPF/DevExpress.Xpf.Printing.TemplatedLink.PageHeaderData) property to set the data context of a `PageHeader`.


## Files to Review
* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* **[MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))**



