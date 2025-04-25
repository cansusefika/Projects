using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OtobüsOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("Data Source=DESKTOP-HN8AHBG\\SQLEXPRESS;Initial Catalog=otobusfirmasi2;Integrated Security=True;Encrypt=False");
            myConnection.Open();
            using (SqlCommand giris = myConnection.CreateCommand())
            {
                giris.Parameters.AddWithValue("@p1", textBoxUsername.Text);
                giris.Parameters.AddWithValue("@p2", textBoxPassword.Text);
                giris.CommandText = "Select * from Users WHERE UserName = @p1 AND Password = @p2";
                SqlDataReader kontrol = giris.ExecuteReader();
                if (kontrol.Read())
                {
                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Hide();
                }
            }
            myConnection.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 form2 = new Form2();  
            form2.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}