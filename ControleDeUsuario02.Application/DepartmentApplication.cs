using ControleDeUsuario02.Domain.Model;
using ControleDeUsuario02.InfraStructure.Persistency.DataContext;
using ControleDeUsuario02.InfraStructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeUsuario02.Application {
    public class DepartmentApplication {

        private readonly Context _dbContext;

        private readonly DepartmentRepository _departmentRepository;

        public DepartmentApplication(Context dbContext, DepartmentRepository departmentRepository) { 
            _dbContext = dbContext;
            _departmentRepository = departmentRepository;
        }

        public List<Department> GetDepartments(List<int> departmentsId) {
            List<Department> departments = new List<Department>();
            foreach (var departmentId in departmentsId) {
                var department = _departmentRepository.GetById(departmentId);
                departments.Add(department);
            }

            return departments;
        }

    }
}
