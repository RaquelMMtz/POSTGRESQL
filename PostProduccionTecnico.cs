using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class PostProduccionTecnico : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public PostProduccionTecnico()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVPPT.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM PostProduccionTecnico ORDER BY idPostProduccionTecnico");
        }
        private void PostProduccionTecnico_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string PostProduccion = txtIDPP.Text;
            string Tecnico = txtIDT.Text;
            string numInt = txtNumIn.Text;
            consulta = "INSERT INTO PostProduccionTecnico (idPostProduccion, idTecnico, numIntegrantes) values ('" + PostProduccion + "','" + Tecnico + "','" + numInt + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDPP.Clear();
            txtIDT.Clear();
            txtNumIn.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idPostProduccionTecnico = (int)dGVPPT.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE PostProduccionTecnico SET ESTATUS = 0 WHERE idPostProduccionTecnico =" + idPostProduccionTecnico.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string PostProduccion = txtIDPP.Text;
            string Tecnico = txtIDT.Text;
            string numInt = txtNumIn.Text;
            int idPostProduccionTecnico = (int)dGVPPT.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE PostProduccionTecnico SET idPostProduccion ='" + PostProduccion + "',idTecnico='" + Tecnico + "',numIntegrantes='" + numInt + "'WHERE idPostProduccionTecnico = " + idPostProduccionTecnico.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDPP.Clear();
            txtIDT.Clear();
            txtNumIn.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
