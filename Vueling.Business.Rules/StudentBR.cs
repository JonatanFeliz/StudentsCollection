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
    }
}
