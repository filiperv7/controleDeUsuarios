namespace ControleDeUsuario02.ConsoleAPI.Model {
    public class DepartmentModel {

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }

       /* public void DomainToModel(Department department) {
            Name = department.Name;
            Description = department.Description;
        }

        public Department ModelToDomain() {
            return new Department { Name = Name, Description = Description };
        }

        // Método que receba a lista do DepartmentModel e converta para uma lista de Department
        public static List<Department> ConvertListModelToListDomain(List<DepartmentModel> departmentList) {
            var departments = new List<Department>();

            foreach (var department in departmentList) {
                departments.Add(department.ModelToDomain());
            }

            return departments;


            *//*return departmentList.Select(model => model.ModelToDomain()).ToList();*//*
        }*/

    }
}
