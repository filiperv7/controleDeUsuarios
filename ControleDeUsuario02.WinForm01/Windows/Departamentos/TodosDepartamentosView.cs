using ControleDeUsuario02.WinForm01.Controllers;
using ControleDeUsuario02.WinForm01.Model;

namespace ControleDeUsuario02.WinForm01.Windows.Departamentos {
    public partial class TodosDepartamentosView : Form {
        public TodosDepartamentosView() {
            InitializeComponent();
        }

        private List<DepartmentModel> _departamentos;

        public List<DepartmentModel> Departamentos {
            get { return _departamentos; }
            set { _departamentos = value; }
        }


        private void TodosDepartamentosView_Load(object sender, EventArgs e) {
            label_descricaoTitulo.Hide();

            Departamentos = DepartmentController.GetAll();

            if (Departamentos != null) {
                foreach (var departamento in Departamentos) {
                    listBox_nomesDosDepartamentos.Items.Add(departamento.Name);
                }
            } else {
                this.Close();
                MessageBox.Show(string.Format(Retornos.ErroDeAcessoAoDB), string.Format(Retornos.Erro), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void novoDepartamentoToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();

            var novoDepartamento = new NovoDepartamentoView();
            novoDepartamento.Show();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void listBox_Departamentos_SelectedIndexChanged(object sender, EventArgs e) {
            label_descricaoTitulo.Show();

            var item = listBox_nomesDosDepartamentos.SelectedIndex;

            label_descricaoDepartamentoSelecionado.Text = string.Format(Retornos.DescricaoDoDepartamentoSelecionado,
                                                                        Departamentos[item].Description);
        }
    }
}
