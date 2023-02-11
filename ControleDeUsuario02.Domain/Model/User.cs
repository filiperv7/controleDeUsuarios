using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace ControleDeUsuario02.Domain.Model {
    public class User {

        public int Id { get; set; }

        [Required]
        [StringLength(80)]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(80)]
        public string? LastName { get; set; }

        public virtual Project? Project { get; set; }

        public virtual List<Department>? Departments { get; set; }
    }
}
