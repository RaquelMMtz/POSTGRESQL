using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class Arte_Conceptual : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Arte_Conceptual()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVArteConceptual.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM ArteConceptual ORDER BY idArteConceptual");
        }
        private void Arte_Conceptual_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string fechaEntrega = txtFechaEntrega.Text;
            string concepto = txtConcepto.Text;
            consulta = "INSERT INTO ArteConceptual (concepto,fechaEntrega) values ('" + concepto + "','" + fechaEntrega + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtFechaEntrega.Clear();
            txtConcepto.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idArteConceptual = (int)dGVArteConceptual.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE ArteConceptual SET ESTATUS = 0 WHERE idArteConceptual =" + idArteConceptual.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string fechaEntrega = txtFechaEntrega.Text;
            string concepto = txtConcepto.Text;
            int idArteConceptual = (int)dGVArteConceptual.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE ArteConceptual SET concepto ='" + concepto + "',fechaEntrega='" + fechaEntrega + "','" + "'WHERE idArteConceptual = " + idArteConceptual.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtConcepto.Clear();
            txtFechaEntrega.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
