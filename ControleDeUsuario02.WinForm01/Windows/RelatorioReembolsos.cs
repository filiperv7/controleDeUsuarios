using ControleDeUsuario02.Domain.Model;
using ControleDeUsuario02.WinForm01.Controllers;
using ControleDeUsuario02.WinForm01.Model;
using System.ComponentModel;

namespace ControleDeUsuario02.WinForm01.Windows {
    public partial class RelatorioReembolsos : Form {
        public RelatorioReembolsos() {
            InitializeComponent();
        }

        List<ReembolsoDeslocamentoModel> todosReembolsos;

        BindingList<ReembolsoDeslocamentoModel> filter;

        private void RelatorioReembolsos_Load(object sender, EventArgs e) {
            todosReembolsos = ReembolsoDeslocamentoController.GetAll();
        }

        public void FiltrarReembolsosPorStatus(StatusEnum status) {
            filter = new BindingList<ReembolsoDeslocamentoModel>(todosReembolsos
                                                            .Where(_ => _.Status == status).ToList());

            dataGridView_relatorioReembolsos.DataSource = filter;
        }


        private void radioButton_criados_CheckedChanged(object sender, EventArgs e) {
            if (radioButton_criados.Checked == true) {
                FiltrarReembolsosPorStatus(StatusEnum.Criado);
            }
        }
 
        private void radioButton_aprovados_CheckedChanged(object sender, EventArgs e) {
            if (radioButton_aprovados.Checked == true) {
                FiltrarReembolsosPorStatus(StatusEnum.Aprovado);
            }
        }

        private void radioButton_reprovados_CheckedChanged(object sender, EventArgs e) {
            if (radioButton_reprovados.Checked == true) {
                FiltrarReembolsosPorStatus(StatusEnum.Reprovado);
            }
        }
    }
}
