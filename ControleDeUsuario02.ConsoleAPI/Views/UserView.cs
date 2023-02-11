using ControleDeUsuario02.ConsoleAPI.Controllers;
using ControleDeUsuario02.ConsoleAPI.Model;

namespace ControleDeUsuario02.ConsoleAPI.Views {
    public class UserView {
        
        public static void GetAllUsers() {
            var allUsers = UserController.GetAll();

            Console.Write("\n Buscando todos os Usuários... \n");

            // ---  Print  ---
            if (allUsers.Count() != 0) {
                Console.Write(" Esses são todos os usuários cadastrados em nossa base: \n\n");
                foreach (var user in allUsers) {
                    Console.Write($"\t Id: \t  {user.Id} \n");
                    Console.Write($"\t Nome: \t  {user.FirstName} {user.LastName} \n\n");
                }
            } else {
                Console.Write(" Nenhum Usuário encontrado na Base de Dados! \n\n");
            }
        }

        public static void GetUserById() {
            Console.Write("\n Digite o Id do Usuário: \n > ");
            int id = int.Parse(Console.ReadLine());

            Console.Write($"\n Buscando Usuário de ID {id}... \n\n");

            var requestedUser = UserController.GetById(id);

            // ---  Print  ---
            if (requestedUser != null) {
                Console.Write($"\t Id: \t{requestedUser.Id} \n");
                Console.Write($"\t Nome: \t{requestedUser.FirstName} {requestedUser.LastName} \n\n");
            } else {
                Console.Write($" Usuário de ID {id} não encontrado! \n\n");
            }
        }

        public static void GetUserCompleteById() {
            Console.Write("\n Digite o Id do Usuário: \n > ");
            int id = int.Parse(Console.ReadLine());

            Console.Write($"\n Buscando usuário completo de ID {id}... \n\n");

            var fullUser = UserController.GetUserCompleteById(id);

            // ---  Print  ---
            if (fullUser != null) {
                Console.Write($"\t Id: \t\t{fullUser.Id}");
                Console.Write($"\n\t Nome: \t\t{fullUser.FirstName} {fullUser.LastName}");

                Console.Write($"\n\n\t Do Projeto: \t{fullUser.Project.Name} com ID {fullUser.Project.Id}\n");
                Console.Write($"\t Descrição: \t{fullUser.Project.Description}");

                int index = 1;
                Console.Write($"\n\n\t Faz parte do(s) Departamento(s):\n");
                foreach (var department in fullUser.Departments) {
                    Console.Write($"\t {index} - Depatamento: {department.Name} de ID {department.Id} \n");
                    Console.Write($"\t     Descrição: {department.Description} \n");
                    index++;
                }
            } else {
                Console.Write($" Usuário de ID {id} não encontrado! \n\n");
            }
        }

        public static void GetUserByName() {
            Console.Write("\n Digite o Nome do Usuário: \n > ");
            string name = Console.ReadLine();

            Console.Write("\n Buscando... \n\n");

            var requestedUsers = UserController.GetByName(name);


            // ---  Print  ---
            if (requestedUsers.Count() != 0) {
                foreach (var user in requestedUsers) {
                    Console.Write($"\t Id: \t\t{user.Id}");
                    Console.Write($"\n\t Nome: \t\t{user.FirstName} {user.LastName} \n\n");
                }
            } else {
                Console.Write(" Usuário não encontrado! \n\n");
            }
        }

        public static void CreateUser() {
            //  USUÁRIO
            Console.Write("\n Digite o primeiro nome do Usuário: \n > ");
            string firstName = Console.ReadLine();
            Console.Write("\n Digite o sobrenome do Usuário: \n > ");
            string lastName = Console.ReadLine();

            ProjectModel project = new ProjectModel();
            DepartmentModel department;
            var departmentListResource = new List<DepartmentModel>();
            int newOrOld;

            var text = "\n Deseja criar um novo Projeto e Novos Departamentos ou usar já existentes:";
            do {
                // PROJETO E DEPARTAMENTO
                Console.Write($"{text} \n");
                Console.Write($"  Novo: 0 \n");
                Console.Write($"  Existente: 1 \n > ");
                newOrOld = int.Parse(Console.ReadLine());

                int numDepartment = 1;
                string continueRegistration;

                switch (newOrOld) {
                    // NOVO
                    case 0:
                        //  PROJETO
                        Console.Write("\n Digite o nome do Projeto: \n > ");
                        var projectName = Console.ReadLine();
                        Console.Write("\n Digite a descrição desse Projeto: \n > ");
                        var projectDescription = Console.ReadLine();

                        project = new ProjectModel { Name = projectName, Description = projectDescription };

                        //  DEPARTAMENTO
                        do {
                            Console.Write($"\n Digite o nome do {numDepartment}º Departamento: \n > ");
                            var departmentName = Console.ReadLine();
                            Console.Write($"\n Digite a Descrição do {numDepartment}º Departamento: \n > ");
                            var departmentDescription = Console.ReadLine();

                            numDepartment++;

                            department = new DepartmentModel { Name = departmentName, Description = departmentDescription };
                            departmentListResource.Add(department);

                            Console.Write("\n Deseja continuar cadastrando outro Departamento? (S/N) \n > ");
                            continueRegistration = Console.ReadLine();
                        } while (continueRegistration != "N" && continueRegistration != "n");
                        break;
                    // EXISTENTE
                    case 1:
                        //  PROJETO
                        text = "Digite o Id do Projeto:";
                        do {
                            Console.Write($"\n {text} \n > ");
                            int idProject = int.Parse(Console.ReadLine());

                            project = ProjectController.GetById(idProject);

                            if (project is null) {
                                text = $"O ID {idProject} não existe. Por favor, digite outro:";
                            }
                        } while (project is null);

                        // DEPARTMENT
                        do {
                            text = "Digite o Id do Departamento:";
                            do {
                                Console.Write($"\n {text} \n > ");
                                int idDepartment = int.Parse(Console.ReadLine());

                                numDepartment++;

                                department = DepartmentController.GetById(idDepartment);
                                if (department is null) {
                                    text = $"O ID {idDepartment} não existe. Por favor, digite outro:";
                                } else {
                                    departmentListResource.Add(department);
                                }
                            } while (department is null);

                            Console.Write("\n Deseja continuar cadastrando outro Departamento? (S/N) \n > ");
                            continueRegistration = Console.ReadLine();
                        } while (continueRegistration != "N" && continueRegistration != "n");
                        break;
                    default:
                        text = "\n OPÇÃO INEXISTENTE! \n\n Deseja criar um novo Projeto e novos Departamentos ou usar já existentes:";
                        break;
                }
            } while (newOrOld != 0 && newOrOld != 1);

            var user = new FullUserModel { FirstName = firstName, LastName = lastName, Project = project, Departments = departmentListResource };

            Console.Write("\n Cadastrando... \n");

            var fullUser = UserController.InsertFull(user);


            // ---  Print  ---
            Console.Write($"\t Id: \t\t{fullUser.Id}");
            Console.Write($"\n\t Nome: \t\t{fullUser.FirstName} {fullUser.LastName}");

            Console.Write($"\n\n\t Do Projeto: \t{fullUser.Project.Name} com ID {fullUser.Project.Id}\n");
            Console.Write($"\t Descrição: \t{fullUser.Project.Description}");

            int index = 1;
            Console.Write($"\n\n\t Faz parte do(s) Departamento(s):\n");
            foreach (var departmentUser in fullUser.Departments) {
                Console.Write($"\t {index} - Depatamento: {departmentUser.Name} de ID {departmentUser.Id} \n");
                Console.Write($"\t     Descrição: {departmentUser.Description} \n");
                index++;
            }

        }

        public static void UpdateUser() {
            // USUÁRIO
            Console.Write("\n Digite o primeiro nome do Usuário: \n > ");
            string firstName = Console.ReadLine();
            Console.Write("\n Digite o sobrenome do Usuário: \n > ");
            string lastName = Console.ReadLine();
            Console.Write("\n Digite o id do Usuário: \n > ");
            int id = int.Parse(Console.ReadLine());


            // PROJETO E DEPARTAMENTO
            Console.Write($"\n Deseja criar novo Projeto e Novos Departamentos ou usar já existentes:\n");
            Console.Write($"  Novo: 0 \n");
            Console.Write($"  Existente: 1 \n > ");
            int newOrOld = int.Parse(Console.ReadLine());

            ProjectModel project = new ProjectModel();
            DepartmentModel department;
            var departmentListResource = new List<DepartmentModel>();

            int numDepartment = 1;
            string continueRegistration;

            switch (newOrOld) {
                // NOVO
                case 0:
                    //  PROJETO
                    Console.Write("\n Digite o nome do Projeto: \n > ");
                    var projectName = Console.ReadLine();
                    Console.Write("\n Digite a descrição desse Projeto: \n > ");
                    var projectDescription = Console.ReadLine();

                    project = new ProjectModel { Name = projectName, Description = projectDescription };

                    //  DEPARTAMENTO
                    do {
                        Console.Write($"\n Digite o nome do {numDepartment}º Departamento: \n > ");
                        var departmentName = Console.ReadLine();
                        Console.Write($"\n Digite a Descrição do {numDepartment}º Departamento: \n > ");
                        var departmentDescription = Console.ReadLine();

                        numDepartment++;

                        department = new DepartmentModel { Name = departmentName, Description = departmentDescription };
                        departmentListResource.Add(department);

                        Console.Write("\n Deseja continuar cadastrando outro Departamento? (S/N) \n > ");
                        continueRegistration = Console.ReadLine();
                    } while (continueRegistration != "N" && continueRegistration != "n");
                    break;
                // EXISTENTE
                case 1:
                    //  PROJETO
                    var text = "Digite o Id do Projeto:";
                    do {
                        Console.Write($"\n {text} \n > ");
                        int idProject = int.Parse(Console.ReadLine());

                        project = ProjectController.GetById(idProject);

                        if (project == null) {
                            text = $"O ID {idProject} não existe. Por favor, digite outro:";
                        }
                    } while (project == null);

                    // DEPARTMENT
                    do {
                        text = "Digite o Id do Departamento:";
                        do {
                            Console.Write($"\n {text} \n > ");
                            int idDepartment = int.Parse(Console.ReadLine());

                            numDepartment++;

                            department = DepartmentController.GetById(idDepartment);
                            if (department == null) {
                                text = $"O ID {idDepartment} não existe. Por favor, digite outro:";
                            } else {
                                departmentListResource.Add(department);
                            }
                        } while (department == null);

                        Console.Write("\n Deseja continuar cadastrando outro Departamento? (S/N) \n > ");
                        continueRegistration = Console.ReadLine();
                    } while (continueRegistration != "N" && continueRegistration != "n");
                    break;
            }

            Console.Write("\n Atualizando... \n\n");

            var updatedUser = UserController.PutOne(id, firstName, lastName, project, departmentListResource);


            // ---  Print  ---
            Console.Write($"\t Id: \t\t{updatedUser.Id}");
            Console.Write($"\n\t Nome: \t\t{updatedUser.FirstName} {updatedUser.LastName}");

            Console.Write($"\n\n\t Do Projeto: \t{updatedUser.Project.Name} com ID {updatedUser.Project.Id}\n");
            Console.Write($"\t Descrição: \t{updatedUser.Project.Description}");

            int index = 1;
            Console.Write($"\n\n\t Faz parte do(s) Departamento(s):\n");
            foreach (var departmentUser in updatedUser.Departments) {
                Console.Write($"\t {index} - Depatamento: {departmentUser.Name} de ID {departmentUser.Id} \n");
                Console.Write($"\t     Descrição: {departmentUser.Description} \n");
                index++;
            }

        }

    }
}
