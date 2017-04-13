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
    [ServiceContract(Namespace = "http://Microsoft.ServiceModel.Samples")]
    /*[ServiceContract(
        Namespace = "http://microsoft.wcf.documentation",
        Name = "SampleService",
        ProtectionLevel = ProtectionLevel.EncryptAndSign
    )]*/

    public interface IServiceEmployees
    {
        [OperationContract]
        void AddEmployee(Employee emp);

        [OperationContract]
        void DeleteEmployee(int id);

        [OperationContract]
        void UpdateEmployee(Employee emp);

        [OperationContract]
        List<Employee> GetAllEmployees();

        [OperationContract]
        Employee GetEmployee(int id);

        [OperationContract]
        double CalcPartTimeEmployeeSalary(int idEmployee, int hours);
    }
}
