using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.CrossCutting.Utilities.Models;
using System.Data.SqlClient;
using System.Configuration;

namespace Vueling.Infrastructure.Repository
{
    public class StudentRepository
    {
        public string connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;

        public List<StudentDto> GetStudentsFromDB()
        {
            CrudMethods crud = new CrudMethods();

            return crud.Read(connectionString);
        }

        public StudentDto CreateStudentInDB(StudentDto student)
        {
            CrudMethods crud = new CrudMethods();

            var sql = $"INSERT INTO Student (name,surname) VALUES ('{student.Name}','{student.Surname}');";

            return crud.ExecuteSQLQuery(student, sql, connectionString);
        }

        public StudentDto UpdateStudentInDB(StudentDto student)
        {
            CrudMethods crud = new CrudMethods();

            var sql = $"UPDATE Student SET Name = '{student.Name}', Surname = '{student.Surname}' WHERE Id = {student.Id};";

            return crud.ExecuteSQLQuery(student, sql, connectionString);
        }

        public StudentDto DeleteStudentInDB(StudentDto student)
        {
            CrudMethods crud = new CrudMethods();

            var sql = $"DELETE FROM Student WHERE Id = {student.Id};";

            return crud.ExecuteSQLQuery(student, sql, connectionString);
        }
    }
}
