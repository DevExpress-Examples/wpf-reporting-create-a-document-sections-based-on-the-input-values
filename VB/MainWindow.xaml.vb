Imports System.Windows
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Printing

Namespace PrintDocumentFromUIWpf

    Public Partial Class MainWindow
        Inherits DXWindow

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub DXWindow_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            InitDefaultVlaues()
        End Sub

        Private Sub btnPrint_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
            CreateAndPreviewLink()
        End Sub

        Private Sub InitDefaultVlaues()
            Me.teReportHeader.EditValue = "Report Header"
            Me.tePageHeader.EditValue = "Page Header"
            Me.teDetail.EditValue = "Detail"
            Me.tePageFooter.EditValue = "Page Footer"
            Me.teReportFooter.EditValue = "Report Footer"
            Me.seDetail.EditValue = 400
            Me.cePageInfo.EditValue = True
        End Sub

        Private Sub CreateAndPreviewLink()
            Dim link = New SimpleLink With {.ReportHeaderTemplate = CType(Resources("reportHeaderTemplate"), DataTemplate), .PageHeaderTemplate = CType(Resources("pageHeaderTemplate"), DataTemplate), .DetailTemplate = CType(Resources("detailTemplate"), DataTemplate), .PageFooterTemplate = CType(Resources("pageFooterTemplate"), DataTemplate), .ReportFooterTemplate = CType(Resources("reportFooterTemplate"), DataTemplate), .ReportHeaderData = Me.teReportHeader, .PageHeaderData = Me.tePageHeader, .PageFooterData = New PageFooterDataContext With {.Title = Me.tePageFooter.EditValue.ToString(), .PrintPageInfo = CBool(Me.cePageInfo.IsChecked)}, .ReportFooterData = Me.teReportFooter, .DetailCount = CInt(Me.seDetail.EditValue)}
            AddHandler link.CreateDetail, AddressOf link_CreateDetail
            link.ShowPrintPreviewDialog(Me)
        End Sub

        Private Sub link_CreateDetail(ByVal sender As Object, ByVal e As CreateAreaEventArgs)
            e.Data = String.Format("{0} (Row {1})", Me.teDetail.EditValue, e.DetailIndex)
        End Sub
    End Class

    Public Class PageFooterDataContext

        Public Property Title As String

        Public Property PrintPageInfo As Boolean
    End Class
End Namespace
