Imports System.Windows.Forms
Imports DevExpress.XtraPdfViewer
Imports DevExpress.XtraBars

Namespace CustomPopupMenu
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            pdfViewer1.LoadDocument("..\..\Demo.pdf")
        End Sub

        Private Sub pdfViewer1_PopupMenuShowing(ByVal sender As Object, ByVal e As PdfPopupMenuShowingEventArgs) Handles pdfViewer1.PopupMenuShowing
            ' Create a bar button item.
            Dim browseBarButton As New BarButtonItem()
            browseBarButton.Caption = "Custom Item"

            ' Insert the bar buttom item into the PDF Viewer popup menu and start a new group.
            e.ItemLinks.Add(browseBarButton, True)

            ' Handle the bar button click event.
            AddHandler browseBarButton.ItemClick, AddressOf browseBarButton_ItemClick
        End Sub

        Private Sub browseBarButton_ItemClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            MessageBox.Show("ItemClick event fires")
        End Sub
    End Class
End Namespace
