using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.CrossCutting.Utilities.Models;

namespace Vueling.Infrastructure.Repository
{
    public class CrudMethods
    {
        public List<StudentDto> Read(string connectionString)
        {
            var students = new List<StudentDto>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var sql = "SELECT * FROM Student";

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string surname = reader.GetString(2);

                        var student = new StudentDto(id, name, surname);

                        students.Add(student);
                    }
                }
            }

            return students;
        }

        public StudentDto Create(StudentDto student, string connectionString)
        {
            var sql = $"INSERT INTO Student (name,surname) VALUES ('{student.Name}','{student.Surname}');";

            return ExecuteSQLQuery(student, sql, connectionString);
        }

        public StudentDto Update(StudentDto student, string connectionString)
        {
            var sql = $"UPDATE Student SET Name = '{student.Name}', Surname = '{student.Surname}' WHERE Id = {student.Id};";

            return ExecuteSQLQuery(student, sql, connectionString);
        }

        public StudentDto ExecuteSQLQuery(StudentDto student, string sql, string connectionString)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }

                return student;
            }
        }
    }
}
