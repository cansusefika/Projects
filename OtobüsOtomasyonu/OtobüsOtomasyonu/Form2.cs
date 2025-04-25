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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("Data Source=DESKTOP-HN8AHBG\\SQLEXPRESS;Initial Catalog=otobusfirmasi2;Integrated Security=True;Encrypt=False");
            myConnection.Open();
            using (SqlCommand kayit = myConnection.CreateCommand())
            {
                kayit.Parameters.AddWithValue("@p1", textBoxFirstName.Text);
                kayit.Parameters.AddWithValue("@p2", textBoxLastName.Text);
                kayit.Parameters.AddWithValue("@p3", textBoxUsername.Text);
                kayit.Parameters.AddWithValue("@p4", textBoxPassword.Text);
                kayit.Parameters.AddWithValue("@p5", textBoxEmail.Text);
                kayit.Parameters.AddWithValue("@p6", maskedTextBoxPhone.Text);

                kayit.CommandText = "INSERT INTO Users(FirstName,LastName,UserName,Password,Email,Phone) Values(@p1, @p2, @p3,@p4,@p5,@p6)";
                kayit.ExecuteNonQuery();
            }
            myConnection.Close();
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
