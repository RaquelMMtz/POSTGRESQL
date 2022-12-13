using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class StoryBoard : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public StoryBoard()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
           dGVSS.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM StoryBoard ORDER BY idAnimatic2D");
        }
        private void StoryBoard_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string tituloE = txtTituloE.Text;
            string ideaEs = label2.Text;
            string fechaEntrega = txtFecha.Text;
            consulta = "INSERT INTO StoryBoard (tituloEscena, ideaEscena, fechaEntrega) values ('" + tituloE + "','" + ideaEs + "','" + fechaEntrega + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtTituloE.Clear();
            txtIdeaE.Clear();
            txtFecha.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idStoryBoard = (int)dGVSS.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE StoryBoard SET ESTATUS = 0 WHERE idStoryBoard =" + idStoryBoard.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string tituloE = txtTituloE.Text;
            string ideaEs = label2.Text;
            string fechaEntrega = txtFecha.Text;
            int idStoryBoard = (int)dGVSS.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE StoryBoard SET tituloEscena ='" + tituloE + "',ideaEscena='" + ideaEs + "',fechaEntrega='" + fechaEntrega + "'WHERE idStoryBoard = " + idStoryBoard.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtTituloE.Clear();
            txtIdeaE.Clear();
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
