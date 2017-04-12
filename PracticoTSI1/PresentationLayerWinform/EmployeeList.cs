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
    public partial class EmployeeList : Form
    {
        private IBLEmployees iBL;
        private IDALEmployees iDAE;
        private IDALEmployees iDAM;

        public EmployeeList()
        {
            InitializeComponent();

            iDAE = new DALEmployeesEF();
            iDAM = new DALEmployeesMongo();
            iBL = new BLEmployees(iDAE);
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            
            List<Employee> lisEmpleados = iBL.GetAllEmployees();
            lisEmpleados.ForEach(delegate (Employee emp) {
                string sTipo = "";
                string sHora = "";
                double dPaga = 0;

                if (emp.GetType() == typeof(PartTimeEmployee))
                {
                    sTipo = "Part time";
                    sHora = " / Hora";
                    dPaga = Convert.ToDouble(((PartTimeEmployee)emp).HourlyRate);
                }
                else
                {
                    sTipo = "Full time";
                    dPaga = ((FullTimeEmployee)emp).Salary;
                }
                gridEmpleados.Rows.Add(emp.Name, emp.StartDate, sTipo, dPaga + sHora);
            });
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EmployeeAddEdit frmAdd = new EmployeeAddEdit();
            frmAdd.Show();
        }
    }
}
