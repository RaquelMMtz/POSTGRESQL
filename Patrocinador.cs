using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class Patrocinador : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Patrocinador()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVPat.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM Patrocinador ORDER BY idPatrocinador");
        }
        private void Patrocinador_Load(object sender, EventArgs e)
        {
            MostrarDatos(); 
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string ap = txtAP.Text;
            string am = txtAM.Text;
            string empresa = txtEmp.Text;
            string idJuntaDirectiva = txtidJD.Text;
            consulta = "INSERT INTO Patrocinador (nombre, apellidoPaterno, apellidoMaterno, empresa, idJuntaDirectiva) values ('" + nombre + "','" + ap + "','" + am + "','" + empresa + "','" + idJuntaDirectiva + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtAP.Clear();
            txtAM.Clear();
            txtidJD.Clear();
            txtEmp.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idPatrocinador = (int)dGVPat.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Patrocinador SET ESTATUS = 0 WHERE idPatrocinador =" + idPatrocinador.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string ap = txtAP.Text;
            string am = txtAM.Text;
            string empresa = txtEmp.Text;
            string idJuntaDirectiva = txtidJD.Text;
            int idPatrocinador = (int)dGVPat.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE Patrocinador SET nombre ='" + nombre + "',apellidoPaterno='" + ap + "',apellidoMaterno='" + am + "',empresa='" + empresa + "',idJuntaDirectiva='" + idJuntaDirectiva + "'WHERE idPatrocinador = " + idPatrocinador.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtAP.Clear();
            txtAM.Clear();
            txtidJD.Clear();
            txtEmp.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
