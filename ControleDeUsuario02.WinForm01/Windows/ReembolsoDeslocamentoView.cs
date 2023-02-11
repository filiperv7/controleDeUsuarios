using ControleDeUsuario02.WinForm01.Controllers;
using ControleDeUsuario02.WinForm01.Model;

namespace ControleDeUsuario02.WinForm01.Windows {
    public partial class ReembolsoDeslocamentoView : Form {
        public ReembolsoDeslocamentoView() {
            InitializeComponent();
        }

        private void button_enviarSolicitacao_Click(object sender, EventArgs e) {
            
            if (!(textBox_descricao.Text == string.Empty || textBox_enderecoInicial.Text == string.Empty || textBox_enderecoFinal.Text == string.Empty)) {
                var reembolso = new ReembolsoDeslocamentoModel() {
                    Descricao = textBox_descricao.Text.Trim(),
                    EnderecoInicial = textBox_enderecoInicial.Text.Trim(),
                    EnderecoFinal = textBox_enderecoFinal.Text.Trim()
                };

                var reembolsoCriado = ReembolsoDeslocamentoController.Post(reembolso);
                if (reembolsoCriado != null ) { 
                    MessageBox.Show("Solicitação de reembolso criada com sucesso!", "Sucesso !", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBox_enderecoInicial.Clear();
                    textBox_enderecoFinal.Clear();
                    textBox_descricao.Clear();

                    textBox_enderecoInicial.Focus();
                }
                
            } else {
                MessageBox.Show("Preencha todos os campos!", "Erro !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
