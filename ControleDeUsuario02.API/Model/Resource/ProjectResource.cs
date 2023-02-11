using ControleDeUsuario02.Domain.Model;

namespace ControleDeUsuario02.API {
    public class ProjectResource {

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public static ProjectResource DomainToResource(Project project) {
            return new ProjectResource() {
               Id = project.Id,
               Name = project.Name,
               Description = project.Description
            };
        }

        public Project ResourceToDomain() {
            var project = new Project();

            project.Id = Id;
            project.Name = Name;
            project.Description = Description;

            return project;
        }

        public static List<ProjectResource> ConvertListDomainToListResource(IEnumerable<Project> projectList) {
            var projects = new List<ProjectResource>();

            foreach (var project in projectList) {
                projects.Add(DomainToResource(project));
            }

            return projects;
        }
    }
}
