using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ProyectoFinalPG
{
    public partial class AnimadorModelo : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public AnimadorModelo()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVAM.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM AnimadorModelo ORDER BY idAnimadorModelo");
        }

        private void AnimadorModelo_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Animador = txtIDANIM.Text;
            string Modelo = txtIDM.Text;
            string numInt = txtNumIn.Text;
            consulta = "INSERT INTO AnimadorModelo (idAnimador,idModelo, numIntegrantes) values ('" + Animador + "','" + Modelo + "','" + numInt + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDANIM.Clear();
            txtIDM.Clear();
            txtNumIn.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idAnimadorModelo = (int)dGVAM.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE AnimadorModelo SET ESTATUS = 0 WHERE idAnimadorModelo =" + idAnimadorModelo.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string Animador = txtIDANIM.Text;
            string Modelo = txtIDM.Text;
            string numInt = txtNumIn.Text;
            int idAnimadorModelo = (int)dGVAM.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE AnimadorModelo SET idAnimador ='" + Animador + "',idModelo='" + Modelo + "',numIntegrantes ='" + numInt + "'WHERE idAnimadorModelo = " + idAnimadorModelo.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDANIM.Clear();
            txtIDM.Clear();
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
