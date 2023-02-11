using ControleDeUsuario02.ConsoleAPI.Controllers;
using ControleDeUsuario02.ConsoleAPI.Model;

namespace ControleDeUsuario02.ConsoleAPI.Views {
    public class DepartmentView {

        public static void GetAllDepartments()  {
            Console.Write("\n Buscando todos os Departamentos... \n");

            var allDepartment = DepartmentController.GetAll();

            // ---  Print  ---
            if (allDepartment.Count() != 0) {
                Console.Write(" Esses são todos os Departamentos cadastrados em nossa base: \n\n");
                foreach (var project in allDepartment) {
                    Console.Write($"\t Id: \t\t{project.Id}\n");
                    Console.Write($"\t Nome: \t\t{project.Name}\n");
                    Console.Write($"\t Descrição: \t{project.Description}\n\n");
                }
            } else {
                Console.Write(" Nenhum Departamento encontrado na Base de Dados! \n\n");
            }
        }

        public static void GetDepartmentById()  {
            Console.Write("\n Digite o Id do Departamento: \n > ");
            int id = int.Parse(Console.ReadLine());

            Console.Write($"\n Buscando Departamento de Id {id}... \n\n");

            var requestedDepartment = DepartmentController.GetById(id);

            // ---  Print  ---
            if (requestedDepartment != null) {
                Console.Write($"\t Id: \t\t{requestedDepartment.Id}\n");
                Console.Write($"\t Nome: \t\t{requestedDepartment.Name}\n");
                Console.Write($"\t Descrição: \t{requestedDepartment.Description}\n\n");
            } else {
                Console.Write($" Departaemnto de ID {id} não encontrado! \n\n");
            }
        }

        public static void GetDepartmentByName() {
            Console.Write("\n Digite o nome do Department: \n > ");
            string name = Console.ReadLine();

            Console.Write("\n Buscando... \n\n");

            var requestedDepartment = DepartmentController.GetByName(name);

            // ---  Print  ---
            if (requestedDepartment.Count() != 0) {
                foreach (var department in requestedDepartment) {
                    Console.Write($"\t Id: \t\t{department.Id}\n");
                    Console.Write($"\t Nome: \t\t{department.Name}\n");
                    Console.Write($"\t Descrição: \t{department.Description}\n\n");
                }
            } else {
                Console.Write(" Departamento não encontrado! \n\n");
            }
        }

        public static void CreateDepartment()  {
            Console.Write("\n Digite o nome do Departamento: \n > ");
            string name = Console.ReadLine();
            Console.Write("\n Digite a descrição do Departamento: \n > ");
            string description = Console.ReadLine();

            var department = new DepartmentModel { Name = name, Description = description };

            Console.Write("\n Criando... \n\n");

            var createdDepartment = DepartmentController.PostOne(department);

            // ---  Print  ---
            Console.Write($"\t Id: \t\t{createdDepartment.Id}\n");
            Console.Write($"\t Nome: \t\t{createdDepartment.Name}\n");
            Console.Write($"\t Descrição: \t{createdDepartment.Description}\n\n");
        }

        public static void UpdateDepartment() {
            Console.Write("\n Digite o nome do Departamento: \n > ");
            string name = Console.ReadLine();
            Console.Write("\n Digite a descrição do Departamento: \n > ");
            string description = Console.ReadLine();
            Console.Write("\n Digite o id do Departamento: \n > ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("\n Atualizando... \n\n");

            var updatedDepartment = DepartmentController.PutOne(id, name, description);

            // ---  Print  ---
            Console.Write($"\t Id: \t\t{updatedDepartment.Id}\n");
            Console.Write($"\t Nome: \t\t{updatedDepartment.Name}\n");
            Console.Write($"\t Descrição: \t{updatedDepartment.Description}\n\n");
        }

    }
}
