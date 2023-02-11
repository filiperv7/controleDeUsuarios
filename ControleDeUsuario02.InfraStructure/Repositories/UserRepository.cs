using ControleDeUsuario02.Domain.IRepository;
using ControleDeUsuario02.Domain.Model;
using ControleDeUsuario02.InfraStructure.Persistency.DataContext;
using Microsoft.EntityFrameworkCore;

namespace ControleDeUsuario02.InfraStructure.Repositories {
    public class UserRepository : IRepositoryUser {

        private readonly Context _dbContext;

        public UserRepository(Context dbContext) {
            _dbContext = dbContext;
        }

        public void Create(User user) {
            _dbContext.Add(user);
        }

        public void Delete(User user) {
            _dbContext.Remove(user);
        }

        public List<User> GetAll() {
            return _dbContext.Users.ToList();
        }

        public User GetAllCompleteById(int id) {
            return _dbContext.Users.Where(u => u.Id == id).SingleOrDefault();
        }

        public User GetById(int id) {
            return _dbContext.Users.Where(u => u.Id == id).SingleOrDefault();
        }

        public List<User> GetByName(string name) {
            return _dbContext.Users.Where(u => u.FirstName.Contains(name)).ToList();
        }

        public User Update(User user) {
            _dbContext.Update(user);

            return user;
        }
    }
}
