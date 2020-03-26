using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void kitaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Dispose(false);//geçerli form kapanır.
            kitapEkle form2 = new kitapEkle();
            //form2.MdiParent = this;
            form2.Show();
        }
        private void buttonUyelikEkle_Click(object sender, EventArgs e)
        {
            uyeEkle form3 = new uyeEkle();
            form3.Show();
        }

        private void buttonEmanetEkle_Click(object sender, EventArgs e)
        {
            emanetEkle form4 = new emanetEkle();
            form4.Show();
        }

        private void buttonKitapListele_Click(object sender, EventArgs e)
        {
            kitapListele form5 = new kitapListele();
            form5.Show();
        }

        private void buttonEmanetListele_Click(object sender, EventArgs e)
        {
            emanetListele form6 = new emanetListele();
            form6.Show();
        }

        private void buttonUyeListele_Click(object sender, EventArgs e)
        {
            uyeListele form7 = new uyeListele();
            form7.Show();
        }
    }
}
