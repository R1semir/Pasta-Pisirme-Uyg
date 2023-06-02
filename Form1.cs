using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasta_Pişirme_Uyg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //20-40-60-80-100 kırmızı
        //10-30-50-70-90 turkuaz
        private void timer1_Tick(object sender, EventArgs e)
        //timer 1
        {
            progressBar1.Value += 10;
            if (progressBar1.Value % 20 == 10)
            {
                label1.BackColor = Color.Aqua;
            }
            if (progressBar1.Value % 20 == 0)
            {
                label1.BackColor = Color.Red;
            }
            if (progressBar1.Value == 100)
            {

                timer1.Stop();
                MessageBox.Show("Un Ve Yumurta Karıştırıldı :)");
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        //timer 2
        {
            progressBar2.Value += 5;
            if (progressBar2.Value % 10 == 0)
            {
                label2.BackColor = Color.Red;
            }
            if (progressBar2.Value % 10 == 5)
            {
                label2.BackColor = Color.Aqua;
            }
            if (progressBar2.Value == 100)
            {

                timer2.Stop();
                MessageBox.Show("Çırpma İşlemi Tamamlandı :)");
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        //timer 3
        {
            progressBar3.Value += 20;
            if (progressBar3.Value % 20 == 10)
            {
                label3.BackColor = Color.Aqua;
            }
            if (progressBar3.Value % 20 == 0)
            {
                label3.BackColor = Color.Red;
            }
            if (progressBar3.Value == 100)
            {
                timer3.Stop();
                MessageBox.Show("Malzemeler Eklendi Ve Karıştırıldı :)");
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        //timer 4
        {
            progressBar4.Value++;
            if (progressBar4.Value % 2 == 0)
            {
                label4.BackColor = Color.Red;
            }
            if(progressBar4.Value%2==1)
            {
                label4.BackColor = Color.Aqua;
            }
                if(progressBar4.Value==100)
            {  
                timer4.Stop();
                MessageBox.Show("Pasta Pişirildi :)");
            }
        }
       
        
    }
}
