using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using task1.models;

namespace task1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class userController : ControllerBase
    {
        private readonly datacontext con;

        public userController(datacontext context)
        {
            con = context;
        }

        [HttpPost("creat")]

        public ActionResult Creat(Users user)
        {
            con.Users.Add(user);
            con.SaveChanges();

            return Ok("Your account has been successfully created.");
        }


        [HttpGet("readrecords")]

        public ActionResult Read()
        {
            var data = con.Users.ToList();
            return Ok(data);
        }


        [HttpPut("update")]

        public ActionResult Update(int id , Users user)
        {
            var check = con.Users.Find(id);

            if (check == null)
            {
                return NotFound("User not found");
            }

            check.Name = user.Name;
            check.Email = user.Email;
            check.Password = user.Password;

            con.SaveChanges();

            return Ok("Information updated successfully");
        }


        [HttpDelete("delete")]

        public ActionResult Delete(int id)
        {
            var check = con.Users.Find(id);

            if (check == null)
            {
                return NotFound("There is no user with this ID to delete !!");
            }

            con.Users.Remove(check);
            con.SaveChanges();
            return Ok("Data deleted successfully");
        }



    }
}
