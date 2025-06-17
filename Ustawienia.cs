using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;

namespace Lab6_Dydelf
{
    public partial class Ustawienia : Form
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public int czas { get; private set; }

        public int dydlefy { get; private set; }

        public int krokodyle { get; private set; }

        public int szopy { get; private set; }
        public Ustawienia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            X = int.Parse(textBox1.Text);
            Y = int.Parse(textBox2.Text);
            dydlefy = int.Parse(textBox4.Text);
            krokodyle = int.Parse(textBox3.Text);
            czas = int.Parse(textBox5.Text);
            szopy = int.Parse(textBox6.Text);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
