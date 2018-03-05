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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            zupa1.BackColor = Color.Transparent;


            zupa1.Text = KartaDnia.Zupa1;
            zupa2.Text = KartaDnia.Zupa2;
            zestaw1.Text = KartaDnia.Zestaw1;
            zestaw2.Text = KartaDnia.Zestaw2;
            danie1.Text = KartaDnia.Danie1;
            danie2.Text = KartaDnia.Danie2;
            danie3.Text = KartaDnia.Danie3;

            zupa1.Parent = pictureBox1;
            zupa1.BackColor = Color.Transparent;
            zupa2.Parent = pictureBox1;
            zupa2.BackColor = Color.Transparent;
            zestaw1.Parent = pictureBox1;
            zestaw1.BackColor = Color.Transparent;
            zestaw2.Parent = pictureBox1;
            zestaw2.BackColor = Color.Transparent;
            danie1.Parent = pictureBox1;
            danie1.BackColor = Color.Transparent;
            danie2.Parent = pictureBox1;
            danie2.BackColor = Color.Transparent;
            danie3.Parent = pictureBox1;
            danie3.BackColor = Color.Transparent;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

\\test
test2
    }
}
