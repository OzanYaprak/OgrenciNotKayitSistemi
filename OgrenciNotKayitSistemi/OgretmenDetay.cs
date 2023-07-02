using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OgrenciNotKayitSistemi
{
    public partial class OgretmenDetay : Form
    {
        public OgretmenDetay()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source = (localdb)\mssqllocaldb; Initial Catalog = NotKayitDB; Integrated Security = True");

        private void OgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'notKayitDBDataSet.Ders' table. You can move, or remove it, as needed.
            this.dersTableAdapter.Fill(this.notKayitDBDataSet.Ders);

        }


        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("insert into Ders (OgrenciNumber,OgrenciName,OgrenciSurname) values (@P1,@P2,@P3)", conn);

            cmd.Parameters.AddWithValue("@P1", MaskedTBNumara.Text);
            cmd.Parameters.AddWithValue("@P2", TBAd.Text);
            cmd.Parameters.AddWithValue("@P3", TBSoyad.Text);
            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Öğrenci Sisteme Eklendi");

            this.dersTableAdapter.Fill(this.notKayitDBDataSet.Ders);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            MaskedTBNumara.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TBAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TBSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            TBVize.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TBFinal.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TBBütünleme.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ortalama, vize, final, bütünleme;

            string durum;

            vize = Convert.ToDouble(TBVize.Text);
            final = Convert.ToDouble(TBFinal.Text);
            bütünleme = Convert.ToDouble(TBBütünleme.Text);

            ortalama = (vize + final + bütünleme) / 3;

            LBLOgrenciOrtalama.Text = ortalama.ToString();

            if (ortalama >= 50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }

            conn.Open();

            SqlCommand cmd = new SqlCommand("update Ders set OgrenciVize=@P1,OgrenciFinal=@P2,OgrenciButunleme=@P3,NotOrtalama=@P4,Durum=@P5 Where OgrenciNumber=@P6", conn);

            cmd.Parameters.AddWithValue("@P1", TBVize.Text);
            cmd.Parameters.AddWithValue("@P2", TBFinal.Text);
            cmd.Parameters.AddWithValue("@P3", TBBütünleme.Text);
            cmd.Parameters.AddWithValue("@P4", decimal.Parse(LBLOgrenciOrtalama.Text));
            cmd.Parameters.AddWithValue("@P5", durum);
            cmd.Parameters.AddWithValue("@P6", MaskedTBNumara.Text);

            cmd.ExecuteNonQuery();

            conn.Close();

            MessageBox.Show("Öğrenci Notları Güncellendi");

            this.dersTableAdapter.Fill(this.notKayitDBDataSet.Ders);
        }
    }
}
