using ControleDeUsuario02.Domain.Model;

namespace ControleDeUsuario02.Domain.IRepository {
    public interface IRepositoryDepartment {

        IEnumerable<Department> Create(IEnumerable<Department> departments);

        Department CreateOne(Department department);

        IEnumerable<Department> GetAll();

        Department GetById(int id);
        
        List<Department> GetByName(string name);

        Department Update(Department department);

        void Delete(Department department);
    }
}
