using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class Musica : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Musica()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVMus.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM Musica ORDER BY idMusica");
        }
        private void Musica_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string genero = txtGen.Text;
            string fecha = txtfecha.Text;
            string idTecnico = txtIDTec.Text;
            consulta = "INSERT INTO Musica (nombre, genero, fecha, idTecnico) values ('" + nombre + "','" + genero + "','" + fecha + "','" + idTecnico + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtGen.Clear();
            txtfecha.Clear();
            txtIDTec.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idMusica = (int)dGVMus.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Musica SET ESTATUS = 0 WHERE idMusica =" + idMusica.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string genero = txtGen.Text;
            string fecha = txtfecha.Text;
            string idTecnico = txtIDTec.Text;
            int idMusica = (int)dGVMus.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE Musica SET nombre ='" + nombre + "',genero='" + genero + "',fechaEntrega='" + fecha + "',idTecnico='" + idTecnico + "'WHERE idMusica = " + idMusica.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtNombre.Clear();
            txtGen.Clear();
            txtfecha.Clear();
            txtIDTec.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
