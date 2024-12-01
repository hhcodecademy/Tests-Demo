using DemoApp.Service.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.Service.Interfaces
{
    public interface IStudentService
    {
        int GetAbsentCount(string stundetNo);
        decimal GetPoint(decimal mterm, decimal final);

        IEnumerable<Student> GetStudents();
    }
}
