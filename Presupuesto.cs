using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class Presupuesto : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Presupuesto()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVPre.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM Animatic2D ORDER BY idAnimatic2D");
        }
        private void Presupuesto_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string des = txtDes.Text;
            string AT = txtAT.Text;
            string AA = txtAA.Text;
            string Mar = txtM.Text;
            string idGerente = txtIDG.Text;
            consulta = "INSERT INTO Presupuesto (desarrolloInv, areaTecnica, areaArtistica, marketing, idGerente) values ('" + des + "','" + AT + "','" + AA + "','" + Mar + "','" + idGerente + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtM.Clear();
            txtIDG.Clear();
            txtDes.Clear();
            txtAT.Clear();
            txtAA.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idPresupuesto = (int)dGVPre.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Prsupuesto SET ESTATUS = 0 WHERE idPresupuesto =" + idPresupuesto.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string des = txtDes.Text;
            string AT = txtAT.Text;
            string AA = txtAA.Text;
            string Mar = txtM.Text;
            string idGerente = txtIDG.Text;
            int idPresupuesto = (int)dGVPre.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE presupuesto SET desarrolloInv ='" + des + "',areaTecnica='" + AT + "',areaArtistica='" + AA + "',Marketing='" + Mar + "',idGerente='" + idGerente + "'WHERE idPresupuesto = " + idPresupuesto.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtM.Clear();
            txtIDG.Clear();
            txtDes.Clear();
            txtAT.Clear();
            txtAA.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
