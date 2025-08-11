using System.ComponentModel.DataAnnotations;


namespace task1.models
{
    public class ToDo
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="enter a title  please !")]
        public string Title { get; set; }

        public string Description { get; set; }

        public bool IsCompleted { get; set; } = false;

        public int UserId { get; set; }
        public Users user { get; set; }

        public int CategoryId { get; set; }
        public Categories category { get; set; }
    }
}
