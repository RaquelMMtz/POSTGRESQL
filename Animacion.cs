using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class Animacion : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Animacion()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVAnimacion.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM Animacion ORDER BY idAnimacion");
        }
        private void Animacion_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string fechaEntrega = txtFechaEntrega.Text;
            string idAsistenteAnimacion = txtidASA.Text;
            consulta = "INSERT INTO Animacion (nombre, fechaEntrega, idAsistenteAnimacion) values ('" + nombre + "','" + fechaEntrega + "','" + idAsistenteAnimacion + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtFechaEntrega.Clear();
            txtidASA.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idAnimacion = (int)dGVAnimacion.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Animacion SET ESTATUS = 0 WHERE idAnimacion =" + idAnimacion.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string fechaEntrega = txtFechaEntrega.Text;
            string idAsistenteAnimacion = txtidASA.Text;
            int idAnimacion = (int)dGVAnimacion.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE Animacion SET nombre ='" + nombre + "',fechaEntrega='" + fechaEntrega + "',idAsistenteAnimacion'" + idAsistenteAnimacion + "'WHERE idAnimacion = " + idAnimacion.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtFechaEntrega.Clear();
            txtidASA.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
