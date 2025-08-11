using System.ComponentModel.DataAnnotations;

namespace task1.models
{
    public class Categories
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="you should Enter a name")]
        public string Name { get; set; }

        public List<ToDo> Todos { get; set; }

    }
}
