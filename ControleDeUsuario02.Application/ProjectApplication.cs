using ControleDeUsuario02.Domain.Model;
using ControleDeUsuario02.InfraStructure.Persistency.DataContext;
using ControleDeUsuario02.InfraStructure.Repositories;

namespace ControleDeUsuario02.Application {
    public class ProjectApplication {

        private readonly Context _dbContext;

        private readonly ProjectRepository _projectRepository;

        public ProjectApplication(Context dbContext, ProjectRepository projectRepository) {
            _dbContext = dbContext;
            _projectRepository = projectRepository;
        }

        public Project GetProject(int id) {
            var project = _projectRepository.GetById(id);
        
            return project;
        }

        public IEnumerable<Project> GetAllProjects() {
            var projects = _projectRepository.GetAll();

            return projects;
        }

    }
}
