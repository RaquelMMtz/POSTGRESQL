using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class AsistenteAnimacion : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public AsistenteAnimacion()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVASA.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM AsistenteAnimacion ORDER BY idAsistenteAnimacion");
        }
        private void AsistenteAnimacion_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string ap = txtAP.Text;
            string am = txtAM.Text;
            string idDirectorr = txtidD.Text;
            consulta = "INSERT INTO AsistenteAnimacion (nombre, apellidoPaterno, apellidoMaterno, personaje, idDirector) values ('" + nombre + "','" + ap + "','" + am + "','" + idDirectorr + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtAP.Clear();
            txtAM.Clear();
            txtidD.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idAsistenteAnimacion = (int)dGVASA.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE AsistenteAnimacion SET ESTATUS = 0 WHERE idAsistenteAnimacion =" + idAsistenteAnimacion.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string ap = txtAP.Text;
            string am = txtAM.Text;
            string idDirector = txtidD.Text;
            int idAsistenteAnimacion = (int)dGVASA.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE AsistenteAnimacion SET nombre ='" + nombre + "',apellidoPaterno='" + ap + "',apellidoMaterno='" + am + "',idDirector'" + idDirector + "'WHERE idAsistenteAnimacion = " + idAsistenteAnimacion.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtAP.Clear();
            txtAM.Clear();
            txtidD.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
