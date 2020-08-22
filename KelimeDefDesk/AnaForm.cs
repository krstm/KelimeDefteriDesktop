using System;
using System.IO;
using System.Windows.Forms;

namespace KelimeDefDesk
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            SinavForm sinavForm = new SinavForm();
        }

        public void butonlariGizle()
        {
            kelimeEkleButton.Hide();
            sinavButton.Hide();
            cikisButton.Hide();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void AnaForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void kelimeEkleButton_Click(object sender, EventArgs e)
        {
            KelimeEkleForm kelimeEkleForm = new KelimeEkleForm();
            this.Hide();
            butonlariGizle();
            kelimeEkleForm.Show();
        }

        
        
        private void sinavButton_Click(object sender, EventArgs e)
        {
            
            SinavForm sinavForm = new SinavForm();
            this.Hide();
            butonlariGizle();
            sinavForm.Show();

            
        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        
    }
}