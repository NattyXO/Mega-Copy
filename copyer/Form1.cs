using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace copyer
{
    public partial class Form1 : Form
    {

        BackgroundWorker Worker = new BackgroundWorker();


        public Form1()
        {
            InitializeComponent();
           
        }
       
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOpenFileLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] fileNames = ofd.FileNames;
                txtSource.Text = string.Join(", ", fileNames);
            }
        }

        private void btnDestinationLocation_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtTarget.Text = fbd.SelectedPath;
            }
        }

        bool CopySingleFile(string source, string destination)
        {
            const int maxRetries = 3;
            const int delayMs = 100;

            for (int i = 0; i < maxRetries; i++)
            {
                try
                {
                    File.Copy(source, destination, true);
                    return true;
                }
                catch (IOException ex) when (i < maxRetries - 1)
                {
                    System.Threading.Thread.Sleep(delayMs);
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show($"Unauthorized access: {ex.Message}");
                    return false;
                }
                catch (FileNotFoundException ex)
                {
                    MessageBox.Show($"File not found: {ex.Message}");
                    return false;
                }
                catch (PathTooLongException ex)
                {
                    MessageBox.Show($"Path too long: {ex.Message}");
                    return false;
                }
                catch (DirectoryNotFoundException ex)
                {
                    MessageBox.Show($"Directory not found: {ex.Message}");
                    return false;
                }
                catch (NotSupportedException ex)
                {
                    MessageBox.Show($"Invalid path format: {ex.Message}");
                    return false;
                }
                catch (Exception ex)
                {
                    // Log additional information for debugging purposes
                    MessageBox.Show($"Error copying file: {ex.Message}\nSource: {source}\nDestination: {destination}");
                    return false;
                }
            }
            return false;
        }




        private void btnCopyandOverwrite_Click(object sender, EventArgs e)
        {
            string[] sourceFiles = txtSource.Text.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string targetFolder = txtTarget.Text;

            // Check if source or destination paths are empty or null
            if (string.IsNullOrWhiteSpace(txtSource.Text) || string.IsNullOrWhiteSpace(txtTarget.Text))
            {
                MessageBox.Show("Please provide both source and destination locations.");
                return;
            }

            // Check if the source and destination are the same
            if (txtSource.Text.Trim().Equals(txtTarget.Text.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Source and destination cannot be the same.");
                return;
            }

            // Check if source files exist
            bool sourceExists = sourceFiles.All(File.Exists);

            if (!sourceExists)
            {
                MessageBox.Show("Source file(s) do not exist.");
                return;
            }

            int filesToCopy = sourceFiles.Length;
            int filesCopied = 0;

            foreach (string sourceFile in sourceFiles)
            {
                string fileName = Path.GetFileName(sourceFile);
                string destination = Path.Combine(targetFolder, fileName);

                if (File.Exists(destination))
                {
                    // Check if the file exists in the destination; if yes, ask for overwrite confirmation
                    DialogResult result = MessageBox.Show($"File '{fileName}' already exists in the destination. Overwrite?", "Confirmation", MessageBoxButtons.YesNo);

                    if (result == DialogResult.No)
                        continue; // Skip this file if the user chooses not to overwrite
                }

                if (CopySingleFile(sourceFile, destination))
                {
                    filesCopied++;
                    // Delete the original file after successful copying
                    File.Delete(sourceFile);
                }
            }

            if (filesCopied == filesToCopy)
            {
                MessageBox.Show("File(s) copied successfully!");
            }
        }

        private void btnCutandOverwrite_Click(object sender, EventArgs e)
        {
            string sourceText = txtSource.Text.Trim();
            string targetText = txtTarget.Text.Trim();

            if (string.IsNullOrEmpty(sourceText) || string.IsNullOrEmpty(targetText))
            {
                MessageBox.Show("Please provide both source and destination paths.");
                return;
            }

            string[] sourceFiles = sourceText.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string targetFolder = targetText;

            int filesToCut = sourceFiles.Length;
            int filesCut = 0;
            bool sourceExists = true;

            foreach (string sourceFile in sourceFiles)
            {
                if (!File.Exists(sourceFile))
                {
                    sourceExists = false;
                    continue; // Skip processing this file
                }

                string fileName = Path.GetFileName(sourceFile);
                string destination = Path.Combine(targetFolder, fileName);

                if (CopySingleFile(sourceFile, destination))
                {
                    filesCut++;
                    File.Delete(sourceFile); // Delete the original file after successful copying
                }
            }

            if (!sourceExists)
            {
                MessageBox.Show("Source file does not exist.");
            }
            else if (filesCut == filesToCut)
            {
                MessageBox.Show("File(s) cut successfully!");
            }
        }

        private void btnCutandDuplicate_Click(object sender, EventArgs e)
        {
            string[] sourceFiles = txtSource.Text.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string targetFolder = txtTarget.Text;

            // Check if source or destination paths are empty or null
            if (string.IsNullOrWhiteSpace(txtSource.Text) || string.IsNullOrWhiteSpace(txtTarget.Text))
            {
                MessageBox.Show("Please provide both source and destination locations.");
                return;
            }

            // Check if the source and destination are the same
            if (txtSource.Text.Trim().Equals(txtTarget.Text.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Source and destination cannot be the same.");
                return;
            }

            // Check if source files exist
            bool sourceExists = sourceFiles.All(File.Exists);

            if (!sourceExists)
            {
                MessageBox.Show("Source file(s) do not exist.");
                return;
            }

            int filesCopied = 0;
            int filesCut = 0;
            bool sourceFilesExist = true;

            foreach (string sourceFile in sourceFiles)
            {
                if (!File.Exists(sourceFile))
                {
                    sourceFilesExist = false;
                    continue; // Skip processing this file
                }

                string fileName = Path.GetFileName(sourceFile);
                string destination = Path.Combine(targetFolder, fileName);

                // Create a new file name by adding a suffix to the original file name
                string newFileName = Path.Combine(targetFolder, $"{Path.GetFileNameWithoutExtension(sourceFile)}_copy{Path.GetExtension(sourceFile)}");

                if (File.Exists(destination))
                {
                    // Check if the file exists in the destination; if yes, create a new copy with a different name
                    newFileName = Path.Combine(targetFolder, $"{Path.GetFileNameWithoutExtension(sourceFile)}_copy{DateTime.Now:yyyyMMddHHmmssfff}{Path.GetExtension(sourceFile)}");
                }

                if (CopySingleFile(sourceFile, newFileName))
                {
                    filesCopied++;
                    File.Delete(sourceFile); // Delete the original file after successful copying
                    filesCut++;
                }
            }

            if (!sourceFilesExist)
            {
                MessageBox.Show("Source file does not exist.");
            }
            else if (filesCopied == sourceFiles.Length && filesCut == sourceFiles.Length)
            {
                MessageBox.Show("File(s) cut and duplicated successfully!");
            }
        }

        private void btnCopyandDuplicate_Click(object sender, EventArgs e)
        {
            string[] sourceFiles = txtSource.Text.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string targetFolder = txtTarget.Text;

            // Check if source or destination paths are empty or null
            if (string.IsNullOrWhiteSpace(txtSource.Text) || string.IsNullOrWhiteSpace(txtTarget.Text))
            {
                MessageBox.Show("Please provide both source and destination locations.");
                return;
            }

            // Check if the source and destination are the same
            if (txtSource.Text.Trim().Equals(txtTarget.Text.Trim(), StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Source and destination cannot be the same.");
                return;
            }

            // Check if source files exist
            bool sourceExists = sourceFiles.All(File.Exists);

            if (!sourceExists)
            {
                MessageBox.Show("Source file(s) do not exist.");
                return;
            }

            int filesCopied = 0;

            foreach (string sourceFile in sourceFiles)
            {
                string fileName = Path.GetFileName(sourceFile);
                string destination = Path.Combine(targetFolder, fileName);

                // Create a new file name by adding a suffix to the original file name
                string newFileName = Path.Combine(targetFolder, $"{Path.GetFileNameWithoutExtension(sourceFile)}_copy{Path.GetExtension(sourceFile)}");

                if (File.Exists(destination))
                {
                    // Check if the file exists in the destination; if yes, create a new copy with a different name
                    newFileName = Path.Combine(targetFolder, $"{Path.GetFileNameWithoutExtension(sourceFile)}_copy{DateTime.Now:yyyyMMddHHmmssfff}{Path.GetExtension(sourceFile)}");
                }

                if (CopySingleFile(sourceFile, newFileName))
                {
                    filesCopied++;
                }
            }

            if (filesCopied == sourceFiles.Length)
            {
                MessageBox.Show("File(s) duplicated successfully!");
            }
        }

        private void picGitHub_Click(object sender, EventArgs e)
        {
            // Replace "YourGitHubUsername" with your actual GitHub username
            string githubUrl = "https://github.com/NattyXO";

            try
            {
                // Open the GitHub URL in the default web browser
                Process.Start(githubUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening GitHub: {ex.Message}");
            }
        }
    }
}
