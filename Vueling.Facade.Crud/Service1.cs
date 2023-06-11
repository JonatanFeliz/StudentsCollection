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
