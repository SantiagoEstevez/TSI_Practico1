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
            this.CargarEmpleados();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            EmployeeAddEdit frmAdd = new EmployeeAddEdit();
            frmAdd.ShowDialog();
            this.CargarEmpleados();
        }

        private void CargarEmpleados()
        {
            DataTable dtEmpleado = new DataTable();
            DataColumn col;
            DataRow row;

            //Nombre
            col = new DataColumn();
            col.DataType = System.Type.GetType("System.String");
            col.ColumnName = "Nombre";
            col.Caption = "Nombre";
            col.ReadOnly = true;
            dtEmpleado.Columns.Add(col);

            //Fecha contratado
            col = new DataColumn();
            col.DataType = System.Type.GetType("System.String");
            col.ColumnName = "Contratado";
            col.Caption = "Contratado";
            col.ReadOnly = true;
            dtEmpleado.Columns.Add(col);

            //Tipo empleado
            col = new DataColumn();
            col.DataType = System.Type.GetType("System.String");
            col.ColumnName = "TipoEmpleado";
            col.Caption = "Tipo empleado";
            col.ReadOnly = true;
            dtEmpleado.Columns.Add(col);

            //Salario
            col = new DataColumn();
            col.DataType = System.Type.GetType("System.String");
            col.ColumnName = "Salario";
            col.Caption = "Salario";
            col.ReadOnly = true;
            dtEmpleado.Columns.Add(col);

            //Cargo filas
            List<Employee> lisEmpleados = iBL.GetAllEmployees();
            lisEmpleados.ForEach(delegate (Employee emp)
            {
                row = dtEmpleado.NewRow();
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

                row["Nombre"] = emp.Name;
                row["Contratado"] = emp.StartDate.ToString("d");
                row["TipoEmpleado"] = sTipo;
                row["Salario"] = dPaga + sHora;
                dtEmpleado.Rows.Add(row);
            });

            //Asigno data table a la grilla y adapto el tamaño de las columnas.
            gridEmpleados.DataSource = dtEmpleado;
            gridEmpleados.Columns[0].Width = 170;
            gridEmpleados.Columns[1].Width = 110;
        }
    }
}
