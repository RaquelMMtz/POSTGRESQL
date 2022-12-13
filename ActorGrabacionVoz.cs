using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    public partial class ActorGrabacionVoz : Form
    {

        SqlConnection conexion;
        string consulta;
        SqlCommand comando;
        public ActorGrabacionVoz()
        {
            InitializeComponent();
            string cadena = @"Server=localhost\SQLEXPRESS;Database=EstudiodeAnimacion;Trusted_Connection=True";
            conexion = new SqlConnection(cadena);
        }
        private void MostrarDatos()
        {
            dGVAGV.DataSource = ConexionPostgre.ejecutaConsultaSelect("SELECT *FROM ActorGrabacionVoz ORDER BY idActorGrabacionVoz");
        }
        private void ActorGrabacionVoz_Load(object sender, EventArgs e)
        {
            MostrarDatos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Actor = txtIDA.Text;
            string GrabacionVoz = txtIDGV.Text;
            string numInt = txtNumIn.Text;
            consulta = "INSERT INTO ActorGrabacionVoz (idActor, idGrabacionVoz, numIntegrantes) values ('" + Actor + "','" + GrabacionVoz + "','" + numInt + "')";
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDA.Clear();
            txtIDGV.Clear();
            txtNumIn.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idActorGrabacionVoz = (int)dGVAGV.SelectedRows[0].Cells[0].Value;
            consulta = "UPDATE ActorGrabacionVoz SET ESTATUS = 0 WHERE idActorGrabacionVoz =" + idActorGrabacionVoz.ToString();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string Actor = txtIDA.Text;
            string GrabacionVoz = txtIDGV.Text;
            string numInt = txtNumIn.Text;
            int idActorGrabacionVoz = (int)dGVAGV.SelectedRows[0].Cells[0].Value;
            consulta = "  UPDATE ActorGrabacionVoz SET idActor ='" + Actor + "',idGrabacionVoz= '" + GrabacionVoz + "', numIntegrantes'" + numInt + "'WHERE idActorGrabacionVoz = " + idActorGrabacionVoz.ToString();
            conexion.Open();
            ConexionPostgre.ejecutaConsulta(consulta);
            MostrarDatos();
            txtIDA.Clear();
            txtIDGV.Clear();
            txtNumIn.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frm = new Form1();

            frm.Show();
        }
    }
}
