using BusinessLogicLayer;
using DataAccessLayer;
using Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayerWinform
{
    public partial class EmployeeAddEdit : Form
    {
        private IBLEmployees iBL;
        private IDALEmployees iDAE;

        public EmployeeAddEdit()
        {
            InitializeComponent();

            iDAE = new DALEmployeesEF();
            iBL = new BLEmployees(iDAE);
        }

        private void EmployeeAddEdit_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.chkFull.Checked)
                {
                    FullTimeEmployee oEmpleado = new FullTimeEmployee();
                    oEmpleado.Name = txtNombre.Text;
                    oEmpleado.StartDate = this.tpContratado.Value;
                    ((FullTimeEmployee)oEmpleado).Salary = int.Parse(this.txtSalario.Text);
                    iDAE.AddEmployee(oEmpleado);
                }
                else
                {
                    PartTimeEmployee oEmpleado = new PartTimeEmployee();
                    oEmpleado.Name = txtNombre.Text;
                    oEmpleado.StartDate = this.tpContratado.Value;
                    ((PartTimeEmployee)oEmpleado).HourlyRate = double.Parse(this.txtSalario.Text);
                    iDAE.AddEmployee(oEmpleado);
                }

                MessageBox.Show("Empleado agregado con exito.", "ALTA EMPLEADO", MessageBoxButtons.OK);
                this.Close();
            }
            catch
            {
                throw;
            }
        }

        private void chkPart_CheckedChanged(object sender, EventArgs e)
        {
            this.chkFull.Checked = false;
        }

        private void chkFull_CheckedChanged(object sender, EventArgs e)
        {
            this.chkPart.Checked = false;
        }
    }
}
