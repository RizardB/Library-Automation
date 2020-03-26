using MySql.Data.MySqlClient;
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
    public partial class uyeEkle : Form
    {
        private MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=kitaplar;Uid=root;Pwd='';");
        MySqlCommand cmd;
        public uyeEkle()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string uyeTC = uyeTcTextBox.Text;
                string uyeAdi = uyeAdiTextBox.Text;
                string uyeSoyadi = uyeSoyadiTextBox.Text;
                string uyeTelefon = uyeTelefonTextBox.Text;
                string uyeEposta = uyeEpostaTextBox.Text;
                cmd = new MySqlCommand();
                mysqlbaglan.Open();
                cmd.Connection = mysqlbaglan;
                cmd.CommandText = "INSERT INTO uyeler (uyeTc, uyeAdi, uyeSoyad, uyeEposta, uyeTelefon) " +
                    "VALUES ('" + uyeTC + "', '" + uyeAdi + "', '" + uyeSoyadi + "', '" + uyeEposta + "', '" + uyeTelefon + "')";
                int eklendi = cmd.ExecuteNonQuery();
                if (eklendi > 0)
                {
                    MessageBox.Show("Başarılı");
                }
                else
                {
                    MessageBox.Show("Başarısız!");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata! " + err.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            mysqlbaglan.Close();
        }
    }
}
