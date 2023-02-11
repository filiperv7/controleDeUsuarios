using ControleDeUsuario02.Domain.Model;

namespace ControleDeUsuario02.Domain.IRepository {
    public interface IRepositoryUser {

        void Create(User user);

        List<User> GetAll();

        User GetAllCompleteById(int id);

        User GetById(int id);

        List<User> GetByName(string name);

        User Update(User user);

        void Delete(User user);
    }
}
