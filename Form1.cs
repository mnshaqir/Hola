using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (HolaLabel.Text == "Hola Amigos")
            {
                HolaLabel.Text = "Hai Semua";
            }
            else if (HolaLabel.Text == "Hai Semua")
            {
                HolaLabel.Text = "Apa Khabar";
            }
            else if (HolaLabel.Text == "Apa Khabar")
            {
                HolaLabel.Text = "Dah makan ?";
            }
            else 
            {
                HolaLabel.Text = "Hola Amigos";
            }
        }
    }
}
