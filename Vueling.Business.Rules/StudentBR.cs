using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.CrossCutting.Utilities.Models;
using Vueling.Infrastructure.Repository;

namespace Vueling.Business.Rules
{
    public class StudentBR
    {
        public List<StudentDto> GetStudentsBR()
        {
            StudentRepository studentRepository = new StudentRepository();

            return studentRepository.GetStudentsFromDB();
        }

        public StudentDto CreateStudentValidation(StudentDto student)
        {
            if (StudentValidation(student))
            {
                StudentRepository studentRepository = new StudentRepository();

                return studentRepository.CreateStudentInDB(student);
            }

            return null;
        }

        public StudentDto UpdateStudentValidation(StudentDto student)
        {
            if (StudentValidation(student))
            {
                StudentRepository studentRepository = new StudentRepository();

                return studentRepository.UpdateStudentInDB(student);
            }

            return null;
        }

        public StudentDto DeleteStudentValidation(StudentDto student)
        {
            StudentRepository studentRepository = new StudentRepository();

            return studentRepository.DeleteStudentInDB(student);
        }

        public bool StudentValidation(StudentDto student)
        {
            if (string.IsNullOrWhiteSpace(student.Name) && string.IsNullOrWhiteSpace(student.Surname))
            {
                return false;
            }

            return true;
        }
    }
}
