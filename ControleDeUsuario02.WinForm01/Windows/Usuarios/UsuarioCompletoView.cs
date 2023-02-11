using ControleDeUsuario02.WinForm01.Controllers;

namespace ControleDeUsuario02.WinForm01.Windows.Usuarios {
    public partial class UsuarioCompletoView : Form {
        public UsuarioCompletoView() {
            InitializeComponent();
        }

        private void UsuarioCompletoView_Load(object sender, EventArgs e) {
            radioButton_id.Checked = true;

            textBox_buscarIdOuNome.Focus();
        }

        private void radioButton_id_Enter(object sender, EventArgs e) {
            textBox_buscarIdOuNome.Width = 121;
            label_buscarIdOuNome.Text = "Digite o Id:";

            textBox_buscarIdOuNome.PlaceholderText = string.Empty;
            textBox_buscarIdOuNome.Clear();
            textBox_buscarIdOuNome.Focus();

            textBox_buscarIdOuNome.MaxLength = 4;
        }
        private void radioButton_nome_Enter(object sender, EventArgs e) {
            textBox_buscarIdOuNome.Width = 222;
            label_buscarIdOuNome.Text = "Digite o Nome:";

            textBox_buscarIdOuNome.PlaceholderText = string.Empty;
            textBox_buscarIdOuNome.Clear();
            textBox_buscarIdOuNome.Focus();

            textBox_buscarIdOuNome.MaxLength = 10;
        }

        private void textBox_buscarIdOuNome_KeyPress(object sender, KeyPressEventArgs e) {
            LetraOuNumero(e);
        }

        private void LetraOuNumero(KeyPressEventArgs e) {
            if (radioButton_id.Checked) {
                int tecla = e.KeyChar;

                if (!char.IsDigit(e.KeyChar) && tecla != 08) {
                    e.Handled = true;
                }
            } else {
                int tecla = e.KeyChar;

                if (!char.IsLetter(e.KeyChar) && tecla != 08) {
                    e.Handled = true;
                }
            }
        }

        private void button_buscar_Click(object sender, EventArgs e) {
            treeView_usuarioBuscado.Nodes.Clear();

            if (radioButton_nome.Checked && textBox_buscarIdOuNome.Text != string.Empty) {
                var nomeDigitado = textBox_buscarIdOuNome.Text;
                var users = UserController.GetByName(nomeDigitado);

                if (users.Count != 0) {
                    var controlador = 0;
                    foreach (var user in users) {
                        var controle = user.Id + controlador;
                        treeView_usuarioBuscado.Nodes.Add(string.Format(Retornos.IdENomeUsuario, user.Id, user.FirstName, user.LastName));
                        treeView_usuarioBuscado.Nodes[controle - user.Id].Nodes.Add(string.Format(Retornos.IdENomeProjeto, user.Project.Id, user.Project.Name))
                                                        .Nodes.Add(string.Format(Retornos.DescricaoProjeto, user.Project.Description));

                        foreach (var departamento in user.Departments) {
                            treeView_usuarioBuscado.Nodes[controle - user.Id].Nodes.Add(string.Format(Retornos.IdENomeDepartamento, departamento.Id, departamento.Name))
                                                            .Nodes.Add(string.Format(Retornos.DescricaoDepartamento, departamento.Description));
                        }

                        controlador++;
                    }
                } else {
                    DialogResult atualizarOuFechar = MessageBox.Show(string.Format(Retornos.NenhumUsuarioEncontrado, string.Format(Retornos.TentarNovamente)),
                                                                     string.Format(Retornos.Erro), MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    if (atualizarOuFechar == DialogResult.Yes) {
                        button_buscar_Click(sender, e);
                    } else if (atualizarOuFechar == DialogResult.No) {
                        textBox_buscarIdOuNome.Clear();
                        textBox_buscarIdOuNome.Focus();
                    }
                }
            } else if (textBox_buscarIdOuNome.Text != string.Empty) {
                var idDigitado = int.Parse(textBox_buscarIdOuNome.Text);
                var user = UserController.GetUserCompleteById(idDigitado);

                if (user != null) {
                    treeView_usuarioBuscado.Nodes.Add(string.Format(Retornos.IdENomeUsuario, user.Id, user.FirstName, user.LastName));
                    treeView_usuarioBuscado.Nodes[0].Nodes.Add(string.Format(Retornos.IdENomeProjeto, user.Project.Id, user.Project.Name))
                                                    .Nodes.Add(string.Format(Retornos.DescricaoProjeto, user.Project.Description));

                    foreach (var departamento in user.Departments) {
                        treeView_usuarioBuscado.Nodes[0].Nodes.Add(string.Format(Retornos.IdENomeDepartamento, departamento.Id, departamento.Name))
                                                        .Nodes.Add(string.Format(Retornos.DescricaoDepartamento, departamento.Description));
                    }
                } else {
                    MessageBox.Show(string.Format(Retornos.NenhumUsuarioEncontrado), string.Format(Retornos.Erro), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                if (radioButton_id.Checked) {
                    textBox_buscarIdOuNome.PlaceholderText = string.Format(Retornos.DigiteId);
                } else {
                    textBox_buscarIdOuNome.PlaceholderText = string.Format(Retornos.DigiteNome);
                }
            }
        }
    }
}
