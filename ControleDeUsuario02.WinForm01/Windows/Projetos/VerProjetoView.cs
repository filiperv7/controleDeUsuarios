using ControleDeUsuario02.WinForm01.Controllers;

namespace ControleDeUsuario02.WinForm01.Windows.Projetos {
    public partial class VerProjetoView : Form {
        public VerProjetoView() {
            InitializeComponent();
        }

        private void VerProjetoView_Load(object sender, EventArgs e) {
            this.Height = 240;
        }

        private void button1_buscar_Click(object sender, EventArgs e) {
            if (textBox_id.Text != string.Empty) {
                for (int i = 0; i <= progressBar1.Maximum; i++) {
                    Thread.Sleep(10);
                    progressBar1.Value = i;
                }

                int id = int.Parse(textBox_id.Text.Trim());
                var projeto = ProjectController.GetById(id);

                if (projeto != null) {
                    this.Height = 420;

                    textBox_id.Clear();
                    label_idNomeProjeto.Text = string.Empty;
                    label_descricaoProjeto.Text = string.Empty;

                    label_idNomeProjeto.Text = string.Format(Retornos.IdENomeProjeto, projeto.Id, projeto.Name);
                    label_descricaoProjeto.Text = string.Format(Retornos.Descricao, projeto.Description);

                    textBox_id.Focus();
                } else {
                    MessageBox.Show(string.Format(Retornos.ProjetoNaoEncontrado, id), string.Format(Retornos.Erro), MessageBoxButtons.OK, MessageBoxIcon.Information);

                    label_idNomeProjeto.Text = string.Empty;
                    label_descricaoProjeto.Text = string.Empty;
                    textBox_id.Clear();
                    textBox_id.Focus();

                    this.Height = 240;
                }
                
            } else {
                textBox_id.Focus();
            }
        }
    }
}
