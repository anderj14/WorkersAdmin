using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace AdminEmpleados.DAL
{
    class ConexionDAL
    {
        private string CadenaConexion = "Data Source=DESKTOP-ATI7PB7; Initial Catalog=dbSistema; Integrated Security = true";
        SqlConnection Conexion;

        public SqlConnection EstablecerConexion()
        {
            this.Conexion = new SqlConnection(this.CadenaConexion);

            return this.Conexion;
        }

        public bool PruebaConectar(string strComando)
        {
            try
            {

                SqlCommand Comando = new SqlCommand();

                Comando.CommandText = strComando;  //"INSERT INTO Departamentos (departamento) VALUES('Diseno')"
                Comando.Connection = this.EstablecerConexion();
                Conexion.Open();
                Comando.ExecuteNonQuery();
                Conexion.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
