<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128595998/13.2.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2942)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* **[MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))**
<!-- default file list end -->
# How to create a document sections based on the values, entered by an end-user


<p>This example illustrates how to generate a document according to the end-user input. To pass specific values to the document's detail section, you just need to assign these values to the e.Data parameter of the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfPrintingSimpleLink_CreateDetailtopic"><u>SimpleLink.CreateDetail Event</u></a>. As for the report (page) header (footer) sections, it is necessary to override their DataContext, which is accessible via the corresponding Link properties. For instance, use the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfPrintingTemplatedLink_PageHeaderDatatopic"><u>TemplatedLink.PageHeaderData Property</u></a> to set the data context of a PageHeader.</p><p><strong>NOTE:</strong> We have a suggestion to enable printing in marginal sections of a document: <a href="https://www.devexpress.com/Support/Center/p/S35716">Links - Provide the capability to define a print template for the TopMargin and BottomMargin areas of a page</a></p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-reporting-create-a-document-sections-based-on-the-input-values&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-reporting-create-a-document-sections-based-on-the-input-values&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
