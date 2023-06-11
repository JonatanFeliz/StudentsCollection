using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Vueling.CrossCutting.Utilities.Models;

namespace Vueling.Facade.Crud
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string GetData(int value);

        [OperationContract]
        StudentDto GetDataUsingDataContract(StudentDto composite);

        [OperationContract]
        List<StudentDto> GetStudents();

    }

}
