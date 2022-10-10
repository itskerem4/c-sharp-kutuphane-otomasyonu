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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void button1_Click (object sender, EventArgs e)
        {
           
            string sorgu = "SELECT * FROM yonetici where kullanici_mail=@user AND kullanici_sifre=@pass";
            con = new SqlConnection("Data Source=DESKTOP-VBGHLP2\\SQLEXPRESS;Initial Catalog=otomasyon;Integrated Security=True");
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", user.Text);
            cmd.Parameters.AddWithValue("@pass", pass.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            
                if (dr.Read())
                {
            

                Menu panel = new Menu();

                panel.Show();

                this.Hide();

                

                }
               
            
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");

               

               
            }
            con.Close();



        }
       
       

    }
}
