using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OtobüsOtomasyonu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("Data Source=DESKTOP-HN8AHBG\\SQLEXPRESS;Initial Catalog=otobusfirmasi2;Integrated Security=True;Encrypt=False");


            myConnection.Open();
            using (SqlCommand giris = myConnection.CreateCommand())
            {
                giris.Parameters.AddWithValue("@p1", textBoxId.Text);
                giris.CommandText = "DELETE from SEFERLER where SEFERID = @p1";
                giris.ExecuteNonQuery();
            }
            myConnection.Close();
            this.seferlerTableAdapter.Fill(this.otobusfirmasi2DataSet.Seferler);
        }

        private void dateTimePickerDepartureDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // 'otobusfirmasi2DataSet.Seferler' tablosuna veri yükler.
            this.seferlerTableAdapter.Fill(this.otobusfirmasi2DataSet.Seferler);

        }

      

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("Data Source=DESKTOP-HN8AHBG\\SQLEXPRESS;Initial Catalog=otobusfirmasi2;Integrated Security=True;Encrypt=False");
            myConnection.Open();
            using (SqlCommand giris = myConnection.CreateCommand())
            {
                giris.Parameters.AddWithValue("@p1", textBoxBusPlate.Text);
                giris.Parameters.AddWithValue("@p2", textBoxRoute.Text);
                giris.Parameters.AddWithValue("@p3", dateTimePickerDepartureDate.Text);
                giris.Parameters.AddWithValue("@p4", comboBoxBusType.Text);
                giris.Parameters.AddWithValue("@p5", comboBoxDepartureTime.Text);
                giris.CommandText = "INSERT INTO Seferler(OtobusPlakasi, SeferGuzergahi, SeferTarihi, OtobusTuru, SeferSaati) VALUES(@p1,@p2,@p3,@p4,@p5)";
                giris.ExecuteNonQuery();
            }
            myConnection.Close();
            this.seferlerTableAdapter.Fill(this.otobusfirmasi2DataSet.Seferler);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection myConnection = new SqlConnection("Data Source=DESKTOP-HN8AHBG\\SQLEXPRESS;Initial Catalog=otobusfirmasi2;Integrated Security=True;Encrypt=False");

            myConnection.Open();
            using (SqlCommand giris = myConnection.CreateCommand())
            {
                giris.Parameters.AddWithValue("@p1", textBoxId.Text);
                giris.Parameters.AddWithValue("@p2", textBoxBusPlate.Text);
                giris.Parameters.AddWithValue("@p3", textBoxRoute.Text);
                giris.Parameters.AddWithValue("@p4", dateTimePickerDepartureDate.Text);
                giris.Parameters.AddWithValue("@p5", comboBoxBusType.Text);
                giris.Parameters.AddWithValue("@p6", comboBoxDepartureTime.Text);
                giris.CommandText = "UPDATE SEFERLER SET OtobusPlakasi = @p2, SeferGuzergahi = @p3, SeferTarihi = @p4, OtobusTuru = @p5, SeferSaati = @p6 WHERE SeferID = @p1";
                giris.ExecuteNonQuery();
            }
            myConnection.Close();
            this.seferlerTableAdapter.Fill(this.otobusfirmasi2DataSet.Seferler);
        }
    }
}
