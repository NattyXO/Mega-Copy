using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace copyer
{
    public enum PopupOption
    {
        None,
        Overwrite,
        OverwriteAll,
        Skip,
        SkipAll,
        KeepBoth
    }
    public partial class popup : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // Property to store the user's selected option
        public PopupOption UserOption { get; private set; }

        private Form1 parentForm;

        public popup(Form1 form1)
        {
            InitializeComponent();
            parentForm = form1;
            
            List<string> existingFiles = parentForm.ExistingFiles;

            foreach (string filePath in existingFiles)
            {
                FileInfo fileInfoSource = new FileInfo(filePath);

                // Now you can use fileInfo to access properties of each individual file
                // For example:
                DateTime createdDateTime = fileInfoSource.CreationTime;
                string fileName = fileInfoSource.Name;
                string fileDirectory = fileInfoSource.DirectoryName;
                // ... and so on
                //file size
                long fileSizeInBytes = fileInfoSource.Length;

                string fileSizeFormatted = FormatFileSize(fileSizeInBytes);
                lblFile1Size.Text = fileSizeFormatted;

                lblFile1Name.Text = fileName;

                lblFile1Location.Text = fileDirectory;

                lblFile1CreatedDateAndTime.Text = $"{createdDateTime}";

                // File icon
                Icon fileIcon = Icon.ExtractAssociatedIcon(fileInfoSource.FullName);
                Image fileImage = fileIcon.ToBitmap();
                picFile1Logo.Image = fileImage;

            }

            List<string> existingFilesDestination = parentForm.ExistingFilesInDestination;

            foreach (string filePath in existingFilesDestination)
            {
                FileInfo fileInfoDestination = new FileInfo(filePath);

                // Now you can use fileInfo to access properties of each individual file
                // For example:
                DateTime createdDateTime = fileInfoDestination.CreationTime;
                string fileName = fileInfoDestination.Name;
                string fileDirectory = fileInfoDestination.DirectoryName;
                // ... and so on
                //file size
                long fileSizeInBytes = fileInfoDestination.Length;

                string fileSizeFormatted = FormatFileSize(fileSizeInBytes);
              
                if (lblFile1Size.Text == fileSizeFormatted)
                {
                    lblFilesTheSameSize.Text = "Same Size";
                }else
                {
                    lblFilesTheSameSize.Text = "Different Size";
                }

                if(lblFile1CreatedDateAndTime.Text == $"{createdDateTime}")
                {
                    lblFilesCreatedTheSameDate.Text = "Same Date";
                }
                else
                {
                    lblFilesCreatedTheSameDate.Text = "Different Date";
                }

                lblFile2Name.Text = fileName;
                lblFile2Location.Text = fileDirectory;

                // File icon
                Icon fileIcon = Icon.ExtractAssociatedIcon(fileInfoDestination.FullName);
                Image fileImage = fileIcon.ToBitmap();
                picFile2Logo.Image = fileImage;


            }


        }

        private string FormatFileSize(long bytes)
        {
            const int kb = 1024;
            const int mb = 1024 * 1024;
            const int gb = 1024 * 1024 * 1024;

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
            else
            {
                double sizeInGB = (double)bytes / gb;
                formattedSize = $"{sizeInGB:F2} GB";
            }

            return formattedSize;
        }

        private void pnlBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            UserOption = PopupOption.None;
            this.Close();
        }

        private void picOverwrite_Click(object sender, EventArgs e)
        {
            UserOption = PopupOption.Overwrite;
            this.Close(); // Close the popup after selection (you can handle this differently based on your flow)
        }

        private void picOverwriteAll_Click(object sender, EventArgs e)
        {
            UserOption = PopupOption.OverwriteAll;
            this.Close();
        }

        private void picSkip_Click(object sender, EventArgs e)
        {
            UserOption = PopupOption.Skip;
            this.Close();
        }

        private void picSkipAll_Click(object sender, EventArgs e)
        {
            UserOption = PopupOption.SkipAll;
            this.Close();
        }

        private void picKeepBoth_Click(object sender, EventArgs e)
        {
            UserOption = PopupOption.KeepBoth;
            this.Close();
        }
    }
}
