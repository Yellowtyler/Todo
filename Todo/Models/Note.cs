using System.ComponentModel.DataAnnotations;

namespace Todo.Models
{
    public class Note
    {
        [Key]
        public int id { get; set; }
        public string? content { get; set; }
        public DateTime createdAt { get; set; } = DateTime.Now;
    }
}
