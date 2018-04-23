using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Resources;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using GridExample;
using System.Collections.Generic;
using DevExpress.Xpf.Grid;
using DevExpress.Xpf.Printing;
using DevExpress.Xpf.Core;


namespace SLGridExample {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();

            Loaded += new RoutedEventHandler(MainPage_Loaded);
        }

        void MainPage_Loaded(object sender, RoutedEventArgs e) {
            grid.ItemsSource = new List<TestData>() {
                new TestData() { PlainText = "Mercedes-Benz SLK", MemoText = "LMA AG \n2004 \nSilver", BooleanMember = true, Image = GetImage("/SLGridExample;component/Images/1.jpg"), Price = 25 },
                new TestData() { PlainText = "Rolls-Royce Corniche", MemoText ="Western Motors \n1975 \nSnowy whight", BooleanMember = false, Image = GetImage("/SLGridExample;component/Images/2.jpg"), Price = 15 },
                new TestData() { PlainText = "Ford Ranger FX-4", MemoText = "Sun car rent\n1999 \nRed rock", BooleanMember = true, Image = GetImage("/SLGridExample;component/Images/3.jpg"), Price = 20 },
            };
        }

        ImageSource GetImage(string path) {

            StreamResourceInfo sr = Application.GetResourceStream(new Uri(path, UriKind.Relative));
            BitmapImage bmp = new BitmapImage();
            bmp.SetSource(sr.Stream);

            return bmp;
        }

        private void PrintButton_Click(object sender, RoutedEventArgs e) {
            ShowPrintPreview(grid);
        }

        private void ShowPrintPreview(GridControl grid) {
            DocumentPreview preview = new DocumentPreview();
            PrintableControlLink link = new PrintableControlLink(grid.View as IPrintableControl);
            link.ExportServiceUri = "../ExportService.svc";
            LinkPreviewModel model = new LinkPreviewModel(link);
            preview.Model = model;

            link.CreateDocument(true);
            DXDialog dlg = new DXDialog();
            dlg.Content = preview;
            dlg.Height = 640;
            dlg.Left = 150;
            dlg.Top = 150;
            dlg.ShowDialog();
        }
    }
}
