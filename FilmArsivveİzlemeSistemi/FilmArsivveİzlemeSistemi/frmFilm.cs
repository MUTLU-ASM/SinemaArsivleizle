using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FilmArsivveİzlemeSistemi
{
    public partial class frmFilm : Form
    {
        public frmFilm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-SBTQ48V\\SQLEXPRESS;Initial Catalog=FilmArsivi;Integrated Security=True");

        void filmler()
        {
            SqlDataAdapter da = new SqlDataAdapter("Select * from filmler", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gridFilmListesi.DataSource = dt;
        }
        private void frmFilm_Load(object sender, EventArgs e)
        {
            filmler();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into filmler (ad,kategori,link) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtFilmAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtKategori.Text);
            komut.Parameters.AddWithValue("@p3", txtLink.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Film Listenize eklendi", "Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            filmler();

        }

        private void gridFilmListesi_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = gridFilmListesi.SelectedCells[0].RowIndex;
            string link = gridFilmListesi.Rows[secilen].Cells[3].Value.ToString();

            webFilmEkrani.Navigate(link);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRenkDegistir_Click(object sender, EventArgs e)
        {
            Color[] renkler = { Color.Black,Color.Blue,Color.White,Color.Maroon,Color.Green };
            Random rnd = new Random();
            int i = rnd.Next(0,renkler.Length);
            
            if (renkler[i]==Color.White)
            {
                panel1.ForeColor = Color.Black;
                grpEkran.ForeColor = Color.Black;
                grpYeniFilm.ForeColor = Color.Black;
                grpİslemler.ForeColor = Color.Black;
            }
            else if (renkler[i] == Color.Black)
            {
                panel1.ForeColor = Color.White;
                grpEkran.ForeColor = Color.White;
                grpYeniFilm.ForeColor = Color.White;
                grpİslemler.ForeColor = Color.White;
            }
            this.BackColor=renkler[i];
        }

        private void btnTamEkran_Click(object sender, EventArgs e)
        {
            frmTamEkran frm = new frmTamEkran();
            frm.Show();
            string link=gridFilmListesi.CurrentRow.Cells[3].Value.ToString();
            frm.webBrowser1.Navigate(link);
        }
    }
}
