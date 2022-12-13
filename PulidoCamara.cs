using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class PulidoCamara : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public PulidoCamara()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVPC.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM PulidoCamara ORDER BY idPulidoCamara");
        }
        private void PulidoCamara_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;
            string detalles = txtDet.Text;
            string idTecnico = txtIDTecnico.Text;
            consulta = "INSERT INTO PulidoCamara (fechaEntrega, detalles, idTecnico) values ('" + fecha + "','" + detalles + "','" + idTecnico + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtFecha.Clear();
            txtDet.Clear();
            txtIDTecnico.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idPulidoCamara = (int)dGVPC.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE PulidoCamara SET ESTATUS = 0 WHERE idPulidoCamara =" + idPulidoCamara.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;
            string detalles = txtDet.Text;
            string idTecnico = txtIDTecnico.Text;
            int idPulidoCamara = (int)dGVPC.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE PulidoCamara SET fechaEntrega ='" + fecha + "',detalles='" + detalles + "',idTecnico='" + idTecnico + "'WHERE idPulidoCamara = " + idPulidoCamara.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtFecha.Clear();
            txtDet.Clear();
            txtIDTecnico.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
