using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BlazorQuickGridApp.Shared;

namespace BlazorQuickGridApp.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        public static List<School> schools = new List<School> { 
            new School {id =1, name = "Central collage"},
            new School{id = 2, name="uva"}
        };
        public static List<Teacher> teachers = new List<Teacher> {
            new Teacher
            {
               id = 1,
               Name= "Gayara",
               Address ="Badulla",
               TelNo = 1234567,
               School=schools[0]


            },
             new Teacher
            {
               id = 2,
               Name= "dinali",
               Address ="Bandarawela",
               TelNo = 1238967,
               School=schools[1]
             },

        };

        [HttpGet]
        public async Task<ActionResult<List<Teacher>>> GetTeachers()
        {
            return Ok(teachers);
        }
        [HttpGet("id")]

        public async Task<ActionResult<List<Teacher>>> GetOneTeachers(int Id)
        {
            var tech = teachers.FirstOrDefault(h => h.id == Id);
            if(tech == null)
            {
                return NotFound("Sorry, no data here");
            }

            return Ok(teachers);
        }
    }
}
