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
    public partial class kitapListele : Form
    {
        private MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=kitaplar;Uid=root;Pwd='';");
        MySqlCommand cmd;
        MySqlDataReader dr;
        public kitapListele()
        {
            InitializeComponent();
        }

        private void kitapListele_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();//Tablo oluşturduk.
            table.Columns.Add("Kitap ID");//Kolon eklemek
            table.Columns.Add("Kitabın Adı");
            table.Columns.Add("Kitabın Yazarı");
            table.Columns.Add("Sayfa Sayısı");
            table.Columns.Add("Yayın Evi");
            table.Columns.Add("Baskı Yılı");
            table.Columns.Add("Kitabın Dili");
            table.Columns.Add("Kitabın Konusu");
            try
            {
                cmd = new MySqlCommand();
                cmd.Connection = mysqlbaglan;
                mysqlbaglan.Open();
                cmd.CommandText = "SELECT * FROM kitaplar";
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DataRow row = table.NewRow();//Tablo için Satır.
                    row["Kitap ID"] = dr["kitapID"].ToString();
                    row["Kitabın Adı"] = dr["kitapAdi"].ToString();
                    row["Kitabın Yazarı"] = dr["yazari"].ToString();
                    row["Sayfa Sayısı"] = dr["sayfaSayisi"].ToString();
                    row["Yayın Evi"] = dr["yayinEvi"].ToString();
                    row["Baskı Yılı"] = dr["baskiYili"].ToString();
                    row["Kitabın Dili"] = dr["dil"].ToString();
                    row["Kitabın Konusu"] = dr["konu"].ToString();
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
