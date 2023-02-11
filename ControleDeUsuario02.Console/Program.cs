using ControleDeUsuario02.Application;
using ControleDeUsuario02.Console.Model;
using ControleDeUsuario02.InfraStructure.Persistency.DataContext;
using ControleDeUsuario02.InfraStructure.Repositories;
using RestSharp;

public class Program {
    static void Main(string[] args) {


        Context dbContext = new Context();

        DepartmentRepository departmentRepository = new DepartmentRepository(dbContext);
        DepartmentApplication departmentApplication = new DepartmentApplication(dbContext, departmentRepository);

        ProjectRepository projectRepository = new ProjectRepository(dbContext);
        ProjectApplication projectApplication = new ProjectApplication(dbContext, projectRepository);

        UserRepository userRepository = new UserRepository(dbContext);
        UserApplication userApplication = new UserApplication(userRepository, departmentRepository, projectRepository, dbContext);

        //========================================================================================================================

        Console.WriteLine("========================  Bem Vindo ao Console de Controle de Usuário  ======================== \n");

        //      ================  Cadastrando Usuário com seu departamento (novo) e projeto (novo)  ================      \\
        void CreateUserFull() {
            //  USUÁRIO
            Console.Write("Digite o primeiro nome do Usuário: \n > ");
            var userFirstName = Console.ReadLine();
            Console.Write("\nDigite o sobrenome do Usuário: \n > ");
            var userLastName = Console.ReadLine();


            //  PROJETO
            Console.Write("\nDigite o nome do Projeto: \n > ");
            var projectName = Console.ReadLine();
            Console.Write("\nDigite a descrição desse Projeto: \n > ");
            var projectDescription = Console.ReadLine();
            var project = new ProjectModel { Name = projectName, Description = projectDescription };


            //  DEPARTAMENTO
            int numDepartment = 1;

            DepartmentModel department;
            string continueRegistration;

            var departmentListModel = new List<DepartmentModel>();

            do {
                Console.Write($"\nDigite o nome do {numDepartment}º Departamento: \n > ");
                var departmentName = Console.ReadLine();
                Console.Write($"\nDigite a Descrição do {numDepartment}º Departamento: \n > ");
                var departmentDescription = Console.ReadLine();

                numDepartment++;

                department = new DepartmentModel { Name = departmentName, Description = departmentDescription };
                departmentListModel.Add(department);

                Console.Write("\nDeseja continuar cadastrando outro Departamento? (S/N) \n > ");
                continueRegistration = Console.ReadLine();
            } while (continueRegistration != "N" && continueRegistration != "n");


            var departmentListDomain = DepartmentModel.ConvertListModelToListDomain(departmentListModel);

            var user = new UserModel { FirstName = userFirstName, LastName = userLastName };

            Console.Write("\nCadastrando... \n\n");

            UserApplication.InsertFull(project.ModelToDomain(), departmentListDomain, user.ModelToDomain());
        }

        //========================================================================================================================



        //      ===================================  Cadastrando apenas Usuário  ===================================      \\
        void CreateUser() {
            Console.WriteLine("Qual o Id do Projeto onde o Usuário será alocado? \n > ");
            int projectId = int.Parse(Console.ReadLine());

            int i = 0;
            int numDepartment = 1;
            string continueRegistration;

            List<int> departmentIds = new List<int>();

            do {
                Console.Write($"Digite o Id do {numDepartment}º Departamento: \n > ");
                int departmentId = int.Parse(Console.ReadLine());


                departmentIds.Add(departmentId);

                i++;
                numDepartment++;

                Console.Write("\nDeseja continuar cadastrando outro Departamento? (S/N) \n > ");
                continueRegistration = Console.ReadLine();
            } while (continueRegistration != "N" && continueRegistration != "n");


            var project = projectApplication.GetProject(projectId);
            var departmentList = departmentApplication.GetDepartments(departmentIds);

            Console.Write("Digite o primeiro nome do Usuário: \n > ");
            var userFirstName = Console.ReadLine();
            Console.Write("Digite o primeiro nome do Usuário: \n > ");
            var userLastName = Console.ReadLine();

            var user = new UserModel { FirstName = userFirstName, LastName = userLastName };

            Console.Write("\nCadastrando... \n\n");

            userApplication.AddUser(user.ModelToDomain(), departmentList, project);
        }

        //========================================================================================================================



        //      ========================================  Deletar usuário  ========================================      \\
        void DeleteUser() {
            Console.Write("Digite o número do Id do Usuário: \n > ");
            int userId = int.Parse(Console.ReadLine());
            Console.WriteLine("Excluindo...");

            var user = userApplication.GetUser(userId);
            userApplication.RemoveUser(user);
            Console.Write($"\nO usuário {user.FirstName} foi EXCLUÍDO! \n");
        }

        //========================================================================================================================



        //      ====================================  Mostrar Usuário por id  ====================================      \\
        void ShowUserById() {
            Console.Write("Digite o Id Usuário que vê quer ver: \n > ");
            int userId = int.Parse(Console.ReadLine());
            Console.WriteLine("\nBuscando... \n");


            var user = userApplication.GetUser(userId);
            var projects = projectRepository.GetAll();


            Console.Write($"O(a) usuário(a) {user.FirstName} {user.LastName}, está no projeto: .");

        }

        //========================================================================================================================



        //      ===========================================   MÉTODOS   ==========================================      \\

        /*CreateUserFull();*/

        /*CreateUser();*/

        /*DeleteUser();*/

        /*ShowUserById();*/


        /*#region 

        #endregion*/

    }

}
