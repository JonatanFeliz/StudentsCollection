using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Vueling.Business.Rules;
using Vueling.CrossCutting.Utilities.Models;

namespace Vueling.Facade.Crud
{
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public StudentDto GetDataUsingDataContract(StudentDto composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.Name == "Jonatan")
            {
                composite.Surname += "eliz";
            }
            return composite;
        }

        public List<StudentDto> GetStudents()
        {
            StudentBR studentBR = new StudentBR();

            return studentBR.GetStudentsBR();
        }

        public StudentDto InsertStudents(StudentDto student)
        {
            StudentBR studentBR = new StudentBR();

            return studentBR.CreateStudentValidation(student);
        }

        public StudentDto UpdateStudents(StudentDto student)
        {
            StudentBR studentBR = new StudentBR();

            return studentBR.UpdateStudentValidation(student);
        }

        public StudentDto DeleteStudents(StudentDto student)
        {
            StudentBR studentBR = new StudentBR();

            return studentBR.DeleteStudentValidation(student);
        }
    }
}
