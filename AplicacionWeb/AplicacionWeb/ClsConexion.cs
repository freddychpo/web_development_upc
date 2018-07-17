using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace AplicacionWeb
{
    public class ClsConexion
    {
        //protected SqlDataReader reader;
        //protected SqlDataAdapter AdaptadorDatos;
        //protected DataTable data;
        //protected SqlConnection oConexion = new SqlConnection();

        //public void Conectar(string Consulta)
        //{
        //    string strConexion = ConfigurationManager.ConnectionStrings["LineaBaseConnectionString"].ConnectionString;
        //    oConexion.ConnectionString = strConexion;
        //    oConexion.Open();
        //    AdaptadorDatos = new SqlDataAdapter(Consulta, oConexion);
        //    SqlCommandBuilder EjecutaComandos = new SqlCommandBuilder(AdaptadorDatos);
        //    data = new DataTable();

        //    AdaptadorDatos.Fill(data, Consulta);
        //    oConexion.Close();
        //}

        //public DataSet Data
        //{
        //    set { data = value; }
        //    get {return data;}
        //}
        //public SqlDataReader DataReader {
        //    set { reader = value ;}
        //    get {return reader;}
        //}

        private SqlConnection ConectarSQL()
        {

            string ConectionString = ConfigurationManager.ConnectionStrings["LineaBaseConnectionString"].ConnectionString;
            SqlConnection conexion = new SqlConnection(ConectionString);
            return conexion;
        }

        private int Open(SqlConnection Conexion)
        {
            try
            {
                Conexion.Open();
                return 1;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Detalles del error: " + ex.Message);
                return 0;
            }
        }

        private int Close(SqlConnection Conexion)
        {
            try
            {
                Conexion.Close();
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public DataTable ConsultaDT(string consulta)
        {
            SqlConnection Conexion = ConectarSQL();
            DataTable dataTable = new DataTable();
            if (Open(Conexion) == 1)
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(consulta, Conexion);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dataTable);
                    da.Dispose();
                    return dataTable;
                }
                catch (Exception ex)
                {
                    return null;
                }
                finally
                {
                    Close(Conexion);
                }
            }
            else
            {
                return null;
            }
        }

    }
}