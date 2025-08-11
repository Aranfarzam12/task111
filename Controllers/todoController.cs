using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using task1.models;

namespace task1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class todoController : ControllerBase
    {
        private readonly datacontext con;

        public todoController(datacontext context)
        {
            con = context;
        }

        [HttpPost("creat")]

        public ActionResult Creat(ToDo todo)
        {
            con.ToDos.Add(todo);
            con.SaveChanges();
            return Ok("data added successfully");
        }

        [HttpGet("readrecord")]
        public ActionResult Read()
        {
            var data = con.ToDos.ToList();
            return Ok(data);
        }

        [HttpPut("update")]

        public ActionResult Update(int id , ToDo todo)
        {
            var check = con.ToDos.Find(id);

            if (check == null)
            {
                return NotFound("User not found");
            }

            check.Title = todo.Title;
            check.Description = todo.Description;
            con.SaveChanges();
            return Ok("Information updated successfully");
        }

        [HttpDelete("delete")]

        public ActionResult Delete(int id)
        {
            var check = con.ToDos.Find(id);

            if (check == null)
            {
                return NotFound("There is no user with this ID to delete !!");
            }

            con.ToDos.Remove(check);
            con.SaveChanges();
            return Ok("Data deleted successfully");
        }



        
    }
}
