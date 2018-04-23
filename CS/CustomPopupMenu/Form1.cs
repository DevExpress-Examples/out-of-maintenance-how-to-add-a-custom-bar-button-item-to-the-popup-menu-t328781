using System.Windows.Forms;
using DevExpress.XtraPdfViewer;
using DevExpress.XtraBars;

namespace CustomPopupMenu {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            pdfViewer1.LoadDocument("..\\..\\Demo.pdf");
        }

        void pdfViewer1_PopupMenuShowing(object sender, PdfPopupMenuShowingEventArgs e) {
            // Create a bar button item.
            BarButtonItem browseBarButton = new BarButtonItem();
            browseBarButton.Caption = "Custom Item";

            // Insert the bar buttom item into the PDF Viewer popup menu and start a new group.
            e.ItemLinks.Add(browseBarButton, true);

            // Handle the bar button click event.
            browseBarButton.ItemClick += browseBarButton_ItemClick;
        }

        void browseBarButton_ItemClick(object sender, ItemClickEventArgs e) {
            MessageBox.Show("ItemClick event fires");
        }
    }
}
