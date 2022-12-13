using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class Artista : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Artista()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVArtista.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM Artista ORDER BY idArtista");
        }
        private void Artista_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string ap = txtAP.Text;
            string am = txtAM.Text;
            string especializacion = txtEspe.Text;
            string idDirectorr = txtidD.Text;
            consulta = "INSERT INTO Artista (nombre, apellidoPaterno, apellidoMaterno, especializacion, idDirector) values ('" + nombre + "','" + ap + "','" + am + "','" + especializacion + "','" + idDirectorr + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtAP.Clear();
            txtAM.Clear();
            txtidD.Clear();
            txtEspe.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idArtista = (int)dGVArtista.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Artista SET ESTATUS = 0 WHERE idArtista =" + idArtista.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string ap = txtAP.Text;
            string am = txtAM.Text;
            string especializacion = txtEspe.Text;
            string idDirector = txtidD.Text;
            int idArtista = (int)dGVArtista.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE Artista SET nombre ='" + nombre + "',apellidoPaterno='" + ap + "','apellidoMaterno=" + am + "',especializacion='" + especializacion + "',idDirector='" + idDirector + "'WHERE idArtista = " + idArtista.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtAP.Clear();
            txtAM.Clear();
            txtidD.Clear();
            txtEspe.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
