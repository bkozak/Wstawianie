using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wstawianie.Klasy;

namespace Wstawianie
{
    public partial class Form2 : Form
    {
        public static string test;
        public Form2()
        {
            InitializeComponent();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            KartaDnia Karta = new KartaDnia();

            KartaDnia.Zupa1 = zupa1_tb.Text;
            KartaDnia.Zupa2 = zupa2_tb.Text;
            KartaDnia.Zestaw1 = zestaw1_tb.Text;
            KartaDnia.Zestaw2 = zestaw2_tb.Text;
            KartaDnia.Danie1 = danie1_tb.Text;
            KartaDnia.Danie2 = danie2_tb.Text;
            KartaDnia.Danie3 = danie3_tb.Text;

            Form1 gotowa = new Form1();

            gotowa.Show();
        }
    }
}
