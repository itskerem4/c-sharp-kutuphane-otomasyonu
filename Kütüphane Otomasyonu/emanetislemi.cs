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
    public partial class emanetislemi : Form
    {
        public emanetislemi()
        {
            InitializeComponent();
        }

        private void emanetislemi_Load(object sender, EventArgs e)
        {
            date1.Enabled = false;
            oduncislemi.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VBGHLP2\\SQLEXPRESS;Initial Catalog=otomasyon;Integrated Security=True");



            if (date2.Text != "")
            {


                baglanti.Open();

                string ekleme = "insert into oduncislemi (odunc_durumu,odunc_tarihi,geri_alma,odunc_alan,odunc_verilen) values (@oduncislemisql , @firstdatesql , @twodatesql , @alansql , @verilensql)";

                SqlCommand cmd = new SqlCommand(ekleme, baglanti);



                cmd.Parameters.AddWithValue("@oduncislemisql", oduncislemi.Text);
                cmd.Parameters.AddWithValue("@firstdatesql", Convert.ToDateTime(date1.Text));
                cmd.Parameters.AddWithValue("@twodatesql", Convert.ToDateTime(date2.Text));
                cmd.Parameters.AddWithValue("@alansql", alankisi.Text);
                cmd.Parameters.AddWithValue("@verilensql", verilentxt.Text);

                cmd.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Ödünç İşlemi Başarılı");
            }

            else
            {
                MessageBox.Show("Lütfen Geri Verilecek Tarihi Giriniz!");
            }
        }
    }
    }

