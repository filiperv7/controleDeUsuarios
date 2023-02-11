using ControleDeUsuario02.ConsoleAPI.Controllers;
using ControleDeUsuario02.ConsoleAPI.Model;

namespace ControleDeUsuario02.ConsoleAPI.Views {
    public class ProjectView {

        public static void GetAllProjects() {
            Console.Write("\n Buscando todos os Projetos... \n");

            var allProjects = ProjectController.GetAll();

            // ---  Print  ---
            if (allProjects.Count() != 0) {
                Console.Write(" Esses são todos os Projetos cadastrados em nossa base: \n\n");
                foreach (var project in allProjects) {
                    Console.Write($"\t Id: \t\t{project.Id}\n");
                    Console.Write($"\t Nome: \t\t{project.Name}\n");
                    Console.Write($"\t Descrição: \t{project.Description}\n\n");
                }
            } else {
                Console.Write(" Nenhum Projeto encontrado na Base de Dados! \n\n");
            }
        }

        public static void GetProjectById() {
            Console.Write("\n Digite o Id do Projeto: \n > ");
            int id = int.Parse(Console.ReadLine());

            Console.Write($"\n Buscando Projeto de ID {id}... \n\n");

            var requestedProject = ProjectController.GetById(id);

            // ---  Print  ---
            if (requestedProject != null) {
                Console.Write($"\t Id: \t\t{requestedProject.Id}\n");
                Console.Write($"\t Nome: \t\t{requestedProject.Name}\n");
                Console.Write($"\t Descrição: \t{requestedProject.Description} \n\n");
            } else {
                Console.Write($" Projeto de ID {id} não encontrado! \n\n");
            }
        }

        public static void GetProjectByName() {
            Console.Write("\n Digite o nome do Projeto: \n > ");
            string name = Console.ReadLine();

            Console.Write("\n Buscando... \n\n");

            var requestedProjects = ProjectController.GetByName(name);

            // ---  Print  ---
            if (requestedProjects.Count() != 0) {
                foreach (var project in requestedProjects) {
                    Console.Write($"\t Id: \t\t{project.Id}\n");
                    Console.Write($"\t Nome: \t\t{project.Name}\n");
                    Console.Write($"\t Descrição: \t{project.Description}\n\n");
                }
            } else {
                Console.Write(" Projeto não encontrado! \n\n");
            }
        }

        public static void CreateProject() {
            Console.Write("\n Digite o nome do Projeto: \n > ");
            string name = Console.ReadLine();
            Console.Write("\n Digite a descrição do Projeto: \n > ");
            string description = Console.ReadLine();

            var project = new ProjectModel { Name = name, Description = description };

            Console.Write("\n Creando... \n\n");

            var createdProject = ProjectController.PostOne(project);


            // ---  Print  ---
            Console.Write($"\t Id: \t\t{createdProject.Id}\n");
            Console.Write($"\t Nome: \t\t{createdProject.Name}\n");
            Console.Write($"\t Descrição: \t{createdProject.Description}\n\n");
        }

        public static void UpdateProject() {
            Console.Write("\n Digite o nome do Projeto: \n > ");
            string name = Console.ReadLine();
            Console.Write("\n Digite a descrição do Projeto: \n > ");
            string description = Console.ReadLine();
            Console.Write("\n Digite o id do Projeto: \n > ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("\n Atualizando... \n\n");

            var updatedProject = ProjectController.PutOne(id, name, description);

            // ---  Print  ---
            Console.Write($"\t Id: \t\t{updatedProject.Id}\n");
            Console.Write($"\t Nome: \t\t{updatedProject.Name}\n");
            Console.Write($"\t Descrição: \t{updatedProject.Description}\n\n");
        }

    }
}
