using ControleDeUsuario02.WinForm01.Controllers;

namespace ControleDeUsuario02.WinForm01.Windows.Projetos {
    public partial class AtualizarProjetoView : Form {
        public AtualizarProjetoView() {
            InitializeComponent();
        }

        public static int id { get; set; }

        private void AtualizarProjetoView_Load(object sender, EventArgs e) {
            var projetos = ProjectController.GetAll();

            if (projetos != null) {
                if (projetos.Count != 0) {
                    dataGridView_projetos.DataSource = projetos;

                    foreach (DataGridViewRow row in dataGridView_projetos.Rows) {
                        row.Cells["Icon"].Value = Image.FromFile("C:\\project\\ProjetoStartFilipe\\ControleDeUsuario02\\ControleDeUsuario02.WinForm01\\Resources\\edit.png");
                    }
                } else {
                    MessageBox.Show(string.Format(Retornos.NenhumProjetoEncontrado), string.Format(Retornos.Erro), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                this.Close();

                MessageBox.Show(string.Format(Retornos.ErroDeAcessoAoDB), string.Format(Retornos.Erro), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void dataGridView_projetos_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            id = Convert.ToInt32(dataGridView_projetos.Rows[e.RowIndex].Cells["Id"].Value.ToString());

            AtualizandoProjetoView atualizandoProjeto = new AtualizandoProjetoView();
            atualizandoProjeto.Show();

            this.Close();
        }
    }
}
