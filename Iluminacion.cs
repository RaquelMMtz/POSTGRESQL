using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class Iluminacion : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Iluminacion()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVIluminacion.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM Iluminacion ORDER BY idIluminacion");
        }
        private void Iluminacion_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;
            string descripcion = txtDesc.Text;
            string idTecnico = txtIDTecnico.Text;
            consulta = "INSERT INTO Iluminacion (fechaEntrega, descripcion, idTecnico) values ('" + fecha + "','" + descripcion + "','" + idTecnico + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtFecha.Clear();
            txtDesc.Clear();
            txtIDTecnico.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idIluminacion = (int)dGVIluminacion.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Iluminacion SET ESTATUS = 0 WHERE idIluminacion =" + idIluminacion.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;
            string descripcion = txtDesc.Text;
            string idTecnico = txtIDTecnico.Text;
            int idIluminacion = (int)dGVIluminacion.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE Iluminacion SET fechaEntrega ='" + fecha + "',descripcion='" + descripcion + "',idTecnico='" + idTecnico + "'WHERE idIluminacion = " + idIluminacion.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtFecha.Clear();
            txtDesc.Clear();
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
