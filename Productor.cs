using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class Productor : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Productor()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
           dGVPro.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM Productor ORDER BY idProductor");
        }
        private void Productor_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string ap = txtAP.Text;
            string am = txtAM.Text;
            string idGerente = txtIDG.Text;
            string idDirector = txtIDD.Text;
            consulta = "INSERT INTO Directivo (nombre, apellidoPaterno, apellidoMaterno, idGerente, idDirector) values ('" + nombre + "','" + ap + "','" + am + "','" + idGerente + "','" + idDirector + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtAP.Clear();
            txtAM.Clear();
            txtIDG.Clear();
            txtIDD.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idProductor = (int)dGVPro.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Productor SET ESTATUS = 0 WHERE idProductor =" + idProductor.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string ap = txtAP.Text;
            string am = txtAM.Text;
            string idGerente = txtIDG.Text;
            string idDirector = txtIDD.Text;
            int idProductor = (int)dGVPro.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE Productor SET nombre ='" + nombre + "',apellidoPaterno='" + ap + "',apellidoMaterno='" + am + "',idGerente='" + idGerente + "',idDirector='" + idDirector + "'WHERE idProductor = " + idProductor.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtAP.Clear();
            txtAM.Clear();
            txtIDG.Clear();
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
