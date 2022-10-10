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
    public partial class useredit : Form
    {
        public useredit()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VBGHLP2\\SQLEXPRESS;Initial Catalog=otomasyon;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {

            if (tc.Text != "")
            {


                baglanti.Open();

                string ekleme = "insert into uyeler (uye_tc,uye_adi,uye_soyadi,uye_dt,uye_adres,uye_cinsiyet) values (@tcsql , @adisql , @soyadisql , @dtsql , @adressql , @cinsiyetsql)";

                SqlCommand cmd = new SqlCommand(ekleme, baglanti);



                cmd.Parameters.AddWithValue("@tcsql", tc.Text);
                cmd.Parameters.AddWithValue("@adisql", adi.Text);
                cmd.Parameters.AddWithValue("@soyadisql", soyadi.Text);
                cmd.Parameters.AddWithValue("@dtsql", Convert.ToDateTime(dt.Text));
                cmd.Parameters.AddWithValue("@adressql", adres.Text);
                cmd.Parameters.AddWithValue("@cinsiyetsql", cinsiyet.Text);
                cmd.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Üye Başarıyla Eklendi");
            }

            else
            {
                MessageBox.Show("Lütfen Tc Kimlik No Giriniz !");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
           


            if (siltxt.Text != "")
            {
               

                baglanti.Open();

                string silme = "delete from uyeler where uye_tc=@tcsql";

                SqlCommand cmd = new SqlCommand(silme, baglanti);



                cmd.Parameters.AddWithValue("@tcsql", siltxt.Text);

                cmd.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Üye Başarıyla Silindi");
            }

            else
            {
                MessageBox.Show("Lütfen Tc Kimlik No Giriniz !");
            }
        }
    }
}
