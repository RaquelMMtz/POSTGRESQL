using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class Junta_Directiva : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Junta_Directiva()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVJD.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM JuntaDirectiva ORDER BY idJuntaDirectiva");
        }
        private void Junta_Directiva_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string motivo = txtMotivo.Text;
            string numIn = txtNumIn.Text;
            consulta = "INSERT INTO JuntaDirectiva (motivo, numIntegrantes) values ('" + motivo + "','" + numIn + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtMotivo.Clear();
            txtNumIn.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idJuntaDirectiva = (int)dGVJD.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE JuntaDirectiva SET ESTATUS = 0 WHERE idJuntaDirectiva =" + idJuntaDirectiva.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string motivo = txtMotivo.Text;
            string numIn = txtNumIn.Text;
            int idJuntaDirectiva = (int)dGVJD.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE JuntaDirectiva SET motivo ='" + motivo + "',numIntegrantes='" + numIn + "'WHERE idJuntaDirectiva = " + idJuntaDirectiva.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtMotivo.Clear();
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
