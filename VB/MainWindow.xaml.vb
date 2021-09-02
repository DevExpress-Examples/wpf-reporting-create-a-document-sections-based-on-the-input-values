Imports System
Imports System.Windows
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Printing

Namespace PrintDocumentFromUIWpf
	Partial Public Class MainWindow
		Inherits DXWindow

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub DXWindow_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			InitDefaultVlaues()
		End Sub

		Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			CreateAndPreviewLink()
		End Sub

		Private Sub InitDefaultVlaues()
			teReportHeader.EditValue = "Report Header"
			tePageHeader.EditValue = "Page Header"
			teDetail.EditValue = "Detail"
			tePageFooter.EditValue = "Page Footer"
			teReportFooter.EditValue = "Report Footer"
			seDetail.EditValue = 400
			cePageInfo.EditValue = True
		End Sub

		Private Sub CreateAndPreviewLink()
			Dim link = New SimpleLink With {
				.ReportHeaderTemplate = CType(Resources("reportHeaderTemplate"), DataTemplate),
				.PageHeaderTemplate = CType(Resources("pageHeaderTemplate"), DataTemplate),
				.DetailTemplate = CType(Resources("detailTemplate"), DataTemplate),
				.PageFooterTemplate = CType(Resources("pageFooterTemplate"), DataTemplate),
				.ReportFooterTemplate = CType(Resources("reportFooterTemplate"), DataTemplate),
				.ReportHeaderData = teReportHeader,
				.PageHeaderData = tePageHeader,
				.PageFooterData = New PageFooterDataContext With {
					.Title = tePageFooter.EditValue.ToString(),
					.PrintPageInfo = CBool(cePageInfo.IsChecked)
				},
				.ReportFooterData = teReportFooter,
				.DetailCount = CInt(Math.Truncate(seDetail.EditValue))
			}

			AddHandler link.CreateDetail, AddressOf link_CreateDetail
			link.ShowPrintPreviewDialog(Me)
		End Sub

		Private Sub link_CreateDetail(ByVal sender As Object, ByVal e As CreateAreaEventArgs)
			e.Data = String.Format("{0} (Row {1})", teDetail.EditValue, e.DetailIndex)
		End Sub
	End Class

	Public Class PageFooterDataContext
		Public Property Title() As String
		Public Property PrintPageInfo() As Boolean
	End Class
End Namespace
