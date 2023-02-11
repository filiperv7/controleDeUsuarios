using ControleDeUsuario02.ConsoleAPI.Views;

public class ProgramAPI {
    static void Main(string[] args) {

        Console.Write("\n\t\t========================  Bem Vindo ao Console de Controle de Usuário  ========================  ");

        int choice;
        do {
            Console.Write("\n\n Digite o número correspondente à função que você deseja acessar. \n");
            Console.Write(" 1 - Acessar Usuário(s)");
            Console.Write("\t\t 2 - Criar/Atualizar Usuário");
            Console.Write("\n 3 - Acessar Projeto(s)");
            Console.Write("\t\t 4 - Criar/Atualizar Projeto");
            Console.Write("\n 5 - Acessar Departamento(s)");
            Console.Write("\t 6 - Criar/Atualizar Departamento \n");
            Console.Write(" 7 - SAIR DO PROGRAMA. \n > ");
            choice = int.Parse(Console.ReadLine());

            int choiceTwo;
            string text;

            switch (choice) {
                //      ===================================  USER  ===================================      \\
                case 1:
                    text = "\n Ok, escolha qual tipo de consulta dejesa fazer.";
                    do {
                        Console.Write($"{text} \n");
                        Console.Write(" 1 - Acessar todos os Usuários");
                        Console.Write("\t\t 2 - Acessar um Usuário por ID \n");
                        Console.Write(" 3 - Acessar um Usuário completo por ID");
                        Console.Write("\t 4 - Acessar um Usuário por Nome \n");
                        Console.Write(" 5 - Voltar ao Menu anterior \n > ");
                        choiceTwo = int.Parse(Console.ReadLine());

                        switch (choiceTwo) {
                            case 1:
                                UserView.GetAllUsers();
                                break;
                            case 2:
                                UserView.GetUserById();
                                break;
                            case 3:
                                UserView.GetUserCompleteById();
                                break;
                            case 4:
                                UserView.GetUserByName();
                                break;
                            case 5:
                                break;
                            default:
                                text = "\n OPÇÃO INEXISTENTE! \n\n Escolha qual tipo de consulta dejesa fazer.";
                                break;
                        }
                    } while (choiceTwo != 5);
                    break;
                case 2:
                    text = "\n Você deseja criar um novo ou atualizar um Usuário?";
                    do {
                        Console.Write($"{text} \n");
                        Console.Write(" 1 - Criar novo Usuário \t 2 - Atualizar um Usuário \n");
                        Console.Write(" 3 - Voltar ao Menu anterior \n > ");
                        choiceTwo = int.Parse(Console.ReadLine());

                        switch (choiceTwo) {
                            case 1:
                                UserView.CreateUser();
                                break;
                            case 2:
                                UserView.UpdateUser();
                                break;
                            case 3:
                                break;
                            default:
                                text = "\n OPÇÃO INEXISTENTE! \n\n Escolha somente uma das três opções abaixo.";
                                break;
                        }
                    } while (choiceTwo != 3);
                    break;
                //      ===================================  PROJECT  ===================================      \\
                case 3:
                    text = "\n Ok, escolha qual tipo de consulta dejesa fazer";
                    do {
                        Console.Write($"{text} \n");
                        Console.Write(" 1 - Acessar todos os Projetos");
                        Console.Write("\t\t 2 - Acessar um Projeto por ID \n");
                        Console.Write(" 3 - Acessar um Projeto por Nome");
                        Console.Write("\t 4 - Voltar ao Menu anterior \n > ");
                        choiceTwo = int.Parse(Console.ReadLine());

                        switch (choiceTwo) {
                            case 1:
                                ProjectView.GetAllProjects();
                                break;
                            case 2:
                                ProjectView.GetProjectById();
                                break;
                            case 3:
                                ProjectView.GetProjectByName();
                                break;
                            case 4:
                                break;
                            default:
                                text = "\n OPÇÃO INEXISTENTE! \n\n Escolha somente uma das quatro opções abaixo.";
                                break;
                        }
                    } while (choiceTwo != 4);
                    break;
                case 4:
                    text = "\n Você deseja criar um novo ou atualizar um Projeto?";
                    do {
                        Console.Write($"{text} \n");
                        Console.Write(" 1 - Criar novo Projeto \t 2 - Atualizar um Projeto \n");
                        Console.Write(" 3 - Voltar ao Menu anterior \n > ");
                        choiceTwo = int.Parse(Console.ReadLine());

                        switch (choiceTwo) {
                            case 1:
                                ProjectView.CreateProject();
                                break;
                            case 2:
                                ProjectView.UpdateProject();
                                break;
                            case 3:
                                break;
                            default:
                                text = "\n OPÇÃO INEXISTENTE! \n\n Escolha somente uma das três opções abaixo.";
                                break;
                        }
                    } while (choiceTwo != 3);
                    break;
                //      ===================================  DEPARTMENT  ===================================      \\
                case 5:
                    text = "\n Ok, escolha qual tipo de consulta dejesa fazer";
                    do {
                        Console.Write($"{text} \n");
                        Console.Write(" 1 - Acessar todos os Departamentos");
                        Console.Write("\t\t 2 - Acessar um Departamento por ID \n");
                        Console.Write(" 3 - Acessar um Departamento por Nome");
                        Console.Write("\t\t 4 - Voltar ao Menu anterior \n > ");
                        choiceTwo = int.Parse(Console.ReadLine());

                        switch (choiceTwo) {
                            case 1:
                                DepartmentView.GetAllDepartments();
                                break;
                            case 2:
                                DepartmentView.GetDepartmentById();
                                break;
                            case 3:
                                DepartmentView.GetDepartmentByName();
                                break;
                            case 4:
                                break;
                            default:
                                text = "\n OPÇÃO INEXISTENTE! \n\n Escolha somente uma das quatro opções abaixo.";
                                break;
                        }
                    } while(choiceTwo != 4);
                    break;
                case 6:
                    text = "\n Você deseja criar um novo ou atualizar um Departamento?";
                    do {
                        Console.Write($"{text} \n");
                        Console.Write(" 1 - Criar novo Departamento \t 2 - Atualizar um Departamento \n");
                        Console.Write(" 3 - Voltar ao Menu anterior \n > ");
                        choiceTwo = int.Parse(Console.ReadLine());

                        switch (choiceTwo) {
                            case 1:
                                DepartmentView.CreateDepartment();
                                break;
                            case 2:
                                DepartmentView.UpdateDepartment();
                                break;
                            case 3:
                                break;
                            default:
                                text = "\n OPÇÃO INEXISTENTE! \n\n Escolha somente uma das três opções abaixo.";
                                break;
                        }
                    } while (choiceTwo != 3);
                    break;
                case 7:
                    Console.Write("\n SAINDO...\n\n\n");
                    break;
                default:
                    Console.Write("\n OPÇÃO INEXISTENTE! \n");
                    break;
            }
        } while (choice != 7);
    }
}
