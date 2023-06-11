using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.CrossCutting.Utilities.Models
{
    [DataContract]
    public class StudentDto
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Surname { get; set; }

        public StudentDto(int id, string name, string surname)
        {
            Id = id;
            Name = name;
            Surname = surname;
        }

        public StudentDto(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
}
