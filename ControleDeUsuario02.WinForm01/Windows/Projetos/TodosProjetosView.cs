using ControleDeUsuario02.WinForm01.Controllers;

namespace ControleDeUsuario02.WinForm01.Windows.Projetos {
    public partial class TodosProjetosView : Form {
        public TodosProjetosView() {
            InitializeComponent();
        }

        private void TodosProjetosView_Load(object sender, EventArgs e) {
            var projetos = ProjectController.GetAll();

            if (projetos != null) {
                if (projetos.Count != 0) {
                    dataGridView_projetos.DataSource = projetos;

                    timer_refresh.Start();
                    timer_gifLoading.Start();
                } else {
                    MessageBox.Show(string.Format(Retornos.NenhumProjetoEncontrado), string.Format(Retornos.Erro), MessageBoxButtons.OK, MessageBoxIcon.Error);

                    timer_refresh.Start();
                    timer_gifLoading.Start();
                }
            } else {
                this.Close();

                timer_refresh.Stop();
                timer_gifLoading.Stop();

                MessageBox.Show(string.Format(Retornos.ErroDeAcessoAoDB), string.Format(Retornos.Erro), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            pictureBox_loading.Hide();
        }

        private void timer_refresh_Tick(object sender, EventArgs e) {
            TodosProjetosView_Load(sender, e);
        }

        private void timer_gifLoading_Tick(object sender, EventArgs e) {
            pictureBox_loading.Show();

            dataGridView_projetos.DataSource = string.Empty;
        }
    }
}
