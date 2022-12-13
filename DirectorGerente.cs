using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class DirectorGerente : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public DirectorGerente()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVDG.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM DirectorGerente ORDER BY idDirectorGerente");
        }
        private void DirectorGerente_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Director = txtIDD.Text;
            string Gerente = txtIDG.Text;
            string numInt = txtNumIn.Text;
            consulta = "INSERT INTO AnimacionAnimador (idAnimacion, idAnimador, numIntegrantes) values ('" + Director + "','" + Gerente + "','" + numInt + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDD.Clear();
            txtIDG.Clear();
            txtNumIn.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idDirectorGerente = (int)dGVDG.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE DirectorGerenre SET ESTATUS = 0 WHERE idDirectorGerente =" + idDirectorGerente.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string Director = txtIDD.Text;
            string Gerente = txtIDG.Text;
            string numInt = txtNumIn.Text;
            int idDirectorGerente = (int)dGVDG.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE DirectorGerente SET idDirector ='" + Director + "',idGerente='" + Gerente + "',numIntegrantes='" + numInt + "'WHERE idDirectorGerente = " + idDirectorGerente.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDD.Clear();
            txtIDG.Clear();
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
