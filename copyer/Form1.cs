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

        public string FileSourceLocationText
        {
            get { return txtSource.Text; }
            set { txtSource.Text = value; }
        }
        public string FileTargetLocationText
        {
            get { return txtTarget.Text; }
            set { txtTarget.Text = value; }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Form1()
        {
            InitializeComponent();
        }


        private void btnOpenFileLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Multiselect = true;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string[] fileNames = ofd.FileNames;
                txtSource.Text = string.Join(", ", fileNames);

                long totalSize = GetTotalFileSize(fileNames); // Pass file names directly to GetTotalFileSize
                lblFilesize.Font = new Font("Microsoft Sans Serif", 9);
                lblFilesize.Text = $"Total size: {FormatFileSize(totalSize)}";
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

        private long GetTotalFileSize(string[] files)
        {
            long totalSize = 0;

            foreach (string file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                if (fileInfo.Exists)
                {
                    totalSize += fileInfo.Length;
                }
            }

            return totalSize;
        }

        private string FormatFileSize(long bytes)
        {
            const long kb = 1024L;
            const long mb = 1024L * 1024L;
            const long gb = 1024L * 1024L * 1024L;
            const long tb = 1024L * 1024L * 1024L * 1024L;

            string formattedSize;

            if (bytes < kb)
            {
                formattedSize = $"{bytes} bytes";
            }
            else if (bytes < mb)
            {
                double sizeInKB = (double)bytes / kb;
                formattedSize = $"{sizeInKB:F2} KB";
            }
            else if (bytes < gb)
            {
                double sizeInMB = (double)bytes / mb;
                formattedSize = $"{sizeInMB:F2} MB";
            }
            else if (bytes < tb)
            {
                double sizeInGB = (double)bytes / gb;
                formattedSize = $"{sizeInGB:F2} GB";
            }
            else
            {
                double sizeInTB = (double)bytes / tb;
                formattedSize = $"{sizeInTB:F2} TB";
            }

            return formattedSize;
        }


        private void picGitHub_Click(object sender, EventArgs e)
        {
            // Replace "YourGitHubUsername" with your actual GitHub username
            string githubUrl = "https://github.com/NattyXO/Mega-Copy";

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

        private void pnlBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void picInfo_Click(object sender, EventArgs e)
        {
            string version = Application.ProductVersion;
            string productName = Application.ProductName;

            string message = $"{productName} Version {version}" + "\nAhadu Tech";
            MessageBox.Show(message, "Developer Info");

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void btnCopy_Click(object sender, EventArgs e)
        {
            string[] sourceFiles = txtSource.Text.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string destinationFolder = txtTarget.Text;

            bool existsInDestination = false;

            foreach (string sourceFile in sourceFiles)
            {
                string fileName = Path.GetFileName(sourceFile);
                string destinationFilePath = Path.Combine(destinationFolder, fileName);

                if (File.Exists(destinationFilePath))
                {
                    existsInDestination = true;
                    break;
                }
            }

            if (existsInDestination)
            {
                popup ss = new popup(this);
                ss.ShowDialog();

                // After the user selects an option in the Popup form, handle the action accordingly
                // For example:
                if (ss.UserOption == PopupOption.Overwrite)
                {
                    foreach (string sourceFile in sourceFiles)
                    {
                        string fileName = Path.GetFileName(sourceFile);
                        string destinationFilePath = Path.Combine(destinationFolder, fileName);

                        try
                        {
                            File.Copy(sourceFile, destinationFilePath, true);
                            lblInfo.Text = "Files copied successfully!";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}");
                        }
                    }
                    await TransferFiles(sourceFiles, destinationFolder);
                    lblInfo.Text = "All files copied and overwritten successfully!";

                }
                else if (ss.UserOption == PopupOption.OverwriteAll)
                {
                    // Implement logic for Overwrite All
                    foreach (string sourceFile in sourceFiles)
                    {
                        string fileName = Path.GetFileName(sourceFile);
                        string destinationFilePath = Path.Combine(destinationFolder, fileName);

                        try
                        {
                            File.Copy(sourceFile, destinationFilePath, true); // Overwrite existing files
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}");
                        }
                    }
                    await TransferFiles(sourceFiles, destinationFolder);
                    lblInfo.Text = "All files copied and overwritten successfully!";
                }
                else if (ss.UserOption == PopupOption.Skip)
                {
                    // Implement logic for Skip (skip the first existing file, ask for each)
                    foreach (string sourceFile in sourceFiles)
                    {
                        string fileName = Path.GetFileName(sourceFile);
                        string destinationFilePath = Path.Combine(destinationFolder, fileName);

                        if (File.Exists(destinationFilePath))
                        {
                            DialogResult dialogResult = MessageBox.Show($"File '{fileName}' already exists. Skip?", "File Exists", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                continue; // Skip this file
                            }
                            else
                            {
                                CopyFilesWithoutOverwrite(sourceFiles, destinationFolder);
                            }
                        }

                        // Copy the file if it doesn't exist in the destination or user chooses not to skip
                        try
                        {
                            File.Copy(sourceFile, destinationFilePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}");
                        }
                    }
                    TransferFilesSkip();
                    lblInfo.Text = "Copy operation completed!";


                }
                else if (ss.UserOption == PopupOption.SkipAll)
                {
                    // Implement logic for Skip All (skip all existing files)
                    foreach (string sourceFile in sourceFiles)
                    {
                        string fileName = Path.GetFileName(sourceFile);
                        string destinationFilePath = Path.Combine(destinationFolder, fileName);

                        if (File.Exists(destinationFilePath))
                        {
                            continue; // Skip this file
                        }

                        // Copy the file if it doesn't exist in the destination
                        try
                        {
                            File.Copy(sourceFile, destinationFilePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}");
                        }
                    }
                    TransferFilesSkip();
                    lblInfo.Text = "Copy operation completed!";
                }
                else if (ss.UserOption == PopupOption.KeepBoth)
                {
                    // Implement logic for Keep Both
                    foreach (string sourceFile in sourceFiles)
                    {
                        string fileName = Path.GetFileName(sourceFile);
                        string destinationFilePath = Path.Combine(destinationFolder, fileName);

                        int counter = 1;
                        while (File.Exists(destinationFilePath))
                        {
                            string newFileName = $"{Path.GetFileNameWithoutExtension(sourceFile)}_{counter}{Path.GetExtension(sourceFile)}";
                            destinationFilePath = Path.Combine(destinationFolder, newFileName);
                            counter++;
                        }

                        try
                        {
                            File.Copy(sourceFile, destinationFilePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}");
                        }
                    }
                    await TransferFiles(sourceFiles, destinationFolder);
                    lblInfo.Text = "Files copied, keeping both versions.";

                }
                else if (ss.UserOption == PopupOption.None)
                {
                    MessageBox.Show("Copy operation canceled.");
                }

            }
            else
            {
                // No existing files in the destination, proceed with the copy operation
                await TransferFiles(sourceFiles, destinationFolder);
                CopyFilesWithoutOverwrite(sourceFiles, destinationFolder);
            }

        }
        // Function to perform the copy operation without overwriting existing files
        private void CopyFilesWithoutOverwrite(string[] sourceFiles, string destinationFolder)
        {
            foreach (string sourceFile in sourceFiles)
            {
                string fileName = Path.GetFileName(sourceFile);
                string destinationFilePath = Path.Combine(destinationFolder, fileName);

                try
                {
                    File.Copy(sourceFile, destinationFilePath);
                    lblInfo.Text = "Files copied successfully!";

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private async void btnCut_Click(object sender, EventArgs e)
        {
            string[] sourceFiles = txtSource.Text.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            string destinationFolder = txtTarget.Text;

            bool existsInDestination = false;

            foreach (string sourceFile in sourceFiles)
            {
                string fileName = Path.GetFileName(sourceFile);
                string destinationFilePath = Path.Combine(destinationFolder, fileName);

                if (File.Exists(destinationFilePath))
                {
                    existsInDestination = true;
                    break;
                }
            }

            if (existsInDestination)
            {
                popup ss = new popup(this);
                ss.ShowDialog();

                // After the user selects an option in the Popup form, handle the action accordingly
                // For example:
                if (ss.UserOption == PopupOption.Overwrite)
                {
                    foreach (string sourceFile in sourceFiles)
                    {
                        string fileName = Path.GetFileName(sourceFile);
                        string destinationFilePath = Path.Combine(destinationFolder, fileName);

                        if (File.Exists(destinationFilePath))
                        {
                            try
                            {
                                File.Delete(destinationFilePath); // Delete the existing file in the destination
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"An error occurred while deleting existing file: {ex.Message}");
                                continue; // Skip moving the file if deletion fails
                            }
                        }

                        try
                        {
                            File.Move(sourceFile, destinationFilePath); // Move the file after deletion
                            lblInfo.Text = "Files moved successfully!";
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}");
                        }
                    }
                    await TransferFiles(sourceFiles, destinationFolder);
                    lblInfo.Text = "All files moved and overwritten successfully!";

                }
                else if (ss.UserOption == PopupOption.OverwriteAll)
                {
                    foreach (string sourceFile in sourceFiles)
                    {
                        string fileName = Path.GetFileName(sourceFile);
                        string destinationFilePath = Path.Combine(destinationFolder, fileName);

                        if (File.Exists(destinationFilePath))
                        {
                            try
                            {
                                File.Delete(destinationFilePath); // Delete the existing file in the destination
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show($"An error occurred while deleting existing file: {ex.Message}");
                                continue; // Skip moving the file if deletion fails
                            }
                        }

                        try
                        {
                            File.Move(sourceFile, destinationFilePath); // Move the file after deletion
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}");
                        }
                    }
                    await TransferFiles(sourceFiles, destinationFolder);
                    lblInfo.Text = "All files moved and overwritten successfully!";
                }
                else if (ss.UserOption == PopupOption.Skip)
                {
                    // Implement logic for Skip (skip the first existing file, ask for each)
                    foreach (string sourceFile in sourceFiles)
                    {
                        string fileName = Path.GetFileName(sourceFile);
                        string destinationFilePath = Path.Combine(destinationFolder, fileName);

                        if (File.Exists(destinationFilePath))
                        {
                            DialogResult dialogResult = MessageBox.Show($"File '{fileName}' already exists. Skip?", "File Exists", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                continue; // Skip this file
                            }
                            else
                            {
                                CutFilesWithoutOverwrite(sourceFiles, destinationFolder);
                            }
                        }

                        // Copy the file if it doesn't exist in the destination or user chooses not to skip
                        try
                        {
                            File.Move(sourceFile, destinationFilePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}");
                        }
                    }
                    TransferFilesSkip();
                    lblInfo.Text = "Move operation completed!";


                }
                else if (ss.UserOption == PopupOption.SkipAll)
                {
                    // Implement logic for Skip All (skip all existing files)
                    foreach (string sourceFile in sourceFiles)
                    {
                        string fileName = Path.GetFileName(sourceFile);
                        string destinationFilePath = Path.Combine(destinationFolder, fileName);

                        if (File.Exists(destinationFilePath))
                        {
                            continue; // Skip this file
                        }

                        // Copy the file if it doesn't exist in the destination
                        try
                        {
                            File.Move(sourceFile, destinationFilePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}");
                        }
                    }
                    TransferFilesSkip();
                    lblInfo.Text = "Move operation completed!";
                }
                else if (ss.UserOption == PopupOption.KeepBoth)
                {
                    // Implement logic for Keep Both
                    foreach (string sourceFile in sourceFiles)
                    {
                        string fileName = Path.GetFileName(sourceFile);
                        string destinationFilePath = Path.Combine(destinationFolder, fileName);

                        int counter = 1;
                        while (File.Exists(destinationFilePath))
                        {
                            string newFileName = $"{Path.GetFileNameWithoutExtension(sourceFile)}_{counter}{Path.GetExtension(sourceFile)}";
                            destinationFilePath = Path.Combine(destinationFolder, newFileName);
                            counter++;
                        }

                        try
                        {
                            File.Move(sourceFile, destinationFilePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred: {ex.Message}");
                        }
                    }
                    await TransferFiles(sourceFiles, destinationFolder);
                    lblInfo.Text = "Files Moved, keeping both versions.";

                }
                else if (ss.UserOption == PopupOption.None)
                {
                    MessageBox.Show("Move operation canceled.");
                }

            }
            else
            {
                // No existing files in the destination, proceed with the copy operation
                await TransferFiles(sourceFiles, destinationFolder);
                CutFilesWithoutOverwrite(sourceFiles, destinationFolder);
                
            }
        }
        private void CutFilesWithoutOverwrite(string[] sourceFiles, string destinationFolder)
        {
            foreach (string sourceFile in sourceFiles)
            {
                string fileName = Path.GetFileName(sourceFile);
                string destinationFilePath = Path.Combine(destinationFolder, fileName);

                if (!File.Exists(destinationFilePath))
                {
                    try
                    {
                        File.Move(sourceFile, destinationFilePath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred: {ex.Message}");
                    }
                }

            }
        }

        private async Task TransferFiles(string[] sourceFiles, string destinationFolder)
        {
            // Total size of all files to transfer
            long totalSize = GetTotalFileSize(sourceFiles);

            // Set the maximum value for the base progress bar
            ProgressBar1.Maximum = 100;

            // Reset progress bars and labels
            pnlProgressBar.Width = 0;
            ProgressBar1.Value = 0;
            lblProgress.Text = "0%";

            long transferredSize = 0;

            foreach (string sourceFile in sourceFiles)
            {
                try
                {
                    using (FileStream sourceStream = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
                    {
                        byte[] buffer = new byte[8192];
                        int bytesRead;
                        while ((bytesRead = await sourceStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                        {
                            transferredSize += bytesRead;

                            // Calculate percentage and update the progress bar and label
                            int percentage = (int)((double)transferredSize / totalSize * 100);
                            ProgressBar1.Value = percentage;
                            lblProgress.Text = $"{percentage}%";

                            // Update the moving progress bar
                            pnlProgressBar.Width = (int)((double)transferredSize / totalSize * ProgressBar1.Width);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }

            lblProgress.Text = "100%"; // Ensure it reaches 100% after completion
        }

        private void TransferFilesSkip()
        {
           
            // Set the maximum value for the base progress bar
            ProgressBar1.Maximum = 100;

            // Reset progress bars and labels
            pnlProgressBar.Width = 0;
            ProgressBar1.Value = 0;
            lblProgress.Text = "0%";

           // Update the moving progress bar
            pnlProgressBar.Width = ProgressBar1.Width;
             

            lblProgress.Text = "100%"; // Ensure it reaches 100% after completion
        }

    }
}
