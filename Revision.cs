using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class Revision : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Revision()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVR.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM Revision ORDER BY idRevision");
        }
        private void Revision_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string PR = txtPR.Text;
            string SR = txtSR.Text;
            string idDirector = txtIDD.Text;
            consulta = "INSERT INTO Rediseño (primeraRevision, segundaRevision, idDirector) values ('" + PR + "','" + SR + "','" + idDirector + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtPR.Clear();
            txtSR.Clear();
            txtIDD.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idRevision = (int)dGVR.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Revision SET ESTATUS = 0 WHERE idRevision =" + idRevision.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string PR = txtPR.Text;
            string SR = txtSR.Text;
            string idDirector = txtIDD.Text;
            int idRevision = (int)dGVR.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE Revision SET primeraRevision ='" + PR + "',segundRevision='" + SR + "',idDirector='" + idDirector + "'WHERE idRevision = " + idRevision.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta); ;
            MostrarDatos();
            txtPR.Clear();
            txtSR.Clear();
            txtIDD.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
