using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace Kütüphane_Otomasyonu
{
    public partial class bookadd : Form
    {
        public bookadd()
        {
            InitializeComponent();
        }

        private void bookadd_Load(object sender, EventArgs e)
        {
            date.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VBGHLP2\\SQLEXPRESS;Initial Catalog=otomasyon;Integrated Security=True");



            if (kitapseri.Text != "")
            {


                baglanti.Open();

                string ekleme = "insert into kitaplar (kitap_serino,kitap_adi,kitap_giristarihi,kategori) values (@serisql , @adisql , @datesql , @kategorisql)";

                SqlCommand cmd = new SqlCommand(ekleme, baglanti);



                cmd.Parameters.AddWithValue("@serisql", kitapseri.Text);
                cmd.Parameters.AddWithValue("@adisql", kitapadi.Text);
                cmd.Parameters.AddWithValue("@kategorisql", kategori.Text);
                cmd.Parameters.AddWithValue("@datesql", Convert.ToDateTime(date.Text));

                cmd.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Kitap Başarıyla Eklendi");
            }

            else
            {
                MessageBox.Show("Lütfen Seri No Giriniz !");
            }
        }
    }
}
