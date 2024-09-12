using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ST10048211_PROG7312_POE_PART_1
{
    /// <summary>
    /// Interaction logic for DisplayIssueWindow.xaml
    /// </summary>
    public partial class DisplayIssueWindow : Window
    {
        MainWindow mainWindow = new MainWindow();
        private string filePath = "reported_issues.txt";  // Same file used to save issues

        public DisplayIssueWindow()
        {
            InitializeComponent();
            this.Closed += (sender, e) =>
            {
                this.Close();
                mainWindow.Show();
            };

            LoadIssues();
        }

        private void btnMainMenu_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Show();
            this.Close();
        }

        private void LoadIssues()
        {
            lstIssues.Items.Clear();  // Clear existing items before loading new ones

            if (File.Exists(filePath))
            {
                string[] issueLines = File.ReadAllLines(filePath);
                int issueCount = 0;
                foreach (string issueLine in issueLines)
                {
                    issueCount++;
                    // Ensure the line contains all required components
                    if (issueLine.Contains("Location:") &&
                        issueLine.Contains("Category:") &&
                        issueLine.Contains("Description:") &&
                        issueLine.Contains("Attachment:"))
                    {
                        // Split the line based on the labels and commas
                        string[] parts = issueLine.Split(new[] { ", " }, StringSplitOptions.None);

                        if (parts.Length == 4)
                        {
                            // Extract values
                            string location = parts[0].Substring("Location: ".Length).Trim();
                            string category = parts[1].Substring("Category: ".Length).Trim();
                            string description = parts[2].Substring("Description: ".Length).Trim();
                            string attachment = parts[3].Substring("Attachment: ".Length).Trim();

                            // Create a formatted string
                            string formattedIssue = $"Issue {issueCount}: \n" +
                                $" Location: {location}\n" +
                                $" Category: {category}\n" +
                                $" Description: {description}\n" +
                                $" Attachment: {attachment}";

                            // Add the formatted string to the ListBox
                            lstIssues.Items.Add(formattedIssue);
                        }
                        else
                        {
                            MessageBox.Show("The issue data format is incorrect. Make sure each line contains the correct number of components.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("The issue data format is incorrect. Make sure each line includes all required labels.");
                    }
                }
            }
            else
            {
                MessageBox.Show("No reported issues found.");
            }
        }

        private void btnReportIssue_Click(object sender, RoutedEventArgs e)
        {
            ReportIssueWindow reportIssueWindow = new ReportIssueWindow();
            reportIssueWindow.Show();
            this.Hide();
        }
    }
}
