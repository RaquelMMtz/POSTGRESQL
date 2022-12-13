using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class Pelicula : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Pelicula()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVPeli.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM Pelicula ORDER BY idPelicula");
        }
        private void Pelicula_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string genero = txtGenero.Text;
            string clasificacion = txtClasificacion.Text;
            string duracion = txtDuracion.Text;
            string idJuntaDirectiva = txtIDJD.Text;
            string idDirector = txtIDD.Text;
            consulta = "INSERT INTO Pelicula (titulo,genero, clasificacion, duracion idJuntaDirectiva, idDirector) values ('" + titulo + "','" + genero + "','" + clasificacion + "','" + duracion + "','" + idJuntaDirectiva + "','" + idDirector + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtTitulo.Clear();
            txtIDJD.Clear();
            txtIDD.Clear();
            txtGenero.Clear();
            txtDuracion.Clear();
            txtClasificacion.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idPelicula = (int)dGVPeli.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Pelicula SET ESTATUS = 0 WHERE idPelicula =" + idPelicula.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string genero = txtGenero.Text;
            string clasificacion = txtClasificacion.Text;
            string duracion = txtDuracion.Text;
            string idJuntaDirectiva = txtIDJD.Text;
            string idDirector = txtIDD.Text;
            int idPelicula = (int)dGVPeli.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE Pelicula SET titulo ='" + titulo + "',genero='" + genero + "',clasificacion='" + clasificacion + "',duracion='" + duracion + "',idJuntaDirectiva='" + idJuntaDirectiva + "',idDirector='" + idDirector + "'WHERE idPelicula = " + idPelicula.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtTitulo.Clear();
            txtIDJD.Clear();
            txtIDD.Clear();
            txtGenero.Clear();
            txtDuracion.Clear();
            txtClasificacion.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
