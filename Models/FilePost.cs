using System.ComponentModel.DataAnnotations;

namespace DesafioDotNET.Models
{
    public class FilePost
    {
        public string? Status { get; set; }
        public string? Message { get; set; }
        public int? Count { get; set; }

        [Required]
        public List<Ticket> Data { get; set; }
    }
}
