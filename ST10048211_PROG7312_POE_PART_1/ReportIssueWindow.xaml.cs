using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
    /// Interaction logic for ReportIssueWindow.xaml
    /// </summary>
    public partial class ReportIssueWindow : Window
    {
        MainWindow mainWindow = new MainWindow();

        // Boolean flags to track whether each field has been completed
        private bool isLocationCompleted = false;
        private bool isCategoryCompleted = false;
        private bool isDescriptionCompleted = false;
        private bool isAttachmentCompleted = false;

        private string dataFilePath = "reported_issues.txt";  // Path where issues will be saved


        private string selectedFilePath = null;  // Store the selected file path for attachments

        public ReportIssueWindow()
        {
            InitializeComponent();

            this.Closed += (sender, e) =>
            {
                this.Close();
                mainWindow.Show();
            };

            ResetProgressBar();  // Initialize the progress bar

        }

        private void ResetForm()
        {
            // Reset all fields and progress bar
            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1;  // Deselect category
            rtxtDescription.Document.Blocks.Clear();  // Clear the RichTextBox
            isAttachmentCompleted = false;
            lblProgressPercentage.Content = "0%";
            ResetProgressBar();  // Reset the progress bar
        }

        private void ResetProgressBar()
        {
            // Reset all fields and the progress bar
            isLocationCompleted = false;
            isCategoryCompleted = false;
            isDescriptionCompleted = false;
            isAttachmentCompleted = false;
            progBarIssue.Value = 0;  // Set ProgressBar to 0

            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1;
            rtxtDescription.Document.Blocks.Clear();
            lblAttachment.Content = "No file attached";
            progBarIssue.Value = 0;  // Reset progress bar
            selectedFilePath = null;  // Clear the file path
        }

        private void UpdateProgressBar()
        {
            if (progBarIssue != null)
            {
                // Count the number of completed fields
                int completedSteps = 0;
                if (isLocationCompleted) completedSteps++;
                if (isCategoryCompleted) completedSteps++;
                if (isDescriptionCompleted) completedSteps++;
                if (isAttachmentCompleted) completedSteps++;

                // Update the progress bar based on completed steps
                progBarIssue.Value = (completedSteps / 4.0) * 100;  // 4 steps total

                // Update the label with the percentage
                lblProgressPercentage.Content = $"{progBarIssue.Value}%";

                // Enable the Submit button if all fields are completed or progress bar is 100%
                if (progBarIssue.Value == 100)
                {
                    btnSubmit.IsEnabled = true;
                }
                else
                {
                    btnSubmit.IsEnabled = false;
                }

            }
        }

        private void btnDisplayIssues1_Click(object sender, RoutedEventArgs e)
        {
            DisplayIssueWindow displayIssueWindow = new DisplayIssueWindow();
            displayIssueWindow.Show();
            this.Hide();
        }

        private void btnMainMenu_Click(object sender, RoutedEventArgs e)
        {
            mainWindow.Show();
            this.Close();
        }

        private void txtLocation_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Mark the field as completed only if it's filled (not empty)
            if (!string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                isLocationCompleted = true;
            }
            else
            {
                isLocationCompleted = false; // Reset if text is cleared
            }

            UpdateProgressBar();
        }

        private void cmbCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Mark the category as completed if an item is selected
            if (cmbCategory.SelectedItem != null)
            {
                isCategoryCompleted = true;
            }
            else
            {
                isCategoryCompleted = false; // Reset if no selection
            }

            UpdateProgressBar();
        }

        private void rtxtDescription_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Get the text from the RichTextBox
            TextRange textRange = new TextRange(rtxtDescription.Document.ContentStart, rtxtDescription.Document.ContentEnd);

            // Mark the description as completed if it's filled (not empty)
            if (!string.IsNullOrWhiteSpace(textRange.Text.Trim()))
            {
                isDescriptionCompleted = true;
            }
            else
            {
                isDescriptionCompleted = false; // Reset if cleared
            }

            UpdateProgressBar();
        }

        private void btnAttachment_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "All Files (*.*)|*.*";
            // Set the initial directory to the Downloads folder
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads";

            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png|PDF Files (*.pdf)|*.pdf";

            if (openFileDialog.ShowDialog() == true)
            {
                selectedFilePath = openFileDialog.FileName;
                lblAttachment.Content = System.IO.Path.GetFileName(selectedFilePath);  // Show file name

                // Assume the attachment is completed when the button is clicked
                isAttachmentCompleted = true;

                UpdateProgressBar();
            }
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            // Get the input from the fields
            TextRange descriptionRange = new TextRange(rtxtDescription.Document.ContentStart, rtxtDescription.Document.ContentEnd);
            string description = descriptionRange.Text.Trim();
            string location = txtLocation.Text;
            string category = cmbCategory.Text;
            string attachment = string.IsNullOrEmpty(selectedFilePath) ? "No attachment" : selectedFilePath;

            Issue newIssue = new Issue(location, category, description, attachment);

            // Add the issue to the singly linked list
            Issue.issueList.InsertIssue(newIssue);

            // Save the updated list to the file
            Issue.issueList.SaveToFile(dataFilePath);

            MessageBox.Show("Issue reported and saved to the file!");

            // Reset form fields and progress bar
            ResetForm();


        }
    }
}
