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
    public partial class passupdate : Form
    {
        public passupdate()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlCommand cmd;
        SqlDataReader dr;
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-VBGHLP2\\SQLEXPRESS;Initial Catalog=otomasyon;Integrated Security=True");
            string sifresorgu = "SELECT * FROM yonetici where kullanici_sifre=@pass";
            cmd = new SqlCommand(sifresorgu, baglanti);
            cmd.Parameters.AddWithValue("@pass", eskisifre.Text);
            baglanti.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                baglanti = new SqlConnection("Data Source=DESKTOP-VBGHLP2\\SQLEXPRESS;Initial Catalog=otomasyon;Integrated Security=True");
                baglanti.Open();
                string guncelle = "Update yonetici Set kullanici_sifre=@sifre Where kullanici_mail=@mailsql AND kullanici_sifre=@eskisifresql";
                cmd = new SqlCommand(guncelle, baglanti);
                cmd.Parameters.AddWithValue("@mailsql", mail.Text);
                cmd.Parameters.AddWithValue("@sifre", yenisifre.Text);
                cmd.Parameters.AddWithValue("@eskisifresql", eskisifre.Text);

                cmd.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Şifreniz Başarıyla Değiştirildi");
            }

            else
            {
                MessageBox.Show("Eski Şifrenizi Yanlış Girdiniz !");
            }
        }
    }
}
