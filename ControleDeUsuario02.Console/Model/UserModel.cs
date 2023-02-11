using ControleDeUsuario02.Domain.Model;

namespace ControleDeUsuario02.Console.Model {
    public class UserModel {

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }


        public void DomainToModel(User user) {
            FirstName = user.FirstName;
            LastName = user.LastName;
        }

        public User ModelToDomain() {
            var user = new User();

            user.FirstName = FirstName;
            user.LastName = LastName;

            return user;
        }
    }
}
