using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class Gerente : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Gerente()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVGerente.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM Gerente ORDER BY idGerente");
        }
        private void Gerente_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string ap = txtAP.Text;
            string am = txtAM.Text;
            string departamento = txtDep.Text;
            string idDirectivo = txtidD.Text;
            consulta = "INSERT INTO Directivo (nombre, apellidoPaterno, apellidoMaterno, departamento, idDirectivo) values ('" + nombre + "','" + ap + "','" + am + "','" + departamento + "','" + idDirectivo + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtAP.Clear();
            txtAM.Clear();
            txtidD.Clear();
            txtDep.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idGerente = (int)dGVGerente.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Gerente SET ESTATUS = 0 WHERE idGerente =" + idGerente.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string ap = txtAP.Text;
            string am = txtAM.Text;
            string departamento = txtDep.Text;
            string idDirectivo = txtidD.Text;
            int idGerente = (int)dGVGerente.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE Gerente SET nombre ='" + nombre + "',apellidoPaterno='" + ap + "',apellidoMaterno='" + am + "',departamento='" + departamento + "',idDirectivo='" + idDirectivo + "'WHERE idGerente = " + idGerente.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtAP.Clear();
            txtAM.Clear();
            txtidD.Clear();
            txtDep.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
