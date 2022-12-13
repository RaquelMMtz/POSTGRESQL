using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class Layout : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Layout()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVLayout.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM Layout ORDER BY idLayout");
        }
        private void Layout_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string fechaEntrega = txtFechaEntrega.Text;
            string CD = txtCD.Text;
            string tipo = txtTipo.Text;
            consulta = "INSERT INTO Layout (fechaEntrega, correccionDibujo, tipo) values ('" + fechaEntrega + "','" + CD + "','" + tipo + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtFechaEntrega.Clear();
            txtCD.Clear();
            txtTipo.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idLayout = (int)dGVLayout.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Layout SET ESTATUS = 0 WHERE idLayout =" + idLayout.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string fechaEntrega = txtFechaEntrega.Text;
            string CD = txtCD.Text;
            string tipo = txtTipo.Text;
            int idLayout = (int)dGVLayout.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE Layout SET fechaEntrega ='" + fechaEntrega + "',correccionDibujo='" + CD + "',tipo='" + tipo + "'WHERE idLayout = " + idLayout.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtFechaEntrega.Clear();
            txtCD.Clear();
            txtTipo.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
