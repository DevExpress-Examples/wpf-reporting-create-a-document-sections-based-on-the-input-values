<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595998/23.1.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2942)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Reporting for WPF - Create a Document Sections Based on the Input Values

This example illustrates how to generate a document according to user input. To pass specific values to the document's detail section, assign these values to the `e.Data` parameter of the [SimpleLink.CreateDetail](https://docs.devexpress.com/WPF/DevExpress.Xpf.Printing.SimpleLink.CreateDetail) event. As for the report page header (footer) sections, override their `DataContext` that is accessible through the corresponding Link properties. For instance, use the [TemplatedLink.PageHeaderData](https://docs.devexpress.com/WPF/DevExpress.Xpf.Printing.TemplatedLink.PageHeaderData) property to set the data context of a `PageHeader`.


## Files to Review
* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* **[MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))**



<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-reporting-create-a-document-sections-based-on-the-input-values&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-reporting-create-a-document-sections-based-on-the-input-values&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
