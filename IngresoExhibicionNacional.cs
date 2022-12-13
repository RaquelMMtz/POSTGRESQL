using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class IngresoExhibicionNacional : Form
    {

        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public IngresoExhibicionNacional()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVIE.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM IngresoExhibicionNacional ORDER BY idIngresoExhibicionNacional");
        }
        private void IngresoExhibicionNacional_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Ingreso = txtIDI.Text;
            string ExNa = txtIDEN.Text;
            string numInt = txtNumIn.Text;
            consulta = "INSERT INTO IngresoExhibicionNacional (idIngreso,idExhibicionNacional, numIntegrantes) values ('" + Ingreso + "','" + ExNa + "','" + numInt + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDI.Clear();
            txtIDEN.Clear();
            txtNumIn.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idIngresoExhibicionNacional = (int)dGVIE.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE IngresoExhibicionInternacional SET ESTATUS = 0 WHERE idIngresoExhibicionNacional =" + idIngresoExhibicionNacional.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string Ingreso = txtIDI.Text;
            string ExNa = txtIDEN.Text;
            string numInt = txtNumIn.Text;
            int idIngresoExhibicionNacional = (int)dGVIE.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE IngresoExhibicionNacional SET idIngreso ='" + Ingreso + "',idExhibicionNacional='" + ExNa + "',numIntegrantes='" + numInt + "'WHERE idAExhibicionNacional = " + idIngresoExhibicionNacional.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDI.Clear();
            txtIDEN.Clear();
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
