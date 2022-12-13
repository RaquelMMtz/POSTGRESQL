using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class Director : Form
    {

        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Director()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVDirector.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM Director ORDER BY idDirector");
        }
        private void Director_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string ap = txtAP.Text;
            string am = txtAM.Text;
            consulta = "INSERT INTO Director (nombre, apellidoPaterno, apellidoMaterno) values ('" + nombre + "','" + ap + "','" + am + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtAP.Clear();
            txtAM.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idDirector = (int)dGVDirector.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Director SET ESTATUS = 0 WHERE idDirector =" + idDirector.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string ap = txtAP.Text;
            string am = txtAM.Text;
            int idDirector = (int)dGVDirector.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE Director SET nombre ='" + nombre + "',apellidoPaterno='" + ap + "',apellidoMaterno='" + am + "'WHERE idDirector = " + idDirector.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtAP.Clear();
            txtAM.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
