using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class Animatic2D : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Animatic2D()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGridVAnimatic2D.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM Animatic2D ORDER BY idAnimatic2D");
        }

        private void Animatic2D_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string fechaEntrega = txtfechaEntrega.Text;
            string personaje = txtPersonaje.Text;
            consulta = "INSERT INTO Animatic2D (fechaEntrega,personaje) values ('" + fechaEntrega + "','" + personaje + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtfechaEntrega.Clear();
            txtPersonaje.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idAnimaticD = (int)dGridVAnimatic2D.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Animatic2D SET ESTATUS = 0 WHERE idAnimatic2D =" + idAnimaticD.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string fechaEntrega = txtfechaEntrega.Text;
            string personaje = txtPersonaje.Text;
            int idAnimatic2D = (int)dGridVAnimatic2D.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE Animatic2D SET fechaEntrega ='" + fechaEntrega + "',personaje ='" + personaje + "','" + "'WHERE idAnimatic2D = " + idAnimatic2D.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtPersonaje.Clear();
            txtfechaEntrega.Clear();
        }
    

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
