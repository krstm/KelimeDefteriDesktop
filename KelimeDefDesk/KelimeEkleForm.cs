using System;
using System.IO;
using System.Windows.Forms;

namespace KelimeDefDesk
{
    public partial class KelimeEkleForm : Form
    {
        public KelimeEkleForm()
        {
            InitializeComponent();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void KelimeEkleForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void geriDonButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AnaForm anaForm = new AnaForm();
            anaForm.Show();
        }

        public void ekleButton_Click(object sender, EventArgs e)
        {
            if(kelimeTextBox.Text!="")
            {
                kelimeListBox.Items.Add(kelimeTextBox.Text);
                karsilikListBox.Items.Add(karsilikTextBox.Text);
            }
            else
            {
                bildirimTxt.Text = "tüm alanlar doldurulmalı";
            }
            
        }

        private void kelimeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            karsilikListBox.SelectedIndex = kelimeListBox.SelectedIndex;
        }

        private void karsilikListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            kelimeListBox.SelectedIndex = karsilikListBox.SelectedIndex;
        }

        private int selInd = 0;

        private void silButton_Click(object sender, EventArgs e)
        {
            if (kelimeListBox.SelectedIndex != -1)
            {
                selInd = kelimeListBox.SelectedIndex;
                kelimeListBox.Items.RemoveAt(selInd);
                karsilikListBox.Items.RemoveAt(selInd);
            }
        }

        public void DosyayaYaz()
        {
            string kelimePath = "kelimeler.txt";
            string karsilikPath = "karsilik.txt";

            File.WriteAllText(kelimePath, String.Empty);
            File.WriteAllText(karsilikPath, String.Empty);

            FileStream fs = new FileStream(kelimePath, FileMode.OpenOrCreate, FileAccess.Write);
            FileStream fs2 = new FileStream(karsilikPath, FileMode.OpenOrCreate, FileAccess.Write);

            StreamWriter sw = new StreamWriter(fs);
            StreamWriter sw2 = new StreamWriter(fs2);

            foreach (string item in kelimeListBox.Items)
            {
                sw.WriteLine(item);
            }
            foreach (string item in karsilikListBox.Items)
            {
                sw2.WriteLine(item);
            }

            sw.Flush();
            sw.Close();
            fs.Close();
            sw2.Flush();
            sw2.Close();
            fs2.Close();
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            DosyayaYaz();
            bildirimLabel.Text = "Kaydedildi";
        }

        private void KelimeEkleForm_Load(object sender, EventArgs e)
        {
            kelimeleriOku();
        }

        public void kelimeleriOku()
        {
            string kelimePath = "kelimeler.txt";
            string karsilikPath = "karsilik.txt";
            if (File.Exists(kelimePath) && File.Exists(karsilikPath))
            {
                

                var lines = File.ReadAllLines(kelimePath);
                for (var i = 0; i < lines.Length; i += 1)
                {
                    var line = lines[i];
                    kelimeListBox.Items.Add(line);
                }

                var lines2 = File.ReadAllLines(karsilikPath);
                for (var i2 = 0; i2 < lines.Length; i2 += 1)
                {
                    var line2 = lines2[i2];
                    karsilikListBox.Items.Add(line2);
                }

                
            }
        }
    }
}