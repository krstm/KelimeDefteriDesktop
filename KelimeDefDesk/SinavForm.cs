using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace KelimeDefDesk
{
    public partial class SinavForm : Form
    {
        public SinavForm()
        {
            InitializeComponent();
        }

        public Random rnd = new Random();
        public Random rnd2 = new Random();

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void SinavForm_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
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

        public string[] kelimeListe;
        public string[] karsilikListe;

        public void kelimeleriOku()
        {
            string kelimePath = "kelimeler.txt";
            string karsilikPath = "karsilik.txt";
            if (File.Exists(kelimePath) && File.Exists(karsilikPath))
            {
                var lines = File.ReadAllLines(kelimePath);
                kelimeListe = new string[lines.Length];
                for (var i = 0; i < lines.Length; i += 1)
                {
                    var line = lines[i];
                    kelimeListe[i] = line;
                }

                var lines2 = File.ReadAllLines(karsilikPath);
                karsilikListe = new string[lines2.Length];
                for (var i2 = 0; i2 < lines.Length; i2 += 1)
                {
                    var line2 = lines2[i2];
                    karsilikListe[i2] = line2;
                }
            }
        }

        private void SinavForm_Load(object sender, EventArgs e)
        {
            kelimeleriOku();
            KelimeDagit();
        }

        public int dogruCevap;
        public int[] yanlisCevaplar = new int[3];

        Random rng = new Random();

        public void Shuffle(List<string> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
        public void KelimeDagit()
        {
            if (kelimeListe.Length >= 5)
            {
                dogruCevap = rnd.Next(0, kelimeListe.Length);
                for (int i = 0; i < 3; i++)
                {
                basadon:
                    yanlisCevaplar[i] = rnd2.Next(0, kelimeListe.Length);
                    if (yanlisCevaplar[i] == dogruCevap)
                    {

                        goto basadon;
                    }
                }


            }
            soruButton.Text = karsilikListe[dogruCevap];

            

        List<string> cevaplar = new List<string>();
            cevaplar.Add(kelimeListe[dogruCevap]);
            cevaplar.Add(kelimeListe[yanlisCevaplar[0]]);
            cevaplar.Add(kelimeListe[yanlisCevaplar[1]]);
            cevaplar.Add(kelimeListe[yanlisCevaplar[2]]);

            Shuffle(cevaplar);


            cevap1Button.Text = cevaplar[0];
            cevap2Button.Text = cevaplar[1];
            cevap3Button.Text = cevaplar[2]; 
            cevap4Button.Text = cevaplar[3];
        }

        int puan = 0;

        private void ileriButton_Click(object sender, EventArgs e)
        {
            if (cevap1Button.BackColor == Color.Black && cevap1Button.BackColor == Color.Black && cevap2Button.BackColor == Color.Black && cevap3Button.BackColor == Color.Black && cevap4Button.BackColor == Color.Black)
            {

            }
            else
            {
                SiklariDuzelt();
                KelimeDagit();
                dogruCevapLabel.Text = "";
                SiklariAc();
            }
            
        }
        System.Drawing.Color col = System.Drawing.ColorTranslator.FromHtml("#400000");
        private void cevapButton_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Text == kelimeListe[dogruCevap])
            {
                b.BackColor = Color.Green;
                puan = puan + 20;
                puanLabel.Text = "puan: " + puan;
                SiklariKilitle();
            }
            else
            {
                b.BackColor = Color.Red;
                puan = puan - 200;
                puanLabel.Text = "puan: " + puan;
                dogruCevapLabel.Text = kelimeListe[dogruCevap];
                SiklariKilitle();
            }
        }
        public void SiklariDuzelt()
        {
            cevap1Button.BackColor = col;
            cevap2Button.BackColor = col;
            cevap3Button.BackColor = col;
            cevap4Button.BackColor = col;

        }
        public void SiklariKilitle()
        {
            cevap1Button.Enabled = false;
            cevap2Button.Enabled = false;
            cevap3Button.Enabled = false;
            cevap4Button.Enabled = false;
            ileriButton.Visible = true;
        }
        public void SiklariAc()
        {
            cevap1Button.Enabled = true;
            cevap2Button.Enabled = true;
            cevap3Button.Enabled = true;
            cevap4Button.Enabled = true;
            ileriButton.Visible = false;
        }
    }
}