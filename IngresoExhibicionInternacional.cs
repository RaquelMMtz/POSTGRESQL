using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class IngresoExhibicionInternacional : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public IngresoExhibicionInternacional()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVIE.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM IngresoExhibicionInternacional ORDER BY idIngresoExhibicionInternacional");
        }
        private void IngresoExhibicionInternacional_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Ingreso = txtIDI.Text;
            string ExInt = txtIDEI.Text;
            string numInt = txtNumIn.Text;
            consulta = "INSERT INTO IngresoExhibicionInternacional (idIngreso,idExhibicionInternacional, numIntegrantes) values ('" + Ingreso + "','" + ExInt + "','" + numInt + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDI.Clear();
            txtIDEI.Clear();
            txtNumIn.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idIngresoExhibicionInternacional = (int)dGVIE.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE IngresoExhibicionInternacional SET ESTATUS = 0 WHERE idIngresoExhibicionInternacional =" + idIngresoExhibicionInternacional.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string Ingreso = txtIDI.Text;
            string ExInt = txtIDEI.Text;
            string numInt = txtNumIn.Text;
            int idIngresoExhibicionInternacional = (int)dGVIE.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE IngresoExhibicionInternacional SET idIngreso ='" + Ingreso + "',idExhibicionInternacional='" + ExInt + "',numIntegrantes='" + numInt + "'WHERE idAExhibicionInternacional = " + idIngresoExhibicionInternacional.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDI.Clear();
            txtIDEI.Clear();
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
