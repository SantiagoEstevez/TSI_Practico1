﻿//using BusinessLogicLayer;
//using DataAccessLayer;
//using Shared.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//namespace PresentationLayerWinform
//{
//    public partial class EmployeeAddEdit : Form
//    {
//        private IBLEmployees iBL;
//        private IDALEmployees iDAE;

//        public EmployeeAddEdit()
//        {
//            InitializeComponent();

//            iDAE = new DALEmployeesEF();
//            iBL = new BLEmployees(iDAE);
//        }

//        private void EmployeeAddEdit_Load(object sender, EventArgs e)
//        {
//            this.CenterToScreen();
//        }

//        private void btnCancelar_Click(object sender, EventArgs e)
//        {
//            this.Close();
//        }

//        private void btnAgregar_Click(object sender, EventArgs e)
//        {
//            try
//            {
//                if (this.chkFull.Checked)
//                {
//                    FullTimeEmployee oEmpleado = new FullTimeEmployee();
//                    oEmpleado.Name = txtNombre.Text;
//                    oEmpleado.StartDate = this.tpContratado.Value;
//                    ((FullTimeEmployee)oEmpleado).Salary = int.Parse(this.txtSalario.Text);
//                    iDAE.AddEmployee(oEmpleado);
//                }
//                else
//                {
//                    PartTimeEmployee oEmpleado = new PartTimeEmployee();
//                    oEmpleado.Name = txtNombre.Text;
//                    oEmpleado.StartDate = this.tpContratado.Value;
//                    ((PartTimeEmployee)oEmpleado).HourlyRate = double.Parse(this.txtSalario.Text);
//                    iDAE.AddEmployee(oEmpleado);
//                }

//                this.Close();
//            }
//            catch
//            {
//                throw;
//            }
//        }

//        private void chkPart_Click(object sender, EventArgs e)
//        {
//            this.chkFull.Checked = false;
//        }

//        private void chkFull_Click(object sender, EventArgs e)
//        {
//            this.chkPart.Checked = false;
//        }
//    }
//}

namespace PresentationLayerWinform
{
    public partial class EmployeeAddEdit : Form
    {
        ServiceEmployees.ServiceEmployeesClient Servicio = new ServiceEmployees.ServiceEmployeesClient();
        private Int32 EmployeeId = 0;

        public EmployeeAddEdit()
        {
            InitializeComponent();
        }

        public EmployeeAddEdit(Int32 id)
        {
            InitializeComponent();

            try
            {
                this.btnAgregar.Text = "Guardar";
                this.EmployeeId = id;

                //Cargo la informacion del empleado.
                ServiceEmployees.Employee emp = Servicio.GetEmployee(id);
                this.txtNombre.Text = emp.Name;
                this.tpContratado.Value = emp.StartDate;
                if (emp.GetType() == typeof(ServiceEmployees.FullTimeEmployee))
                {
                    this.txtSalario.Text = ((ServiceEmployees.FullTimeEmployee)emp).Salary.ToString();
                    this.chkFull.Checked = true;
                }
                else
                {
                    this.txtSalario.Text = ((ServiceEmployees.PartTimeEmployee)emp).HourlyRate.ToString();
                    this.chkPart.Checked = true;
                }
            }
            catch
            {
                throw;
            }
        }

        private void EmployeeAddEdit_Load(object sender, EventArgs e)
        {
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
                    ServiceEmployees.FullTimeEmployee oEmpleado = new ServiceEmployees.FullTimeEmployee();
                    oEmpleado.Name = txtNombre.Text;
                    oEmpleado.StartDate = this.tpContratado.Value;
                    ((ServiceEmployees.FullTimeEmployee)oEmpleado).Salary = int.Parse(this.txtSalario.Text);

                    if (this.EmployeeId == 0)
                    {
                        Servicio.AddEmployee(oEmpleado);
                    }
                    else
                    {
                        oEmpleado.Id = EmployeeId;
                        Servicio.UpdateEmployee(oEmpleado);
                    }
                }
                else
                {
                    ServiceEmployees.PartTimeEmployee oEmpleado = new ServiceEmployees.PartTimeEmployee();
                    oEmpleado.Name = txtNombre.Text;
                    oEmpleado.StartDate = this.tpContratado.Value;
                    ((ServiceEmployees.PartTimeEmployee)oEmpleado).HourlyRate = double.Parse(this.txtSalario.Text);

                    if (this.EmployeeId == 0)
                    {
                        Servicio.AddEmployee(oEmpleado);
                    }
                    else
                    {
                        oEmpleado.Id = EmployeeId;
                        Servicio.UpdateEmployee(oEmpleado);
                    }
                }

                this.Close();
            }
            catch
            {
                throw;
            }
        }

        private void chkPart_Click(object sender, EventArgs e)
        {
            this.chkFull.Checked = false;
        }

        private void chkFull_Click(object sender, EventArgs e)
        {
            this.chkPart.Checked = false;
        }
    }
}