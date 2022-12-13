using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class Publicidad : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Publicidad()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVPublicidad.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM Publicidad ORDER BY idPublicidad");
        }

        private void Publicidad_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string MT = txtMT.Text;
            string Precio = txtPrecio.Text;
            string idGerente = txtIDG.Text;
            consulta = "INSERT INTO Publicidad (medioTransmicion,precio, idGerente) values ('" + MT + "','" + Precio + "','" + idGerente + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDG.Clear();
            txtPrecio.Clear();
            txtMT.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idPublicidad = (int)dGVPublicidad.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Publicidad SET ESTATUS = 0 WHERE idPublicidad =" + idPublicidad.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string MT = txtMT.Text;
            string Precio = txtPrecio.Text;
            string idGerente = txtIDG.Text;
            int idPublicidad = (int)dGVPublicidad.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE Publicidad SET medioTransimicion ='" + MT + "',precio='" + Precio + "',idGerente='" + idGerente + "'WHERE idPublicidad = " + idPublicidad.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDG.Clear();
            txtPrecio.Clear();
            txtMT.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
