using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class Cambio : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Cambio()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVCambio.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM Cambio ORDER BY idCambio");
        }
        private void Cambio_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;
            string cambio = txtCambio.Text;
            string descripcion = txtDescripcion.Text;
            consulta = "INSERT INTO Cambio (cambio, descripcion, fecha) values ('" + cambio + "','" + descripcion + "','" + fecha + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtFecha.Clear();
            txtCambio.Clear();
            txtDescripcion.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idCambio = (int)dGVCambio.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Cambio SET ESTATUS = 0 WHERE idCambio =" + idCambio.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;
            string cambio = txtCambio.Text;
            string descripcion = txtDescripcion.Text;
            int idCambio = (int)dGVCambio.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE Cambio SET cambio ='" + cambio + "',descripcion ='" + descripcion + "',fecha='" + fecha + "'WHERE idCambio = " + idCambio.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtCambio.Clear();
            txtFecha.Clear();
            txtDescripcion.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
