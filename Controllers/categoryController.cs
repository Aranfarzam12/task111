using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using task1.models;

namespace task1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class categoryController : ControllerBase
    {
        private readonly datacontext con;

        public categoryController(datacontext context)
        {
            con = context;
        }


        [HttpPost("creat")]

        public ActionResult Creat(Categories cate)
        {
            con.Categories.Add(cate);
            con.SaveChanges();

            return Ok("Category added successfully");
        }


        [HttpGet("readrecord")]

        public ActionResult Read()
        {
            var data = con.Categories.ToList();
            return Ok(data);
        }

        [HttpPut("update")]

        public ActionResult Update(int id , Categories cate)
        {
            var check = con.Categories.Find(id);

            if (check == null)
            {
                return NotFound("User not found");
            }

            check.Name = cate.Name;
            con.SaveChanges();
            return Ok("Information updated successfully");
        }

        [HttpDelete("delete")]

        public ActionResult Delete(int id)
        {
            var chek = con.Categories.Find(id);

            if (chek == null)
            {
                return NotFound("There is no user with this ID to delete !!");
            }

            con.Categories.Remove(chek);
            con.SaveChanges();
            return Ok("Data deleted successfully");
        }
    }
}
