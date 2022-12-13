using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class ArtistaStoryBoard : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public ArtistaStoryBoard()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVAS.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM ArtistaStoryBoard ORDER BY idArtistaStoryBoard");
        }
        private void ArtistaStoryBoard_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Artista = txtIDA.Text;
            string StoryBoard = txtIDS.Text;
            string numInt = txtNumIn.Text;
            consulta = "INSERT INTO AnimacionAnimador (idAnimacion, idAnimador, numIntegrantes) values ('" + Artista + "','" + StoryBoard + "','" + numInt + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDA.Clear();
            txtIDS.Clear();
            txtNumIn.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idArtistaStoryBoard = (int)dGVAS.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE ArtistaStoryBoard SET ESTATUS = 0 WHERE idArtistaStoryBoard =" + idArtistaStoryBoard.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string Artista = txtIDA.Text;
            string StoryBoard = txtIDS.Text;
            string numInt = txtNumIn.Text;
            int idArtistaStoryBoard = (int)dGVAS.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE ArtistaStoryBoard SET idArtista ='" + Artista + "',idStoryBoard='" + StoryBoard + "',numIntegrantes='" + numInt + "'WHERE idArtistaStoryBoard = " + idArtistaStoryBoard.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDA.Clear();
            txtIDS.Clear();
            txtNumIn.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
