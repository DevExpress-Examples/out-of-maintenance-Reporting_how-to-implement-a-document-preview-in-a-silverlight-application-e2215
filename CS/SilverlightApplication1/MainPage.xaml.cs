using System.Windows;
using System.Windows.Controls;

namespace SilverlightApplication1 {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        private void showReport_Click(object sender, RoutedEventArgs e) {
            preview.Model.CreateDocument();
        }
    }
}
