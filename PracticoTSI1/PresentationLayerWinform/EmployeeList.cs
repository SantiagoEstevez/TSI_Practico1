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
        //private IDALEmployees iDAM;

        public EmployeeList()
        {
            InitializeComponent();

            iDAE = new DALEmployeesEF();
            //iDAM = new DALEmployeesMongo();
            iBL = new BLEmployees(iDAE);
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            List<Employee> lisEmpleados = iBL.GetAllEmployees();

            lisEmpleados.ForEach(delegate (Employee emp) {
                var sTipo = "";

                if (emp.GetType() == typeof(PartTimeEmployee))
                {
                    sTipo = "Part time";
                }
                else
                {
                    sTipo = "Full time";
                }
                gridEmpleados.Rows.Add(emp.Name, "", sTipo);
            });
        }
    }
}
