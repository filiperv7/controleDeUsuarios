using ControleDeUsuario02.Domain.Model;
using ControleDeUsuario02.InfraStructure.Persistency.DataContext;
using ControleDeUsuario02.InfraStructure.Repositories;

namespace ControleDeUsuario02.Application {
    public class UserApplication {

        private readonly Context _dbContext;

        private readonly UserRepository _userRepository;
        private readonly DepartmentRepository _departmentRepository;
        private readonly ProjectRepository _projectRepository;

        public UserApplication(UserRepository userRepository, DepartmentRepository departmentRepository, ProjectRepository projectRepository, Context dbContext) {
            _userRepository = userRepository;
            _departmentRepository = departmentRepository;
            _projectRepository = projectRepository;
            _dbContext = dbContext;
        }

        public User GetUser(int id) {
            var user = _userRepository.GetById(id);
            var project = _projectRepository.GetAll();
            
            return user;
        }

        public static User InsertFull(Project project, List<Department> departments, User user) {

            Context dbContext = new Context();

            UserRepository userRepository = new UserRepository(dbContext);
            DepartmentRepository departmentRepository = new DepartmentRepository(dbContext);
            ProjectRepository projectRepository = new ProjectRepository(dbContext);

            // Lógica para relacionamento entre projeto, departamento e usuário
            user.Project = project;
            user.Departments = departments;

            if (project.Id == 0)
                projectRepository.Create(project);
            else
                projectRepository.Update(project);

            foreach(var department in departments) {
                if (department.Id == 0) 
                    departmentRepository.Create(departments);
                else 
                    departmentRepository.Update(department);
            }

            userRepository.Create(user);

            dbContext.SaveChanges();
            
            return user;
        }


        public void AddUser(User user, List<Department> departments, Project project) {
            user.Project = project;
            user.Departments = departments;

            _userRepository.Create(user);

            _dbContext.SaveChanges();
        }


        public void RemoveUser(User user) {
            _userRepository.Delete(user);

            _dbContext.SaveChanges();
        }
    }
}
