using ControleDeUsuario02.Domain.Model;

namespace ControleDeUsuario02.API.Model.Resource {
    public class UserFullResource {

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public ProjectResource? Project { get; set; }
        public List<DepartmentResource>? Departments { get; set; }


        public static UserFullResource DomainToResource(User user) {
            return new UserFullResource {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Project = ProjectResource.DomainToResource(user.Project),
                Departments = user.Departments.Select(d => DepartmentResource.DomainToResource(d)).ToList()
            };
        }

        public User ResourceToDomain() {
            return new User {
                Id = Id,
                FirstName = FirstName,
                LastName = LastName,
                Project = Project.ResourceToDomain(),
                Departments = DepartmentResource.ConvertListResourceToListDomain(Departments)
            };
        }

        public static List<UserFullResource> ConvertListDomainToListResource(List<User> userList) {
            var users = new List<UserFullResource>();

            foreach (var user in userList) {
                users.Add(DomainToResource(user));
            }

            return users;
        }
    }
}
