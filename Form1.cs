using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        int fiyat;
        double etiketfiyat;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            fiyat = Convert.ToInt32(textBox1.Text);
            etiketfiyat =fiyat +(fiyat * 25 / 100);
            label3.Text = etiketfiyat.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            etiketfiyat = fiyat + (fiyat * 30 / 100);
            label3.Text = etiketfiyat.ToString();

        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            etiketfiyat = fiyat * 0.7;
            label3.Text = etiketfiyat.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            etiketfiyat = fiyat * 25 / 100;
            label3.Text = etiketfiyat.ToString();
        }
    }
}
