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
    public partial class emanetEkle : Form
    {
        private MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=kitaplar;Uid=root;Pwd='';");
        MySqlCommand cmd;
        MySqlDataReader dr;

        public emanetEkle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Random rnd = new Random();
                int emanetId = rnd.Next(11111, 99999);
                string uyeTC = uyeTcTextBox.Text;
                string kitapAdi = kitapSecComboBox.SelectedItem.ToString();
                string kitapId="";
                cmd.CommandText = "SELECT kitapID FROM kitaplar WHERE kitapAdi='" + kitapAdi + "'";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    kitapId=""+dr["kitapId"].ToString();
                }
                dr.Close();
                //kitapId = "303769";
                string verilisTarihi = verilisTarihiDatePicker.Value.ToString("yyyy-MM-dd");
                string geriAlinmaTarihi = geriAlinmaTarihiDatePicker.Value.ToString("yyyy-MM-dd");
                cmd.CommandText = "INSERT INTO emanet (emanetID, uyeTC, kitapID, verilisTarihi, geriAlinmaTarihi, teslimEdildi) " +
                    "VALUES ('" + emanetId + "', '" + uyeTC + "', '" + kitapId + "', '" + verilisTarihi + "', '" + geriAlinmaTarihi + "', '0')";
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
            dr.Close();
            //mysqlbaglan.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            verilisTarihiDatePicker.Format = DateTimePickerFormat.Custom;
            verilisTarihiDatePicker.CustomFormat = "dd-MM-yyyy";
            geriAlinmaTarihiDatePicker.Format = DateTimePickerFormat.Custom;
            geriAlinmaTarihiDatePicker.CustomFormat = "dd-MM-yyyy";
            verilisTarihiDatePicker.MaxDate = DateTime.Now;
            geriAlinmaTarihiDatePicker.MinDate = DateTime.Now.AddDays(1);
            geriAlinmaTarihiDatePicker.MaxDate = DateTime.Now.AddDays(14);
            try
            {
                cmd = new MySqlCommand();
                cmd.Connection = mysqlbaglan;
                mysqlbaglan.Open();
                cmd.CommandText = "SELECT * FROM kitaplar";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    kitapSecComboBox.Items.Add(dr["kitapAdi"].ToString());
                }            }
            catch (Exception err)
            {
                MessageBox.Show("Hata! " + err.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dr.Close();
        }
    }
}
