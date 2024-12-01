using DemoApp.Service.Dtos;
using DemoApp.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Service
{
    public class StudentService : IStudentService
    {
        Dictionary<string, int> studentsInfos = new Dictionary<string, int>() {


              {"A10000", 78 },
              {"F50000", 92},
              {"N10000", 100}
        };


        public int GetAbsentCount(string stundetNo)
        {
            int defaultValue = 0;
            if (string.IsNullOrEmpty(stundetNo))
                return defaultValue;

            if (stundetNo.Length != 6)
                return defaultValue;

            if (!studentsInfos.ContainsKey(stundetNo))
                return defaultValue;

            return studentsInfos[stundetNo];
        }
        public decimal GetPoint(decimal mterm, decimal final)
        {
            if (final < 0 || final < 0) return 0;

            decimal avg = (mterm + final) / 2;
            return avg;

        }

        public IEnumerable<Student> GetStudents()
        {
            var students = new List<Student>() {
             new Student()
             {
                 Id=1,
                 Name="Fizuli"
             },
            new Student()
            {
                Id = 2,
                Name = "Nermin"
            },
            new Student()
            {
                Id = 3,
                Name = "Ugur"
            },
            };
            return students;

        }
    }
}

