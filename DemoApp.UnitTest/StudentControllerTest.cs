using DemoApp.Service;
using DemoApp.Service.Dtos;
using DemoApp.Service.Interfaces;
using DemoApp.UI.Controllers;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp.UnitTest
{
    public class StudentControllerTest
    {
        private readonly Mock<IStudentService> _studentServiceMock;
        private readonly StudentsController _studentsController;

        public StudentControllerTest()
        {
            _studentServiceMock = new Mock<IStudentService>();
            _studentsController = new StudentsController(_studentServiceMock.Object);
        }

        [Fact]
        public void Get_AbsenCount_ReturnOkResult()
        {
            //Arrange
            string studentNumber = "A10000";
            int expectedValue = 78;

            // _studentServiceMock.Setup(x => x.GetAbsentCount(It.IsAny<string>())).Returns(expectedValue);
            _studentServiceMock.Setup(x => x.GetAbsentCount(studentNumber)).Returns(expectedValue);
            var actionResult = _studentsController.Get(studentNumber);

            Assert.IsType<OkObjectResult>(actionResult);

        }
        [Fact]
        public async Task GetAll_ReturnsAViewResult_WithAListOfStudents()
        {
            var models = new List<Student>();

            _studentServiceMock.Setup(x => x.GetStudents()).Returns(models);

            var result = _studentsController.GetAll();
            Assert.IsType<OkObjectResult>(result);
            //Assert.Equal(3, models.Count());

        }
    }
}
