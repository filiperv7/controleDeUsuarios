using ControleDeUsuario02.WinForm01.Controllers;

namespace ControleDeUsuario02.WinForm01.Windows.Usuarios {
    public partial class TodosUsuariosCompletosView : Form {
        public TodosUsuariosCompletosView() {
            InitializeComponent();
        }

        private void TodosUsuariosCompletosView_Load(object sender, EventArgs e) {
            CarregandoCardsUsuario();
        }

        private void CarregandoCardsUsuario() {
            var usuarios = UserController.GetAllComplete();
            flowLayoutPanel.Controls.Clear();


            if (usuarios != null) {
                if (usuarios.Count != 0) {
                    CardUsuarioCompleto[] cardUsuarioCompleto = new CardUsuarioCompleto[usuarios.Count];

                    int i = 0;
                    foreach (var usuario in usuarios) {
                        cardUsuarioCompleto[i] = new CardUsuarioCompleto();

                        cardUsuarioCompleto[i].Usuario = string.Format(Retornos.MostarUsuarioCard, usuario.Id, usuario.FirstName, usuario.LastName);
                        cardUsuarioCompleto[i].Projeto = string.Format(Retornos.MostrarProjetoCard, usuario.Project.Name, usuario.Project.Id);
                        cardUsuarioCompleto[i].Departamentos = string.Format(Retornos.MostrarQuantDepartamentosCard, usuario.Departments.Count);

                        cardUsuarioCompleto[i].ProjectModel = usuario.Project;
                        cardUsuarioCompleto[i].DepartmentModels = usuario.Departments;

                        flowLayoutPanel.Controls.Add(cardUsuarioCompleto[i]);
                        i++;
                    }
                } else {
                    DialogResult result = MessageBox.Show(string.Format(Retornos.NenhumUsuarioEncontrado, string.Format(Retornos.TentarNovamente)),
                                                                     string.Format(Retornos.Erro), MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    if (result == DialogResult.Yes) {
                        CarregandoCardsUsuario();
                    } else {
                        this.Close();
                    }
                }
            } else {
                MessageBox.Show(string.Format(Retornos.ErroDeAcessoAoBD), string.Format(Retornos.Erro), MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
