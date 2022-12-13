using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class DiaPresentacion : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public DiaPresentacion()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVDP.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM DiaPresentacion ORDER BY idDiaPresentacion");
        }
        private void DiaPresentacion_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Text;
            string fecha = txtFecha.Text;
            string idJuntaDirectiva = txtIDJD.Text;
            consulta = "INSERT INTO DiaPresentacion (descripcion, fecha, id) values ('" + descripcion + "','" + fecha + "','" + idJuntaDirectiva + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtDescripcion.Clear();
            txtFecha.Clear();
            txtIDJD.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idDiaPresentacion = (int)dGVDP.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE DiaPresentacion SET ESTATUS = 0 WHERE idDiaPresentacion =" + idDiaPresentacion.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string descripcion = txtDescripcion.Text;
            string fecha = txtFecha.Text;
            string idJuntaDirectiva = txtIDJD.Text;
            int idDiaPresentacion = (int)dGVDP.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE DiaPresentacion SET descripcion ='" + descripcion + "',fecha='" + fecha + "',idJuntaDirectiva='" + idJuntaDirectiva + "'WHERE idDiaPresentacion = " + idDiaPresentacion.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtDescripcion.Clear();
            txtFecha.Clear();
            txtIDJD.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
