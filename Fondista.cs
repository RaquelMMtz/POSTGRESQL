using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class Fondista : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Fondista()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVFondista.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM Fondista ORDER BY idFondista");
        }
        private void Fondista_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string ap = txtAP.Text;
            string am = txtAM.Text;
            string idDirector = txtidD.Text;
            consulta = "INSERT INTO Directivo (nombre, apellidoPaterno, apellidoMaterno, idDirector) values ('" + nombre + "','" + ap + "','" + am + "','" + idDirector + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtAP.Clear();
            txtAM.Clear();
            txtidD.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idFondista = (int)dGVFondista.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Fondista SET ESTATUS = 0 WHERE idFondista =" + idFondista.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string ap = txtAP.Text;
            string am = txtAM.Text;
            string idDirector = txtidD.Text;
            int idFondista = (int)dGVFondista.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE Fondista SET nombre ='" + nombre + "',apellidoPaterno='" + ap + "',apellidoMaterno='" + am + "',idDirector='" + idDirector + "'WHERE idFondista = " + idFondista.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtAP.Clear();
            txtAM.Clear();
            txtidD.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();

        }
    }
}
