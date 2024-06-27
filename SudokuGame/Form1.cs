using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace SudokuGame
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            kutuOlustur();
            yeniOyunaBasla();
        }
        class SudokuKutusu : Button
        {
            public int Value { get; set; }
            public bool SeciliMi { get; set; }
            public int X { get; set; }
            public int Y { get; set; }
            public void Temizle()
            {
                this.Text = string.Empty;
                this.SeciliMi = false;
            }
        }
        SudokuKutusu[,] kutular = new SudokuKutusu[9, 9];
        private void kutuOlustur()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    kutular[i, j] = new SudokuKutusu();
                    kutular[i, j].Font = new Font(SystemFonts.DefaultFont.FontFamily, 20);
                    kutular[i, j].Size = new Size(40, 40);
                    kutular[i, j].ForeColor = SystemColors.ControlDarkDark;
                    kutular[i, j].Location = new Point(i * 40, j * 40);
                    kutular[i, j].BackColor = ((i / 3) + (j / 3)) % 2 == 0 ? SystemColors.Control : Color.LightGray;
                    kutular[i, j].FlatStyle = FlatStyle.Flat;
                    kutular[i, j].FlatAppearance.BorderColor = Color.Black;
                    kutular[i, j].X = i;
                    kutular[i, j].Y = j;

                    kutular[i, j].KeyPress += kutu_keyPressed;

                    panel1.Controls.Add(kutular[i, j]);
                }
            }
        }
        private void kutu_keyPressed(object sender, KeyPressEventArgs e)
        {
            var kutu = sender as SudokuKutusu;

            if (kutu.SeciliMi)
                return;

            int value;

            if (int.TryParse(e.KeyChar.ToString(), out value))
            {
                if (value == 0)
                    kutu.Temizle();
                else
                    kutu.Text = value.ToString();

                kutu.ForeColor = SystemColors.ControlDarkDark;
            }
        }
        private void yeniOyunaBasla()
        {
            degerleriGetir();

            var ipucuSayisi = 0;

            if (radioButtonKolay.Checked)
                ipucuSayisi = 45;
            else if (radioButtonOrta.Checked)
                ipucuSayisi = 30;
            else if (radioButtonZor.Checked)
                ipucuSayisi = 15;

            ipucuGoster(ipucuSayisi);
        }
        private void ipucuGoster(int ipucuSayisi)
        {
            for (int i = 0; i < ipucuSayisi; i++)
            {
                var rX = random.Next(9);
                var rY = random.Next(9);

                kutular[rX, rY].Text = kutular[rX, rY].Value.ToString();
                kutular[rX, rY].ForeColor = Color.Black;
                kutular[rX, rY].SeciliMi = true;
            }
        }
        private void degerleriGetir()
        {
            foreach (var kutu in kutular)
            {
                kutu.Value = 0;
                kutu.Temizle();
            }

            gelecekKutununDegeriniBul(0, -1);
        }

        Random random = new Random();

        private bool gelecekKutununDegeriniBul(int i, int j)
        {
            if (++j > 8)
            {
                j = 0;

                if (++i > 8)
                    return true;
            }

            var value = 0;
            var kalanNumaralar = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            do
            {
                if (kalanNumaralar.Count < 1)
                {
                    kutular[i, j].Value = 0;
                    return false;
                }
                value = kalanNumaralar[random.Next(0, kalanNumaralar.Count)];
                kutular[i, j].Value = value;

                kalanNumaralar.Remove(value);
            }
            while (!sayiGecerliMi(value, i, j) || !gelecekKutununDegeriniBul(i, j));

            return true;
        }
        private bool sayiGecerliMi(int value, int x, int y)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i != y && kutular[x, i].Value == value)
                    return false;

                if (i != x && kutular[i, y].Value == value)
                    return false;
            }
            for (int i = x - (x % 3); i < x - (x % 3) + 3; i++)
            {
                for (int j = y - (y % 3); j < y - (y % 3) + 3; j++)
                {
                    if (i != x && j != y && kutular[i, j].Value == value)
                        return false;
                }
            }
            return true;
        }
        private void btnKontrol_Click(object sender, EventArgs e)
        {
            var yanlisCevap = new List<SudokuKutusu>();

            foreach (var kutu in kutular)
            {
                if (!string.Equals(kutu.Value.ToString(), kutu.Text))
                {
                    yanlisCevap.Add(kutu);
                }
            }

            if (yanlisCevap.Any())
            {
                yanlisCevap.ForEach(x => x.ForeColor = Color.Red);
                MessageBox.Show("Yanlis Cevap");
            }
            else
            {
                MessageBox.Show("Kazandýnýz!");
            }
        }
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (var kutu in kutular)
            {
                if (kutu.SeciliMi == false)
                    kutu.Temizle();
            }
        }

        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            yeniOyunaBasla();
        }

    }
}