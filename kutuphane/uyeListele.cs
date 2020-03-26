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
    public partial class uyeListele : Form
    {
        private MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=kitaplar;Uid=root;Pwd='';");
        MySqlCommand cmd;
        MySqlDataReader dr;
        public uyeListele()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();//Tablo oluşturduk.
            table.Columns.Add("Üye TC");
            table.Columns.Add("Adı");
            table.Columns.Add("Soyadı");
            table.Columns.Add("Eposta");
            table.Columns.Add("Telefon Numarası");
            try
            {
                cmd = new MySqlCommand();
                cmd.Connection = mysqlbaglan;
                mysqlbaglan.Open();
                cmd.CommandText = "SELECT * FROM uyeler";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DataRow row = table.NewRow();//Tablo için Satır.
                    row["Üye TC"] = dr["uyeTC"].ToString();
                    row["Adı"] = dr["uyeAdi"].ToString();
                    row["Soyadı"] = dr["uyeSoyad"].ToString();
                    row["Eposta"] = dr["uyeEposta"].ToString();
                    row["Telefon Numarası"] = dr["uyeTelefon"].ToString();
                    table.Rows.Add(row);//Tabloya ekledik
                    //gridControl1.DataSource = table;
                    dataGridView1.DataSource = table;
                    //dataGridView1.DefaultCellStyle.BackColor=Color.DarkTurquoise;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Hata! " + err.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dr.Close();
        }
    }
}
