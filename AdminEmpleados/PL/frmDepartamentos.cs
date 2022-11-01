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
            oDepartamentosDAL.agregar();
        }

        private void RecuperarInformacion()
        {
            DepartamentoBLL oDepartamento = new DepartamentoBLL();
            int ID = 0;  int.TryParse(txtID.Text, out ID);

            oDepartamento.ID = ID;

            oDepartamento.Departamento = txtNombre.Text;

            MessageBox.Show(oDepartamento.ID.ToString());
            MessageBox.Show(oDepartamento.Departamento);
        }
    }
}
