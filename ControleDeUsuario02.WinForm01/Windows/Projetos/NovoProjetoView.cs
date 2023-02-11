using ControleDeUsuario02.WinForm01.Controllers;
using ControleDeUsuario02.WinForm01.Model;

namespace ControleDeUsuario02.WinForm01.Windows.Projetos {
    public partial class NovoProjetoView : Form {
        public NovoProjetoView() {
            InitializeComponent();
        }

        private void NovoProjetoView_Load(object sender, EventArgs e) {
            textBox_nomeProjeto.Focus();
        }

        private void ToolStripMenuItem_voltarAoInício_Click(object sender, EventArgs e) {
            this.Hide();
        }

        private void ToolStripMenuItem_fechar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void button_salvar_Click(object sender, EventArgs e) {
            var nome = textBox_nomeProjeto.Text;
            var descricao = textBox_descrProjeto.Text;

            var projeto = new ProjectModel { Name = nome, Description = descricao };

            var post = ProjectController.PostOne(projeto);

            if (post != null) {
                MessageBox.Show(string.Format(Retornos.NovoProjetoSucesso, post.Name, post.Id), string.Format(Retornos.Sucesso), MessageBoxButtons.OK, MessageBoxIcon.Information);

                textBox_nomeProjeto.Clear();
                textBox_descrProjeto.Clear();
            } else {
                MessageBox.Show(string.Format(Retornos.NovoProjetoErro), string.Format(Retornos.Erro), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
