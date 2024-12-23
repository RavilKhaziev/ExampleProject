using System.ComponentModel.DataAnnotations;

namespace ExampleProject.Entities
{
    public class PageView
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Url { get; set; } = null!;
        public uint ViewCount { get; set; } = 0;
    }
}
