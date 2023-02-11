using ControleDeUsuario02.Domain.Model;

namespace ControleDeUsuario02.Domain.IRepository {
    public interface IRepositoryProject {

        Project Create(Project project);

        IEnumerable<Project> GetAll();

        Project GetById(int id);

        List<Project> GetByName(string name);

        Project Update(Project project);

        void Delete(Project project);
    }
}
