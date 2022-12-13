using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class FxPersonaje : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public FxPersonaje()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVFx.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM FxPersonaje ORDER BY idFxPersonaje");
        }
        private void FxPersonaje_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;
            string idTecnico = txtIDTecnico.Text;
            consulta = "INSERT INTO FxPersonaje (fechaEntrega, idTecnico) values ('" + fecha + "','" + idTecnico + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtFecha.Clear();
            txtIDTecnico.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idFxPersonaje = (int)dGVFx.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE FxPersonaje SET ESTATUS = 0 WHERE idFxPersonaje =" + idFxPersonaje.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;
            string idTecnico = txtIDTecnico.Text;
            int idFxPersonaje = (int)dGVFx.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE FxPersonaje SET fechaEntrega ='" + fecha + "',idTecnico='" + idTecnico + "'WHERE idFxPersonaje = " + idFxPersonaje.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtFecha.Clear();
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
