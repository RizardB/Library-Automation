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
    public partial class emanetListele : Form
    {
        private MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=kitaplar;Uid=root;Pwd='';");
        MySqlCommand cmd;
        MySqlDataReader dr;
        public emanetListele()
        {
            InitializeComponent();
        }

        private void emanetListele_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();//Tablo oluşturduk.
            table.Columns.Add("Emanet ID");//Kolon eklemek
            table.Columns.Add("Üye TC");
            table.Columns.Add("Kitap ID");
            table.Columns.Add("Veriliş Tarihi");
            table.Columns.Add("Geri Alınma Tarihi");
            table.Columns.Add("Teslim Edildi Mi?");
            try
            {
                cmd = new MySqlCommand();
                cmd.Connection = mysqlbaglan;
                mysqlbaglan.Open();
                cmd.CommandText = "SELECT * FROM emanet WHERE teslimEdildi=@teslim";
                cmd.Parameters.AddWithValue("@teslim", "0");
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DataRow row = table.NewRow();//Tablo için Satır.
                    row["Emanet ID"] = dr["emanetID"].ToString();
                    row["Üye TC"] = dr["uyeTC"].ToString();
                    row["Kitap ID"] = dr["kitapID"].ToString();
                    row["Veriliş Tarihi"] = dr["verilisTarihi"].ToString();
                    row["Geri Alınma Tarihi"] = dr["geriAlinmaTarihi"].ToString();
                    //row["Teslim Edildi Mi?"] = dr["teslimEdildi"].ToString();
                    String st = dr["teslimEdildi"].ToString();
                    bool bl = bool.Parse(st);
                    if (bl==false)
                    {
                        row["Teslim Edildi Mi?"] = "Hayır";
                    }
                    else
                    {
                        row["Teslim Edildi Mi?"] = "Evet";
                    }

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Teslim Edildi Olarak İşaretlemek İstiyor musunuz? " ,"Emin misiniz?", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                DataTable table = new DataTable();
                DataRow row = table.NewRow();
                string stt = dataGridView1.CurrentRow.Cells["Emanet ID"].FormattedValue.ToString();
                try
                {
                    cmd = new MySqlCommand();
                    cmd.Connection = mysqlbaglan;

                    cmd.CommandText = "UPDATE emanet SET teslimEdildi=@teslimEdildi WHERE emanetID='" + stt + "'";
                    cmd.Parameters.AddWithValue("@teslimEdildi", "1");
                    dr = cmd.ExecuteReader();
                    MessageBox.Show("Başarılı.");
                }
                catch (Exception err)
                {
                    MessageBox.Show("Hata! " + err.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dr.Close();
                mysqlbaglan.Close();
                emanetListele_Load(sender, e);
            }
        }
    }
}
