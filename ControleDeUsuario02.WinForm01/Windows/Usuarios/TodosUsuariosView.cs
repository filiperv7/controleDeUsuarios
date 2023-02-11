using ControleDeUsuario02.WinForm01.Controllers;

namespace ControleDeUsuario02.WinForm01.Windows.Usuarios {
    public partial class TodosUsuariosView : Form {
        public TodosUsuariosView() {
            InitializeComponent();
        }

        private void TodosUsuariosView_Load(object sender, EventArgs e) {
            var users = UserController.GetAllComplete();

            if (users != null) {
                if (users.Count != 0) {
                    int controlador = 0;
                    foreach (var user in users) {
                        int controle = user.Id + controlador;
                        treeView_todosUsuarios.Nodes.Add(string.Format(Retornos.IdENomeUsuario, user.Id, user.FirstName, user.LastName));
                        treeView_todosUsuarios.Nodes[controle - user.Id].Nodes.Add(string.Format(Retornos.IdENomeProjeto, user.Project.Id, user.Project.Name))
                                                                        .Nodes.Add(string.Format(Retornos.DescricaoProjeto, user.Project.Description));

                        foreach (var departamento in user.Departments) {
                            treeView_todosUsuarios.Nodes[controle - user.Id].Nodes.Add(string.Format(Retornos.IdENomeDepartamento, departamento.Id, departamento.Name))
                                                                            .Nodes.Add(string.Format(Retornos.DescricaoDepartamento, departamento.Description));
                        }

                        controlador++;
                    }
                } else {
                    MessageBox.Show(string.Format(Retornos.NenhumUsuarioEncontrado), string.Format(Retornos.Erro), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                MessageBox.Show(string.Format(Retornos.ErroDeAcessoAoBD), string.Format(Retornos.Erro), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_refresh_Click(object sender, EventArgs e) {
            treeView_todosUsuarios.Nodes.Clear();
            TodosUsuariosView_Load(sender, e);
        }
    }
}
