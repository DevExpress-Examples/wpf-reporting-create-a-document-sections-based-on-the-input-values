using System;
using System.Windows;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Printing;

namespace PrintDocumentFromUIWpf {
    public partial class MainWindow : DXWindow {
        public MainWindow() {
            InitializeComponent();
        }

        void DXWindow_Loaded(object sender, RoutedEventArgs e) {
            InitDefaultVlaues();
        }

        void btnPrint_Click(object sender, RoutedEventArgs e) {
            CreateAndPreviewLink();
        }

        void InitDefaultVlaues() {
            teReportHeader.EditValue = "Report Header";
            tePageHeader.EditValue = "Page Header";
            teDetail.EditValue = "Detail";
            tePageFooter.EditValue = "Page Footer";
            teReportFooter.EditValue = "Report Footer";
            seDetail.EditValue = 400;
            cePageInfo.EditValue = true;
        }

        void CreateAndPreviewLink() {
            var link = new SimpleLink {
                ReportHeaderTemplate = (DataTemplate)Resources["reportHeaderTemplate"],
                PageHeaderTemplate = (DataTemplate)Resources["pageHeaderTemplate"],
                DetailTemplate = (DataTemplate)Resources["detailTemplate"],
                PageFooterTemplate = (DataTemplate)Resources["pageFooterTemplate"],
                ReportFooterTemplate = (DataTemplate)Resources["reportFooterTemplate"],

                ReportHeaderData = teReportHeader,
                PageHeaderData = tePageHeader,
                PageFooterData = new PageFooterDataContext {
                    Title = tePageFooter.EditValue.ToString(),
                    PrintPageInfo = (bool)cePageInfo.IsChecked
                },
                ReportFooterData = teReportFooter,

                DetailCount = (int)seDetail.EditValue
            };

            link.CreateDetail += link_CreateDetail;
            link.ShowPrintPreviewDialog(this);
        }

        void link_CreateDetail(object sender, CreateAreaEventArgs e) {
            e.Data = string.Format("{0} (Row {1})", teDetail.EditValue, e.DetailIndex);
        }
    }

    public class PageFooterDataContext {
        public string Title { get; set; }
        public bool PrintPageInfo { get; set; }
    }
}
