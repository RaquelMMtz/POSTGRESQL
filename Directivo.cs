using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class Directivo : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Directivo()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVDirectivo.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM Directivo ORDER BY idDirectivo");
        }
        private void Directivo_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string ap = txtAP.Text;
            string am = txtAM.Text;
            string departamento = txtDep.Text;
            string idJuntaDirectiva = txtidJD.Text;
            consulta = "INSERT INTO Directivo (nombre, apellidoPaterno, apellidoMaterno, departamento, idJuntaDirectiva) values ('" + nombre + "','" + ap + "','" + am + "','" + departamento + "','" + idJuntaDirectiva + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtAP.Clear();
            txtAM.Clear();
            txtidJD.Clear();
            txtDep.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idDirectivo = (int)dGVDirectivo.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Directivo SET ESTATUS = 0 WHERE idDirectivo =" + idDirectivo.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string ap = txtAP.Text;
            string am = txtAM.Text;
            string departamento = txtDep.Text;
            string idJuntaDirectiva = txtidJD.Text;
            int idDirectivo = (int)dGVDirectivo.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE Directivo SET nombre ='" + nombre + "',apellidoPaterno='" + ap + "',apellidoMaterno='" + am + "',departamento='" + departamento + "',idJuntaDirectiva='" + idJuntaDirectiva + "'WHERE idDirectivo = " + idDirectivo.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtAP.Clear();
            txtAM.Clear();
            txtidJD.Clear();
            txtDep.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
