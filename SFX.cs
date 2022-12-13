using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class SFX : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public SFX()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
           dGVSFX.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM SFX ORDER BY idSFX");
        }
        private void SFX_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;
            string Tipo = txtTipo.Text;
            string idTecnico = txtIDTecnico.Text;
            consulta = "INSERT INTO SFX (tipo, fechaEntrega, idTecnico) values ('" + Tipo + "','" + fecha + "','" + idTecnico + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtFecha.Clear();
            txtTipo.Clear();
            txtIDTecnico.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idSFX = (int)dGVSFX.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE SFX SET ESTATUS = 0 WHERE idSFX =" + idSFX.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;
            string Tipo = txtTipo.Text;
            string idTecnico = txtIDTecnico.Text;
            int idSFX = (int)dGVSFX.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE SFX SET tipo ='" + Tipo + "',fechaEntrega'" + fecha + "',idTecnico='" + idTecnico + "'WHERE idSFX = " + idSFX.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtFecha.Clear();
            txtTipo.Clear();
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
