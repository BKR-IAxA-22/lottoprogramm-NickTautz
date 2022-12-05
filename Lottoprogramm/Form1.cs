using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottoprogramm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        int[] zahlen = new int[6];
        Random random = new Random();
        
        private void ausloser_Click(object sender, EventArgs e)
        {
           
            for (int i = 0; i < zahlen.Length; i++)
            {
                
                int x = random.Next(1,49);
                if (zahlen.Contains(x))
                {
                    i--;
                }
                else
                {
                    zahlen[i] = x;  
                }
            }

            zahl1.Text = Convert.ToString(zahlen[0]);
            zahl2.Text = Convert.ToString(zahlen[1]);
            zahl3.Text = Convert.ToString(zahlen[2]);
            zahl4.Text = Convert.ToString(zahlen[3]);
            zahl5.Text = Convert.ToString(zahlen[4]);
            zahl6.Text = Convert.ToString(zahlen[5]);
            
        }

        private void zahl1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void zahl2_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void zahl3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void zahl4_TextChanged(object sender, EventArgs e)
        {
 
        }

        private void zahl5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void zahl6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          


        }

        private void eingabe_zahl1_TextChanged(object sender, EventArgs e)
        {

        }

        private void eingabe_zahl2_TextChanged(object sender, EventArgs e)
        {

        }

        private void eingabe_zahl3_TextChanged(object sender, EventArgs e)
        {

        }

        private void eingabe_zahl4_TextChanged(object sender, EventArgs e)
        {

        }

        private void eingabe_zahl5_TextChanged(object sender, EventArgs e)
        {

        }

        private void eingabe_zahl6_TextChanged(object sender, EventArgs e)
        {

        }
    }
   
}
