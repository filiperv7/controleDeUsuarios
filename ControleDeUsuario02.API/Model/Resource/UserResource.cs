using ControleDeUsuario02.Domain.Model;

namespace ControleDeUsuario02.API {
    public class UserResource {

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }


        public static UserResource DomainToResource(User user) {
            return new UserResource() {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName
            };
        }

        public User ResourceToDomain() {
            var user = new User();

            user.Id = Id;
            user.FirstName = FirstName;
            user.LastName = LastName;

            return user;
        }

        public static List<User> ConvertListResourceToListDomain(List<UserResource> userList) {
            var users = new List<User>();

            foreach (var user in userList) {
                users.Add(user.ResourceToDomain());
            }

            return users;
        }

        public static List<UserResource> ConvertListDomainToListResource(List<User> userList) {
            var users = new List<UserResource>();

            foreach (var user in userList) {
                users.Add(DomainToResource(user));
            }

            return users;
        }

    }
}
