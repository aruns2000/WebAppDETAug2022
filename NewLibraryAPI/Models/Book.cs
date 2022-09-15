using System.ComponentModel.DataAnnotations;



namespace NewLibraryAPI.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
    }
}
