using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.CrossCutting.Utilities.Models;

namespace Vueling.Infrastructure.Repository
{
    internal class CrudMethods
    {
        public List<StudentDto> Read(string connectionString)
        {
            var students = new List<StudentDto>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM Student", connection))
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
    }
}
