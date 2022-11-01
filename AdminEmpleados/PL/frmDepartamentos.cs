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

            dgvDepartamentos.DataSource = oDepartamentosDAL.MostrarDepartamentos().Tables[0];
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // instruccion  GUI (Obtener informacion de la presentacion)

            MessageBox.Show("Conectado...");        // bool

            // Clase DAL Departamentos.. Objeto que tiene la informacion de la GUI
            oDepartamentosDAL.Agregar(RecuperarInformacion());
            dgvDepartamentos.DataSource = oDepartamentosDAL.MostrarDepartamentos().Tables[0];

        }

        private DepartamentoBLL RecuperarInformacion()
        {
            DepartamentoBLL oDepartamentoDLL = new DepartamentoBLL();
            int ID = 0;  int.TryParse(txtID.Text, out ID);

            oDepartamentoDLL.ID = ID;

            oDepartamentoDLL.Departamento = txtNombre.Text;

            return oDepartamentoDLL;
        }

        private void Seleccionar(object sender, DataGridViewCellMouseEventArgs e)
        {
            int indice = e.RowIndex;

            txtID.Text = dgvDepartamentos.Rows[indice].Cells[0].Value.ToString();
            txtNombre.Text = dgvDepartamentos.Rows[indice].Cells[1].Value.ToString();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            oDepartamentosDAL.Eliminar(RecuperarInformacion());
            dgvDepartamentos.DataSource = oDepartamentosDAL.MostrarDepartamentos().Tables[0];

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            oDepartamentosDAL.Modificar(RecuperarInformacion());
            dgvDepartamentos.DataSource = oDepartamentosDAL.MostrarDepartamentos().Tables[0];
        }
    }
}
