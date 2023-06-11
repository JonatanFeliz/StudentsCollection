using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.CrossCutting.Utilities.Models;
using System.Data.SqlClient;

namespace Vueling.Infrastructure.Repository
{
    public class StudentRepository
    {
        public string connectionString = "Data Source=.;Initial Catalog=VuelingCrud; User ID=sa; Password=Boruga01@";
        public List<StudentDto> GetStudentsFromDB()
        {
            CrudMethods crud = new CrudMethods();

            return crud.Read(connectionString);
        }

        public StudentDto CreateStudentInDB(StudentDto student)
        {
            CrudMethods crud = new CrudMethods();

            return crud.Create(student,connectionString);
        }
    }
}
