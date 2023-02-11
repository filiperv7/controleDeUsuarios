using ControleDeUsuario02.WinForm01.Controllers;

namespace ControleDeUsuario02.WinForm01.Windows.Projetos {
    public partial class AtualizandoProjetoView : Form {
        public AtualizandoProjetoView() {
            InitializeComponent();
        }

        private void AtualizandoProjetoView_Load(object sender, EventArgs e) {
            int id = AtualizarProjetoView.id;

            lable_title.Text = string.Format(Retornos.AtualizarProjeto, id);

            var projeto = ProjectController.GetById(id);

            textBox_nome.Text = projeto.Name;
            textBox_nome.Focus();

            textBox_descricao.Text = projeto.Description;
        }

        private void button_atualizar_Click(object sender, EventArgs e) {
            int id = AtualizarProjetoView.id;
            var projeto = ProjectController.GetById(id);

            if (textBox_nome.Text.Trim() != string.Empty && textBox_descricao.Text != string.Empty) {
                if ((textBox_nome.Text.Trim() != projeto.Name && textBox_descricao.Text.Trim() != projeto.Description)
                     || textBox_descricao.Text.Trim() != projeto.Description || textBox_nome.Text.Trim() != projeto.Name) {

                    ProjectController.PutOne(id, textBox_nome.Text.Trim(), textBox_descricao.Text.Trim());

                    this.Close();

                    AtualizarProjetoView atualizarProjeto = new AtualizarProjetoView();
                    atualizarProjeto.Show();
                } else {
                    MessageBox.Show(string.Format(Retornos.NecessarioMudanca), string.Format(Retornos.Erro), MessageBoxButtons.OK, MessageBoxIcon.Error);

                    textBox_nome.Focus();
                }
            } else {
                MessageBox.Show(string.Format(Retornos.PreenchaTodosCampos), string.Format(Retornos.Atencao), MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
