using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace kutuphane
{
    
    public partial class kitapEkle : Form
    {
        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=kitaplar;Uid=root;Pwd='';");
        MySqlCommand cmd;
        public kitapEkle()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int kitapId = rnd.Next(111111,999999);
                string kitapAdi = kitapAdiTextBox.Text;
                string kitapYazar = kitapYazarTextBox.Text;
                string sayfaSayisi = sayfaSayisiTextBox.Text;
                string baskiYili = baskiYiliTextBox.Text;
                string yayinEvi = yayinEviTextBox.Text;
                string dil = dilTextBox.Text;
                string konu = konuMultiTextBox.Text;
                cmd = new MySqlCommand();
                mysqlbaglan.Open();
                cmd.Connection = mysqlbaglan;
                cmd.CommandText = "INSERT INTO kitaplar (kitapID, kitapAdi, yazari, sayfaSayisi, yayinEvi, baskiYili, dil,konu) " +
                    "VALUES ('"+kitapId+"', '"+kitapAdi+"', '"+kitapYazar+"', '"+sayfaSayisi+"', '"+yayinEvi+"', '"+baskiYili+"', '"+dil+ "', '" + konu + "')";
                
                int eklendi = cmd.ExecuteNonQuery();
                if (eklendi>0)
                {
                    MessageBox.Show("Başarılı");
                }
                else
                {
                    MessageBox.Show("Başarısız!");
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Hata! " + err.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            mysqlbaglan.Close();
        }
    }
}
