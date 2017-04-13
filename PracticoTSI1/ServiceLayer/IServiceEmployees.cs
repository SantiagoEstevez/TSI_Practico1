using Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    [ServiceContract(
        Namespace = "http://microsoft.wcf.documentation",
        Name = "SampleService",
        ProtectionLevel = ProtectionLevel.EncryptAndSign
    )]

    public interface IServiceEmployees
    {
        [OperationContract]

        void AddEmployee(Employee emp);

        void DeleteEmployee(int id);

        void UpdateEmployee(Employee emp);

        List<Employee> GetAllEmployees();

        Employee GetEmployee(int id);

        double CalcPartTimeEmployeeSalary(int idEmployee, int hours);
    }
}
