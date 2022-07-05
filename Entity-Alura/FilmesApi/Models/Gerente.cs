using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace FilmesAPI.Models
{
    public class Gerente
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public virtual List<Cinema> Cinemas { get; set; }
    }
}