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
            try
            {
                StudentBR studentBR = new StudentBR();

                return studentBR.GetStudentsBR();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            
        }

        public StudentDto InsertStudents(StudentDto student)
        {
            try
            {
                StudentBR studentBR = new StudentBR();

                return studentBR.CreateStudentValidation(student);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public StudentDto UpdateStudents(StudentDto student)
        {
            try
            {
                StudentBR studentBR = new StudentBR();

                return studentBR.UpdateStudentValidation(student);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public StudentDto DeleteStudents(StudentDto student)
        {
            try
            {
                StudentBR studentBR = new StudentBR();

                return studentBR.DeleteStudentValidation(student);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
