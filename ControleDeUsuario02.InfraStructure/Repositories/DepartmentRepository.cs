using ControleDeUsuario02.Domain.IRepository;
using ControleDeUsuario02.Domain.Model;
using ControleDeUsuario02.InfraStructure.Persistency.DataContext;

namespace ControleDeUsuario02.InfraStructure.Repositories {
    public class DepartmentRepository : IRepositoryDepartment {

        private readonly Context _dbContext;

        public DepartmentRepository(Context dbContext) { 
            _dbContext = dbContext;
        }

        public IEnumerable<Department> Create(IEnumerable<Department> departments) {
            _dbContext.AddRange(departments);

            return departments;

            /*foreach (var department in departments) {
                _dbContext.Add(department);
            }*/
        }

        public Department CreateOne(Department department) {
            _dbContext.Add(department);

            return department;
        }

        public void Delete(Department department) {
            _dbContext.Remove(department);
        }

        public IEnumerable<Department> GetAll() {
            return _dbContext.Departments.ToList();
        }

        public Department GetById(int id) {
            var idDepartment = _dbContext.Departments.Where(d => d.Id == id);

            return idDepartment.FirstOrDefault();
        }

        public List<Department> GetByName(string name) {
            return _dbContext.Departments.Where(u => u.Name.Contains(name)).ToList();
        }

        public Department Update(Department department) {
            _dbContext.Update(department);

            return department;
        }
    }
}
