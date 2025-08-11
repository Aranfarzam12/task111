using System.ComponentModel.DataAnnotations;

namespace task1.models
{
    public class Users
    {
        public int Id { get; set; }

        [MaxLength(10)]
        public string Name { get; set; }
        [Required(ErrorMessage ="you should enter an email!")]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public List<ToDo> ToDos { get; set; }
    }
}
