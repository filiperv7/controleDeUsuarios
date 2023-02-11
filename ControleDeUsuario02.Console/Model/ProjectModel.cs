using ControleDeUsuario02.Domain.Model;

namespace ControleDeUsuario02.Console.Model {
    public class ProjectModel {
        public string? Name { get; set; }
        public string? Description { get; set; }

        public Project ModelToDomain() {
            var project = new Project();

            project.Name = Name;
            project.Description = Description;

            return project;
        }



    }
}
