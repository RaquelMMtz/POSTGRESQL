using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class Idea : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Idea()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVIdea.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM Idea ORDER BY Idea");
        }
        private void Idea_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string propuesta = txtPro.Text;
            string fecha = txtFecha.Text;
            string idJuntaDirectiva = txtidJD.Text;
            consulta = "INSERT INTO Idea (propuesta, fechaEntrega, idJuntaDirectiva) values ('" + propuesta + "','" + fecha + "','" + idJuntaDirectiva + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtPro.Clear();
            txtFecha.Clear();
            txtidJD.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idIdea = (int)dGVIdea.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Idea SET ESTATUS = 0 WHERE idIdea =" + idIdea.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string propuesta = txtPro.Text;
            string fecha = txtFecha.Text;
            string idJuntaDirectiva = txtidJD.Text;
            int idIdea = (int)dGVIdea.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE Idea SET propuesta ='" + propuesta + "',fechaEntrega='" + fecha + "',idJuntaDirectiva='" + idJuntaDirectiva + "'WHERE idIdea = " + idIdea.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtPro.Clear();
            txtFecha.Clear();
            txtidJD.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
