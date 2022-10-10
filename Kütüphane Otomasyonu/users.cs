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
    public partial class users : Form
    {
        public users()
        {
            InitializeComponent();
        }
        SqlDataReader oku;

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VBGHLP2\\SQLEXPRESS;Initial Catalog=otomasyon;Integrated Security=True");
        private void users_Load(object sender, EventArgs e)
        {
            


            baglanti.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM uyeler", baglanti);

            oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem listele = new ListViewItem();
                listele.Text = (oku["uye_tc"].ToString());
                listele.SubItems.Add(oku["uye_adi"].ToString());
                listele.SubItems.Add(oku["uye_soyadi"].ToString());
                listele.SubItems.Add(oku["uye_dt"].ToString());
                listele.SubItems.Add(oku["uye_adres"].ToString());
                listele.SubItems.Add(oku["uye_cinsiyet"].ToString());
                listView1.Items.Add(listele);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listView1.Items.Clear();

            baglanti.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM uyeler where uye_adi=@searchname and uye_soyadi=@searchsurname", baglanti);

            cmd.Parameters.AddWithValue("@searchname", searchnametxt.Text);
            cmd.Parameters.AddWithValue("@searchsurname", searchsurnametxt.Text);
            oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem listele = new ListViewItem();
                listele.Text = (oku["uye_tc"].ToString());
                listele.SubItems.Add(oku["uye_adi"].ToString());
                listele.SubItems.Add(oku["uye_soyadi"].ToString());
                listele.SubItems.Add(oku["uye_dt"].ToString());
                listele.SubItems.Add(oku["uye_adres"].ToString());
                listele.SubItems.Add(oku["uye_cinsiyet"].ToString());
                listView1.Items.Add(listele);
            }
            baglanti.Close();


           
        }

        
    }
}

