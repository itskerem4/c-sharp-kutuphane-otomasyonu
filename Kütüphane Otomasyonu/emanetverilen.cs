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
    public partial class emanetverilen : Form
    {
        public emanetverilen()
        {
            InitializeComponent();
        }

        private void emanetverilen_Load(object sender, EventArgs e)
        {
            SqlDataReader oku;
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-VBGHLP2\\SQLEXPRESS;Initial Catalog=otomasyon;Integrated Security=True");

          
                baglanti.Open();

                SqlCommand cmd = new SqlCommand("SELECT * FROM oduncislemi", baglanti);

                oku = cmd.ExecuteReader();

                while (oku.Read())
                {
                    ListViewItem listele = new ListViewItem();
                    listele.Text = (oku["odunc_durumu"].ToString());
                    listele.SubItems.Add(oku["odunc_tarihi"].ToString());
                    listele.SubItems.Add(oku["odunc_alan"].ToString());
                    listele.SubItems.Add(oku["odunc_verilen"].ToString());


                    listView1.Items.Add(listele);
                }
                baglanti.Close();
            
        }
    }
    }
