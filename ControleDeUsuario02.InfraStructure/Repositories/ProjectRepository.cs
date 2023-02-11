using ControleDeUsuario02.Domain.IRepository;
using ControleDeUsuario02.Domain.Model;
using ControleDeUsuario02.InfraStructure.Persistency.DataContext;

namespace ControleDeUsuario02.InfraStructure.Repositories {
    public class ProjectRepository : IRepositoryProject {

        private readonly Context _dbContext;

        public ProjectRepository(Context dbContext) { 
            _dbContext = dbContext;
        }

        public Project Create(Project project) {
            _dbContext.Add(project);

            return project;
        }

        public void Delete(Project project) {
            _dbContext.Remove(project);
        }

        public IEnumerable<Project> GetAll() {
            return _dbContext.Projects.ToList();
        }

        public Project GetById(int id) {
            var idProject = _dbContext.Projects.Where(p => p.Id == id);

            return idProject.FirstOrDefault();
        }

        public List<Project> GetByName(string name) {
            return _dbContext.Projects.Where(u => u.Name.Contains(name)).ToList();
        }

        public Project Update(Project project) {
            _dbContext.Update(project);

            return project;
        }
    }
}
