using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        public popup()
        {
            InitializeComponent();
            Size = new Size(453, 230);
            StartPosition = FormStartPosition.Manual;
            Location = new Point(10, 10); // or Cursor.Position if you want to set it to cursor position
        }

        public string LabelText
        {
            get
            {
                return this.lblConfirmation.Text;
            }
            set
            {
                this.lblConfirmation.Text = value;
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
