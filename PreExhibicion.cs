using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class PreExhibicion : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public PreExhibicion()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVPreEx.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM PreExhibicion ORDER BY idPreExhibicion");
        }
        private void PreExhibicion_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;
            string calle = txtC.Text;
            string numero = txtNum.Text;
            string colonia = txtCol.Text;
            string ciudad = txtCiu.Text;
            string cp = txtCP.Text;
            string noP = txtNoP.Text;
            string idGerente = txtIDG.Text;
            consulta = "INSERT INTO PreExhibicion (fecha, calle, numero, colonia, ciudad, codigoPostal,numParticipantes, idGerente) values ('" + fecha + "','" + calle + "','" + numero + "','" + colonia + "','" + ciudad + "','" + cp + "','" + noP + "','" + idGerente + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtFecha.Clear();
            txtC.Clear();
            txtNum.Clear();
            txtCol.Clear();
            txtCiu.Clear();
            txtCP.Clear();
            txtIDG.Clear();
            txtNoP.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idPreExhibicion = (int)dGVPreEx.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE PreExhibicion SET ESTATUS = 0 WHERE idPreExhibicion =" + idPreExhibicion.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;
            string calle = txtC.Text;
            string numero = txtNum.Text;
            string colonia = txtCol.Text;
            string ciudad = txtCiu.Text;
            string cp = txtCP.Text;
            string noP = txtNoP.Text;
            string idGerente = txtIDG.Text;
            int idPreExhibicion = (int)dGVPreEx.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE PreExhibicion SET fecha ='" + fecha + "',calle='" + calle + "',numero='" + numero + "',colonia='" + colonia + "',ciudad='" + ciudad + "',codigoPostal='" + cp + "',numParticipantes='" + noP + "',idGerente='" + idGerente + "'WHERE idPreExhibicion = " + idPreExhibicion.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtFecha.Clear();
            txtC.Clear();
            txtNum.Clear();
            txtCol.Clear();
            txtCiu.Clear();
            txtCP.Clear();
            txtIDG.Clear();
            txtNoP.Clear(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
