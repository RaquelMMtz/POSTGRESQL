using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class Guion : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Guion()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVG.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM Guion ORDER BY idGuion");
        }
        private void Guion_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string fecha = txtFecha.Text;
            string idGuionista = txtidGui.Text;
            consulta = "INSERT INTO Guion (titulo, fechaEntrega, idGuionista) values ('" + titulo + "','" + fecha + "','" + idGuionista + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtTitulo.Clear();
            txtFecha.Clear();
            txtidGui.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idGuion = (int)dGVG.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Guion SET ESTATUS = 0 WHERE idGuion =" + idGuion.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string fecha = txtFecha.Text;
            string idGuionista = txtidGui.Text;
            int idGuion = (int)dGVG.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE Guion SET titulo ='" + titulo + "',fechaEntrega ='" + fecha + "',idGuionista='" + idGuionista + "'WHERE idGuion = " + idGuion.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtTitulo.Clear();
            txtFecha.Clear();
            txtidGui.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
