using DemoApp.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApp.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet("{number}")]
        public  IActionResult Get(string number)
        {
            var result =  _studentService.GetAbsentCount(number);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = _studentService.GetStudents();
            return Ok(result);
        }
        //[HttpGet]
        //public async Task<IActionResult> Get()
        //{
        //    var result = await _customerService.GetAllAsync();
        //    return Ok(result);
        //}
        //[HttpPost]
        //public async Task<IActionResult> Post(CustomerDto dto)
        //{
        //    var res = await _customerService.AddAsync(dto);
        //    return Ok(res);
        //}
        //[HttpPut]
        //public async Task<IActionResult> Update(Guid id, CustomerDto dto)
        //{
        //    var res = await _customerService.UpdateAsync(id, dto);
        //    return Ok(res);
        //}
        //[HttpDelete]
        //public async Task<IActionResult> Remove(Guid id)
        //{
        //    var res = await _customerService.RemoveAsync(id);
        //    return Ok(res);
        //}
    }
}
