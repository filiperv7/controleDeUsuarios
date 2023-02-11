using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ControleDeUsuario02.Domain.Model {
    public class Project {

        public Project() {
            Users = new List<User>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string? Name { get; set; }

        [Required]
        [StringLength(200)]
        public string? Description { get; set; }

        [JsonIgnore]
        public virtual List<User>? Users { get; set; }
    }
}
