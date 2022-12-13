using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class PostProduccion : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public PostProduccion()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVPostP.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM PostProduccion ORDER BY idPostProduccion");
        }
        private void PostProduccion_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string fechaEntrega = txtFecha.Text;
            string CorreccionF = txtCF.Text;
            consulta = "INSERT INTO PostProduccion (fecha,CorreccionFinal) values ('" + fechaEntrega + "','" + CorreccionF + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtFecha.Clear();
            txtFecha.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idPostProduccion = (int)dGVPostP.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE PostProduccion SET ESTATUS = 0 WHERE idPostProduccion =" + idPostProduccion.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string fechaEntrega = txtFecha.Text;
            string CorreccionF = txtCF.Text;
            int idPostProduccion = (int)dGVPostP.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE PostProduccion SET fechaEntrega ='" + fechaEntrega + "',correccionFinal='" + CorreccionF + "'WHERE idPostProduccion = " + idPostProduccion.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtFecha.Clear();
            txtFecha.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
