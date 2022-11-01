using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using AdminEmpleados.BLL;

namespace AdminEmpleados.DAL
{
    class DepartamentoDAL
    {
        ConexionDAL conexion;

        public DepartamentoDAL()
        {
            conexion = new ConexionDAL();
        }

        public bool Agregar(DepartamentoBLL oDepartamentosBLL)
        {
            return conexion.ejecutarComandoSinRetornoDatos(
                "INSERT INTO Departamentos (departamento) VALUES('" + oDepartamentosBLL.Departamento + "')"
                );
        }

        public int Eliminar(DepartamentoBLL oDepartamentoBLL)
        {

            conexion.ejecutarComandoSinRetornoDatos(
                "DELETE FROM Departamentos WHERE ID="+oDepartamentoBLL.ID
                );
            return 1;
        }

        public DataSet MostrarDepartamentos()
        {
            SqlCommand sentencia = new SqlCommand("SELECT * FROM Departamentos");

            return conexion.EjecutarSentencia(sentencia);
        }
    }
}
