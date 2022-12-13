using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class Modelado : Form
    {
        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public Modelado()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVMod.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM Modelado ORDER BY idModelado");
        }
        private void Modelado_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;
            string idAsisAnim = txtIDAA.Text;
            consulta = "INSERT INTO Modelado (fechaEntrega, idAsistenteAnimacion values ('" + fecha + "','" + idAsisAnim + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtFecha.Clear();
            txtIDAA.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idModelado = (int)dGVMod.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE Modelado SET ESTATUS = 0 WHERE idModelado =" + idModelado.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string fecha = txtFecha.Text;
            string idAsisAnim = txtIDAA.Text;
            int idModelado = (int)dGVMod.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE Modelado SET fechaEntrega ='" + fecha + "',idAsistenteAnimacion='" + idAsisAnim + "'WHERE idModelado = " + idModelado.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtFecha.Clear();
            txtIDAA.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
