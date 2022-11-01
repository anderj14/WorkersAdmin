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

        public bool agregar(DepartamentoBLL oDepartamentosBLL)
        {
            return conexion.ejecutarComandoSinRetornoDatos(
                "INSERT INTO Departamentos (departamento) VALUES('"+ oDepartamentosBLL .Departamento+"')"
                );
        }
    }
}
