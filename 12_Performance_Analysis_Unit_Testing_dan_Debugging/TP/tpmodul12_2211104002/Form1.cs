using System;
using System.Windows.Forms;

namespace tpmodul12_2211104002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtInput.Text, out int nilai))
            {
                string hasil = CariTandaBilangan(nilai);
                lblHasil.Text = $"Bilangan tersebut adalah: {hasil}";
            }
            else
            {
                lblHasil.Text = "Input tidak valid!";
            }
        }

        public string CariTandaBilangan(int a)
        {
            if (a < 0)
                return "Negatif";
            else if (a > 0)
                return "Positif";
            else
                return "Nol";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
