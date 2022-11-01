using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AdminEmpleados.BLL;
using AdminEmpleados.DAL;

namespace AdminEmpleados.PL
{
    public partial class frmDepartamentos : Form
    {

        DepartamentoDAL oDepartamentosDAL;

        public frmDepartamentos()
        {
            oDepartamentosDAL = new DepartamentoDAL();
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // instruccion  GUI (Obtener informacion de la presentacion)
            RecuperarInformacion();

            MessageBox.Show("Conectado...");        // bool

            // Clase DAL Departamentos.. Objeto que tiene la informacion de la GUI
            oDepartamentosDAL.agregar(RecuperarInformacion());
        }

        private DepartamentoBLL RecuperarInformacion()
        {
            DepartamentoBLL oDepartamentoDLL = new DepartamentoBLL();
            int ID = 0;  int.TryParse(txtID.Text, out ID);

            oDepartamentoDLL.ID = ID;

            oDepartamentoDLL.Departamento = txtNombre.Text;

            return oDepartamentoDLL;
        }
    }
}
