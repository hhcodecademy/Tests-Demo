using DemoApp.Service;
using DemoApp.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.UnitTest
{
    public class StudentServiceTest
    {
        private readonly IStudentService _studentService;
        public StudentServiceTest()
        {
            _studentService = new StudentService();
        }
        [Fact]
        public void Get_PassEmptyString_ReturnZero() {

            //Arrange

            //Action
           var actualResult= _studentService.GetAbsentCount(string.Empty);

            //Asert
            Assert.Equal(0, actualResult);


        }
        [Fact]
        public void Get_PassShortString_ReturnZero()
        {

            //Arrange

            //Action
            var actualResult = _studentService.GetAbsentCount("a00");

            //Asert
            Assert.Equal(0, actualResult);


        }
        [Fact]
        public void Get_PassLongString_ReturnZero()
        {

            //Arrange

            //Action
            var actualResult = _studentService.GetAbsentCount("a00000");

            //Asert
            Assert.Equal(0, actualResult);


        }
    
        [Fact]
        public void Get_PassCorrectNumber_ReturnStudentNumber()
        {

            //Arrange       
            string studentNumber = "A10000";

            //Action
            var actualResult = _studentService.GetAbsentCount(studentNumber);

            //Asert
            Assert.Equal(78, actualResult);


        }
        [Theory]
        [InlineData(10,60,35)]
        [InlineData(10, 70, 40)]
        [InlineData(20, 40, 30)]
        public void Get_CalculateAvg_ReturnTotal(int mterm,int final,int result)
        {
            //arange
            var actualResult = _studentService.GetPoint(mterm,final);

            Assert.Equal(result, actualResult);
        }

    }
}
