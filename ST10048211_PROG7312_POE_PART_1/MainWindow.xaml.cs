using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ST10048211_PROG7312_POE_PART_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Closed += (sender, e) => this.Dispatcher.InvokeShutdown();
        }

        private void btnReportIssue_Click(object sender, RoutedEventArgs e)
        {
            ReportIssueWindow issueWindow = new ReportIssueWindow();
            issueWindow.Show();
            this.Hide();
        }
    }
}