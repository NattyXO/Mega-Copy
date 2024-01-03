using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string lblSource = parentForm.FileSourceLocationText;
            

            // Get file information using FileInfo
            FileInfo fileInfoSource = new FileInfo(lblSource);

            //file size
            long fileSizeInBytes = fileInfoSource.Length;

            string fileSizeFormatted = FormatFileSize(fileSizeInBytes);
            lblFile1Size.Text = fileSizeFormatted;

            // File name
            string fileName = fileInfoSource.Name;
            lblFile1Name.Text = fileName;

            // File location (directory)
            string fileDirectory = fileInfoSource.DirectoryName;
            lblFile1Location.Text = fileDirectory;

            // Created date and time
            DateTime createdDateTime = fileInfoSource.CreationTime;
            lblFile1CreatedDateAndTime.Text = $"{createdDateTime}";


            // File icon
            Icon fileIcon = Icon.ExtractAssociatedIcon(lblSource);
            Image fileImage = fileIcon.ToBitmap();
            picFile1Logo.Image = fileImage;

            string lblTarget = parentForm.FileTargetLocationText + "\\" + fileName;

            // Get file information using FileInfo
            FileInfo fileInfoTarget = new FileInfo(lblTarget);

            //file size
            long fileSizeInBytesTarget = fileInfoTarget.Length;
            string fileSizeFormattedTarget = FormatFileSize(fileSizeInBytes);

            if (lblFile1Size.Text == fileSizeFormattedTarget)
            {
                lblFilesTheSameSize.Text = "Same Size";
            }else
            {
                lblFilesTheSameSize.Text = "Different Size";
            }
           

            // File name
            string fileNameTarget = fileInfoTarget.Name;
            lblFile2Name.Text = fileName;

            // File location (directory)
            string fileDirectoryTarget = fileInfoTarget.DirectoryName;
            lblFile2Location.Text = fileDirectory;


            // Created date and time
            DateTime createdDateTimeTarget = fileInfoTarget.CreationTime.Date;

           
            if (DateTime.TryParse(lblFile1CreatedDateAndTime.Text, out createdDateTime))
            {
                // Comparison between label's Date and createdDateTimeTarget's Date
                if (createdDateTime.Date == createdDateTimeTarget)
                {
                    lblFilesCreatedTheSameDate.Text = "Same Date";
                }
                else
                {
                    lblFilesCreatedTheSameDate.Text = "Different Date";
                }
            }

            // File icon
            Icon fileIconTarget = Icon.ExtractAssociatedIcon(lblTarget);
            Image fileImageTarget = fileIcon.ToBitmap();
            picFile2Logo.Image = fileImage;
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
