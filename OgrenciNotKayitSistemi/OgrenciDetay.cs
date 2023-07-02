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
        }
    }
}