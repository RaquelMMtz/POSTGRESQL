using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class Animador : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Animador()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVAnimador.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM Animador ORDER BY idAnimador");
        }
        private void Animador_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string ap = txtAP.Text;
            string am = txtAM.Text;
            string especializacion = txtEspe.Text;
            string idDirector = txtidD.Text;
            consulta = "INSERT INTO Animador (nombre, apellidoPaterno, apellidoMaterno, especializacion, idDirector) values ('" + nombre + "','" + ap + "','" + am + "','" + especializacion + "','" + idDirector + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtAP.Clear();
            txtAM.Clear();
            txtidD.Clear();
            txtEspe.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idAnimador = (int)dGVAnimador.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Animador SET ESTATUS = 0 WHERE idAnimador =" + idAnimador.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string ap = txtAP.Text;
            string am = txtAM.Text;
            string especializacion = txtEspe.Text;
            string idDirector = txtidD.Text;
            int idAnimador = (int)dGVAnimador.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE Animador SET nombre ='" + nombre + "',apellidoPaterno='" + ap + "',apellidoMaterno='" + am + "',especializacion ='" + especializacion + "',idDirector='" + idDirector + "'WHERE idAnimador = " + idAnimador.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtAP.Clear();
            txtAM.Clear();
            txtidD.Clear();
            txtEspe.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
