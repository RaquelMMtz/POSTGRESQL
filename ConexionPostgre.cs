using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoFinalPG
{
    internal class ConexionPostgre
    {
        public static NpgsqlConnection conexion = new NpgsqlConnection();

        static string servidor = "localhost";
        static string bd = "EstudiodeAnimacion";
        static string ususario = "postgres";
        static string password = "raquel06";
        static string puerto = "5433";

        static String cadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id =" + ususario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        private static void conectar()
        {
            try
            {
                conexion.ConnectionString = cadenaConexion;
                conexion.Open();
                //MessageBox.Show("Se conecto correctamente la base de datos");
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show("No se puede conectar a la base de datos de PostgreSQL, error:" + e.ToString());
            }
        }
        public static DataTable ejecutaConsultaSelect(string consulta)
        {
            conectar();
            NpgsqlDataAdapter adaptador = new NpgsqlDataAdapter(consulta, conexion);
            DataSet ds = new DataSet();
            adaptador.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public static void ejecutaConsulta(string consulta)
        {
            conectar();
            NpgsqlCommand comando = new NpgsqlCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}

