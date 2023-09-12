using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace DesafioDotNET.Models
{
    public class Ticket
    {
        [Required]
        [JsonPropertyName("id")]
        public int IdTicket { get; set; }


        [Required]
        [JsonPropertyName("created_at")]
        public long FechaCreacion { get; set; }


        [Required]
        [JsonPropertyName("user_id")]
        public int IdUsuario { get; set; }


        [Required]
        [JsonPropertyName("status_id")]
        public int Estado { get; set; }

        public DateTime FechaCreacionDateTime {
            get {
                return DateTimeOffset.FromUnixTimeSeconds(FechaCreacion).UtcDateTime;
            }
        } 
    }
}
