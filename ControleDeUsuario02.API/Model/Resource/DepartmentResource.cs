using ControleDeUsuario02.Domain.Model;

namespace ControleDeUsuario02.API {
    public class DepartmentResource {

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

        public static DepartmentResource DomainToResource(Department department) {
            return new DepartmentResource {
                Id = department.Id,
                Name = department.Name,
                Description = department.Description
            };
        }

        public Department ResourceToDomain() {
            return new Department { Id = Id, Name = Name, Description = Description };
        }

        public static List<Department> ConvertListResourceToListDomain(List<DepartmentResource> departmentList) {
            var departments = new List<Department>();

            foreach (var department in departmentList) {
                departments.Add(department.ResourceToDomain());
            }

            return departments;

            /*return departmentList.Select(model => model.ModelToDomain()).ToList();*/
        }

        public static List<DepartmentResource> ConvertListDomainToListResource(IEnumerable<Department> departmentList) {
            var departments = new List<DepartmentResource>();

            foreach (var department in departmentList) {
                departments.Add(DomainToResource(department));
            }

            return departments;
        }
    }
}
