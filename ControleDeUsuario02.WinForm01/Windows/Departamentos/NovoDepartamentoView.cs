using ControleDeUsuario02.WinForm01.Controllers;
using ControleDeUsuario02.WinForm01.Model;

namespace ControleDeUsuario02.WinForm01.Windows.Departamentos {
    public partial class NovoDepartamentoView : Form {
        public NovoDepartamentoView() {
            InitializeComponent();
        }

        private void button_salvar_Click(object sender, EventArgs e) {

            if (textBox_nome.Text.Trim() == string.Empty || textBox_descricao.Text.Trim() == string.Empty) { 
                if (string.IsNullOrEmpty(textBox_nome.Text)) {
                    errorProvider.SetError(textBox_nome, "Digite o nome do Departamento!");
                } else {
                    errorProvider.SetError(textBox_nome, null);
                }

                if (string.IsNullOrEmpty(textBox_descricao.Text)) {
                    errorProvider.SetError(textBox_descricao, "Digite a descrição do Departamento!");
                } else {
                    errorProvider.SetError(textBox_descricao, null);
                }
            } else {
                DepartmentModel departamento = new DepartmentModel {
                    Name = textBox_nome.Text.Trim(),
                    Description = textBox_descricao.Text.Trim(),
                };

                DepartmentController.PostOne(departamento);
            }
        }
    }
}
