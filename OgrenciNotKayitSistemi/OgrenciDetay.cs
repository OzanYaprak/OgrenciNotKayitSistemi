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

namespace OgrenciNotKayitSistemi
{
    public partial class OgrenciDetay : Form
    {
        public OgrenciDetay()
        {
            InitializeComponent();
        }

        public string numara;

        SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\mssqllocaldb; Initial Catalog = NotKayitDB; Integrated Security = True");

        private void OgrenciDetay_Load(object sender, EventArgs e)
        {
            LBLNumara.Text = numara;

            conn.Open();

            SqlCommand cmd = new SqlCommand("Select * From Ders Where OgrenciNumber=@p1", conn);
            cmd.Parameters.AddWithValue("@p1", numara);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                LBLAdSoyad.Text = reader[2].ToString()+" "+reader[3].ToString();
                LBLVize.Text = reader[4].ToString();
                LBLFinal.Text = reader[5].ToString();
                LBLBütünleme.Text = reader[6].ToString();
                LBLOrtalama.Text = reader[7].ToString();
                LBLDurum.Text = reader[8].ToString();
            }

            conn.Close();
        }
    }
}