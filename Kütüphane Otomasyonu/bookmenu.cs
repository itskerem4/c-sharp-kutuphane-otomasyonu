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
    public partial class bookmenu : Form
    {
        public bookmenu()
        {
            InitializeComponent();
        }
        SqlDataReader oku;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VBGHLP2\\SQLEXPRESS;Initial Catalog=otomasyon;Integrated Security=True");

        private void bookmenu_Load(object sender, EventArgs e)
        {
        
            }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
           
                baglanti.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM kitaplar", baglanti);

                oku = cmd.ExecuteReader();

                while (oku.Read())
                {
                    ListViewItem listele = new ListViewItem();
                    listele.Text = (oku["kitap_serino"].ToString());
                    listele.SubItems.Add(oku["kitap_adi"].ToString());
                    listele.SubItems.Add(oku["kitap_giristarihi"].ToString());
                    listele.SubItems.Add(oku["kategori"].ToString());

                    listView1.Items.Add(listele);

                }
                baglanti.Close();
            }
       
        

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM kitaplar where kategori = 'Roman'", baglanti);

            oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem listele = new ListViewItem();
                listele.Text = (oku["kitap_serino"].ToString());
                listele.SubItems.Add(oku["kitap_adi"].ToString());
                listele.SubItems.Add(oku["kitap_giristarihi"].ToString());
                listele.SubItems.Add(oku["kategori"].ToString());

                listView1.Items.Add(listele);
            }
            baglanti.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM kitaplar where kategori = 'Şiir'", baglanti);

            oku = cmd.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem listele = new ListViewItem();
                listele.Text = (oku["kitap_serino"].ToString());
                listele.SubItems.Add(oku["kitap_adi"].ToString());
                listele.SubItems.Add(oku["kitap_giristarihi"].ToString());
                listele.SubItems.Add(oku["kategori"].ToString());

                listView1.Items.Add(listele);
            }
            baglanti.Close();
        }
        
    }
    }
    


