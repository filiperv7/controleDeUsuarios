using ControleDeUsuario02.WinForm01.Windows;
using ControleDeUsuario02.WinForm01.Windows.Departamentos;
using ControleDeUsuario02.WinForm01.Windows.Projetos;
using ControleDeUsuario02.WinForm01.Windows.Usuarios;

namespace ControleDeUsuario02.WinForm01 {
    public partial class Inicial : Form {
        public Inicial() {
            InitializeComponent();
        }

        #region USUÁRIO
        private void button_novoUsuario_Click(object sender, EventArgs e) {
            NovoUsuarioView novoUsuario = new NovoUsuarioView();
            novoUsuario.Show();
        }

        private void button_todosUsuarios_Click(object sender, EventArgs e) {
            /*TodosUsuariosView todosUsuarios = new TodosUsuariosView();*/
            TodosUsuariosCompletosView todosUsuarios = new TodosUsuariosCompletosView();
            todosUsuarios.Show();
        }

        private void button_usuarioCompleto_Click(object sender, EventArgs e) {
            UsuarioCompletoView usuarioCompleto = new UsuarioCompletoView();
            usuarioCompleto.Show();
        }

        private void button_atualizarUsuario_Click(object sender, EventArgs e) {
            AtualizarUsuarioView atualizarUsuario = new AtualizarUsuarioView();
            atualizarUsuario.Show();
        }


        /* ============== MENU ============== */
        private void criarUsuárioToolStripMenuItem_Click(object sender, EventArgs e) {
            NovoUsuarioView novoUsuario = new NovoUsuarioView();
            novoUsuario.Show();
        }

        private void todosUsuáriosToolStripMenuItem_Click(object sender, EventArgs e) {
            TodosUsuariosCompletosView todosUsuarios = new TodosUsuariosCompletosView();
            todosUsuarios.Show();
        }

        private void verUsuárioCompletoToolStripMenuItem_Click(object sender, EventArgs e) {
            UsuarioCompletoView usuarioCompleto = new UsuarioCompletoView();
            usuarioCompleto.Show();
        }

        private void atualizarToolStripMenuItem_Click(object sender, EventArgs e) {
            AtualizarUsuarioView atualizarUsuario = new AtualizarUsuarioView();
            atualizarUsuario.Show();
        }

        #endregion

        #region PROJETO
        private void button_novoProjeto_Click(object sender, EventArgs e) {
            NovoProjetoView novoProjeto = new NovoProjetoView();
            novoProjeto.Show();
        }

        private void button_todosProjetos_Click(object sender, EventArgs e) {
            TodosProjetosView todosProjetos = new TodosProjetosView();
            todosProjetos.Show();
        }

        private void button_verProjeto_Click(object sender, EventArgs e) {
            VerProjetoView verProjeto = new VerProjetoView();
            verProjeto.Show();
        }

        private void button_atualizarProjeto_Click(object sender, EventArgs e) {
            AtualizarProjetoView atualizarProjeto = new AtualizarProjetoView();
            atualizarProjeto.Show();
        }


        /* ============== MENU ============== */
        private void criarToolStripMenuItem_Click(object sender, EventArgs e) {
            NovoProjetoView novoProjeto = new NovoProjetoView();
            novoProjeto.Show();
        }

        private void todosProjetosToolStripMenuItem_Click(object sender, EventArgs e) {
            TodosProjetosView todosProjetos = new TodosProjetosView();
            todosProjetos.Show();
        }

        private void buscarProjetoToolStripMenuItem_Click(object sender, EventArgs e) {
            VerProjetoView verProjeto = new VerProjetoView();
            verProjeto.Show();
        }

        private void atualizarToolStripMenuItem1_Click(object sender, EventArgs e) {
            AtualizarProjetoView atualizarProjeto = new AtualizarProjetoView();
            atualizarProjeto.Show();
        }

        #endregion

        #region DEPARTAMENTO
        private void button_novoDepartamento_Click(object sender, EventArgs e) {
            NovoDepartamentoView novoDepartamento = new NovoDepartamentoView();
            novoDepartamento.ShowDialog();
        }

        private void button_todosDepartamentos_Click(object sender, EventArgs e) {
            TodosDepartamentosView todosDepartamentos = new TodosDepartamentosView();
            todosDepartamentos.Show();
        }

        private void button_verDepartamento_Click(object sender, EventArgs e) {
            VerDepartamentoView verDepartamento = new VerDepartamentoView();
            verDepartamento.Show();
        }

        private void button_atualizarDepartamento_Click(object sender, EventArgs e) {
            AtualizarDepartamentoView atualizarDepartamento = new AtualizarDepartamentoView();
            atualizarDepartamento.Show();
        }


        /* ============== MENU ============== */
        private void criarDepartamentoToolStripMenuItem_Click(object sender, EventArgs e) {
            NovoDepartamentoView novoDepartamento = new NovoDepartamentoView();
            novoDepartamento.ShowDialog();
        }

        private void todosDepartamentosToolStripMenuItem_Click(object sender, EventArgs e) {
            TodosDepartamentosView todosDepartamentos = new TodosDepartamentosView();
            todosDepartamentos.Show();
        }

        private void buscarDepartamentoToolStripMenuItem_Click(object sender, EventArgs e) {
            VerDepartamentoView verDepartamento = new VerDepartamentoView();
            verDepartamento.Show();
        }

        private void atualizarToolStripMenuItem2_Click(object sender, EventArgs e) {
            AtualizarDepartamentoView atualizarDepartamento = new AtualizarDepartamentoView();
            atualizarDepartamento.Show();
        }

        #endregion

        private void ToolStripMenuItem_fechar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void controlesVisuaisToolStripMenuItem_Click(object sender, EventArgs e) {
            ControlesVisuaisView controlesVisuais = new ControlesVisuaisView();
            controlesVisuais.Show();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void ToolStripMenuItem_solicitarReembolso_Click(object sender, EventArgs e) {
            ReembolsoDeslocamentoView reembolsoDeslocamento = new ReembolsoDeslocamentoView();
            reembolsoDeslocamento.Show();
        }

        private void relatórioDeReembolsosToolStripMenuItem_Click(object sender, EventArgs e) {
            RelatorioReembolsos relatorioReembolsos = new RelatorioReembolsos();
            relatorioReembolsos.Show();
        }
    }
}
