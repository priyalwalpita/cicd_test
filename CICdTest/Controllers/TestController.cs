using System.Threading.Tasks;
using CICdTest.Interfaces;
using CICdTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace CICdTest.Controllers
{
    [Route("api/test")]
    public class TestController : Controller
    {
        private readonly IStudentBl _studentBl;

        public TestController(IStudentBl studentBl)
        {
            _studentBl = studentBl;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            return Ok(_studentBl.GetStudents());
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Student student)
        {
            return Accepted();
        }
    }
}