//using BusinessLogicLayer;
//using DataAccessLayer;
//using Shared.Entities;
using System;
using System.Data;
using System.Windows.Forms;

//namespace PresentationLayerWinform
//{
//Pata hacer funcionar esto se requeiere agregar las referencias a shared, capa de logica de negocio y capa de datos.
//    public partial class EmployeeList : Form
//    {

//        private IBLEmployees iBL;
//        private IDALEmployees iDAE;
//        private IDALEmployees iDAM;

//        public EmployeeList()
//        {
//            InitializeComponent();

//            iDAE = new DALEmployeesEF();
//            iDAM = new DALEmployeesMongo();
//            iBL = new BLEmployees(iDAE);
//        }

//        private void EmployeeList_Load(object sender, EventArgs e)
//        {
//            this.CenterToScreen();
//            this.CargarEmpleados();
//        }

//        private void btnSalir_Click(object sender, EventArgs e)
//        {
//            Application.Exit();
//        }

//        private void btnNuevo_Click(object sender, EventArgs e)
//        {
//            EmployeeAddEdit frmAdd = new EmployeeAddEdit();
//            frmAdd.ShowDialog();
//            this.CargarEmpleados();
//        }

//        private void CargarEmpleados()
//        {
//            DataTable dtEmpleado = new DataTable();
//            DataColumn col;
//            DataRow row;

//            //Nombre
//            col = new DataColumn();
//            col.DataType = System.Type.GetType("System.String");
//            col.ColumnName = "Nombre";
//            col.Caption = "Nombre";
//            col.ReadOnly = true;
//            dtEmpleado.Columns.Add(col);

//            //Fecha contratado
//            col = new DataColumn();
//            col.DataType = System.Type.GetType("System.String");
//            col.ColumnName = "Contratado";
//            col.Caption = "Contratado";
//            col.ReadOnly = true;
//            dtEmpleado.Columns.Add(col);

//            //Tipo empleado
//            col = new DataColumn();
//            col.DataType = System.Type.GetType("System.String");
//            col.ColumnName = "TipoEmpleado";
//            col.Caption = "Tipo empleado";
//            col.ReadOnly = true;
//            dtEmpleado.Columns.Add(col);

//            //Salario
//            col = new DataColumn();
//            col.DataType = System.Type.GetType("System.String");
//            col.ColumnName = "Salario";
//            col.Caption = "Salario";
//            col.ReadOnly = true;
//            dtEmpleado.Columns.Add(col);

//            //Cargo filas
//            List<Employee> lisEmpleados = iBL.GetAllEmployees();
//            lisEmpleados.ForEach(delegate (Employee emp)
//            {
//                row = dtEmpleado.NewRow();
//                string sTipo = "";
//                string sHora = "";
//                double dPaga = 0;

//                if (emp.GetType() == typeof(PartTimeEmployee))
//                {
//                    sTipo = "Part time";
//                    sHora = " / Hora";
//                    dPaga = Convert.ToDouble(((PartTimeEmployee)emp).HourlyRate);
//                }
//                else
//                {
//                    sTipo = "Full time";
//                    dPaga = ((FullTimeEmployee)emp).Salary;
//                }

//                row["Nombre"] = emp.Name;
//                row["Contratado"] = emp.StartDate.ToString("d");
//                row["TipoEmpleado"] = sTipo;
//                row["Salario"] = dPaga + sHora;
//                dtEmpleado.Rows.Add(row);
//            });

//            //Asigno data table a la grilla y adapto el tamaño de las columnas.
//            gridEmpleados.DataSource = dtEmpleado;
//            gridEmpleados.Columns[0].Width = 170;
//            gridEmpleados.Columns[1].Width = 110;
//        }
//    }
//}

namespace PresentationLayerWinform
{
    public partial class EmployeeList : Form
    {
        ServiceEmployees.ServiceEmployeesClient Servicio = new ServiceEmployees.ServiceEmployeesClient();

        public EmployeeList()
        {
            InitializeComponent();
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
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

            try
            {
                //Id empleado
                col = new DataColumn();
                col.DataType = typeof(Int32);
                col.ColumnName = "Id";
                col.Caption = "Id";
                col.ReadOnly = true;
                dtEmpleado.Columns.Add(col);

                //Nombre
                col = new DataColumn();
                col.DataType = typeof(string);
                col.ColumnName = "Nombre";
                col.Caption = "Nombre";
                col.ReadOnly = true;
                dtEmpleado.Columns.Add(col);

                //Fecha contratado
                col = new DataColumn();
                col.DataType = typeof(string);
                col.ColumnName = "Contratado";
                col.Caption = "Contratado";
                col.ReadOnly = true;
                dtEmpleado.Columns.Add(col);

                //Tipo empleado
                col = new DataColumn();
                col.DataType = typeof(string);
                col.ColumnName = "TipoEmpleado";
                col.Caption = "Tipo empleado";
                col.ReadOnly = true;
                dtEmpleado.Columns.Add(col);

                //Salario
                col = new DataColumn();
                col.DataType = typeof(string);
                col.ColumnName = "Salario";
                col.Caption = "Salario";
                col.ReadOnly = true;
                dtEmpleado.Columns.Add(col);

                //Cargo filas
                ServiceEmployees.Employee[] lisEmpleados = Servicio.GetAllEmployees();
                for (int i = 0; i < lisEmpleados.Length; i++)
                {
                    row = dtEmpleado.NewRow();
                    string sTipo = "";
                    string sHora = "";
                    double dPaga = 0;

                    if (lisEmpleados[i].GetType() == typeof(ServiceEmployees.PartTimeEmployee))
                    {
                        sTipo = "Part time";
                        sHora = " / Hora";
                        dPaga = Convert.ToDouble(((ServiceEmployees.PartTimeEmployee)lisEmpleados[i]).HourlyRate);
                    }
                    else
                    {
                        sTipo = "Full time";
                        dPaga = ((ServiceEmployees.FullTimeEmployee)lisEmpleados[i]).Salary;
                    }

                    row["Id"] = lisEmpleados[i].Id;
                    row["Nombre"] = lisEmpleados[i].Name;
                    row["Contratado"] = lisEmpleados[i].StartDate.ToString("d");
                    row["TipoEmpleado"] = sTipo;
                    row["Salario"] = dPaga + sHora;
                    dtEmpleado.Rows.Add(row);
                }

                //Asigno data table a la grilla y adapto el tamaño de las columnas.
                gridEmpleados.DataSource = dtEmpleado;
                gridEmpleados.Columns[0].Width = 20;
                gridEmpleados.Columns[1].Width = 170;
                gridEmpleados.Columns[2].Width = 110;
            }
            catch
            {
                throw;
            }
        }

        private void gridEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string sId = gridEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString();
                string sOpcion = MessageBoxEditarEliminar.ShowBox();
                if (sOpcion == "1")
                {
                    EmployeeAddEdit frmAdd = new EmployeeAddEdit(Int32.Parse(sId));
                    frmAdd.ShowDialog();
                    this.CargarEmpleados();
                }
                else if (sOpcion == "2")
                {
                    Servicio.DeleteEmployee(Int32.Parse(sId));
                    this.CargarEmpleados();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
