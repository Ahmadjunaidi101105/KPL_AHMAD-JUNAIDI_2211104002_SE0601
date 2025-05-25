using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul12_2211104002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Method untuk menghitung pangkat dengan aturan khusus
        private int CariNilaiPangkat(int a, int b)
        {
            if (b == 0)
                return 1;
            if (b < 0)
                return -1;
            if (b > 10 || a > 100)
                return -2;

            try
            {
                int hasil = 1;
                checked
                {
                    for (int i = 0; i < b; i++)
                    {
                        hasil *= a;
                    }
                }
                return hasil;
            }
            catch (OverflowException)
            {
                return -3;
            }
        }

        // Event saat tombol diklik
        private void btnHitung_Click(object sender, EventArgs e)
        {
            int a, b;

            if (int.TryParse(textBoxA.Text, out a) && int.TryParse(textBoxB.Text, out b))
            {
                int hasil = CariNilaiPangkat(a, b);
                labelHasil.Text = $"Hasil: {hasil}";
            }
            else
            {
                labelHasil.Text = "Input tidak valid!";
            }
        }

        // Tidak digunakan, boleh dihapus jika tidak dipakai
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
