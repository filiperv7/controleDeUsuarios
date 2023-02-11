using ControleDeUsuario02.WinForm01.Controllers;
using ControleDeUsuario02.WinForm01.Model;

namespace ControleDeUsuario02.WinForm01.Windows.Usuarios {
    public partial class NovoUsuarioView : Form {
        int controle = 1;
        public NovoUsuarioView() {
            InitializeComponent();
        }

        private List<ProjectModel> _projetos;

        public List<ProjectModel> Projetos {
            get { return _projetos; }
            set { _projetos = value; }
        }

        private void NovoUsuarioView_Load(object sender, EventArgs e) {
            listView_departamentos.View = View.Details;
            listView_departamentos.FullRowSelect = true;
            listView_departamentos.GridLines = true;
            listView_departamentos.LabelEdit = true;

            listView_departamentos.Columns.Add("Nome", 310, HorizontalAlignment.Left);
            listView_departamentos.Columns.Add("Descrição", 540, HorizontalAlignment.Left);

            label_departamento.Text = string.Format(Retornos.AdicionarDepartamentos, controle);

            button_salvar.Enabled = false;

            radioButton_projetoNovo.Checked = true;

            panel_selecioneProjeto.Hide();
            label_selecioneProjeto.Hide();
            comboBox_projetos.Hide();
        }

        private void button_addDepartamento_Click(object sender, EventArgs e) {
            ListViewItem departamento = new ListViewItem(textBox_nomeDepartamento.Text);
            departamento.SubItems.Add(textBox_descrDepartamento.Text);

            if (textBox_nomeDepartamento.Text != string.Empty && textBox_descrDepartamento.Text != string.Empty) {

                DialogResult prosseguirOuNao = MessageBox.Show(string.Format(Retornos.DesejaInserirEsteDepartamento, textBox_nomeDepartamento.Text),
                                                               string.Format(Retornos.Confirmacao), MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (prosseguirOuNao == DialogResult.Yes) {

                    if (listView_departamentos.Items.Count <= 0) {
                        listView_departamentos.Items.Add(departamento);

                        controle++;
                        label_departamento.Text = string.Format(Retornos.AdicionarDepartamentos, controle);

                        textBox_nomeDepartamento.Clear();
                        textBox_descrDepartamento.Clear();

                        textBox_nomeDepartamento.Focus();

                        button_salvar.Enabled = true;
                    } else {
                        string departamentoJaExistente = null;
                        for (int i = 0; i < listView_departamentos.Items.Count; i++) {

                            if (textBox_nomeDepartamento.Text.Trim() == listView_departamentos.Items[i].SubItems[0].Text) {
                                MessageBox.Show(string.Format(Retornos.DepartamentoJaInserido), string.Format(Retornos.Erro), MessageBoxButtons.OK, MessageBoxIcon.Error);

                                textBox_nomeDepartamento.Focus();

                                departamentoJaExistente = "existe";
                                break;
                            }
                        }
                        if (departamentoJaExistente != "existe") {
                            listView_departamentos.Items.Add(departamento);

                            controle++;
                            label_departamento.Text = string.Format(Retornos.AdicionarDepartamentos, controle);

                            textBox_nomeDepartamento.Clear();
                            textBox_descrDepartamento.Clear();

                            textBox_nomeDepartamento.Focus();
                        }
                    }
                } else if (prosseguirOuNao == DialogResult.No) {
                    textBox_nomeDepartamento.Clear();
                    textBox_descrDepartamento.Clear();

                    textBox_nomeDepartamento.Focus();
                }
            } else {
                textBox_nomeDepartamento.Focus();
                MessageBox.Show(string.Format(Retornos.PreenchaTodosCampos), string.Format(Retornos.Erro), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_salvar_Click(object sender, EventArgs e) {
            var nome = textBox_nome.Text;
            var sobrenome = textBox_sobrenome.Text;

            var nomeProjeto = textBox_nomeProjeto.Text;
            var descProjeto = textBox_descrProjeto.Text;

            var departamentos = new List<DepartmentModel>();

            if (nome != string.Empty && sobrenome != string.Empty) {

                ProjectModel projeto = new ProjectModel();

                if (radioButton_projetoNovo.Checked) {
                    if (nomeProjeto != string.Empty && descProjeto != string.Empty) {
                        projeto = new ProjectModel { Name = nomeProjeto, Description = descProjeto };
                    } else {
                        MessageBox.Show(string.Format(Retornos.PreenchaOsCamposNovoProjeto), string.Format(Retornos.Erro),
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else if (radioButton_projetoExistente.Checked) {
                    var item = comboBox_projetos.SelectedIndex;

                    projeto = Projetos[item];
                } else {
                    MessageBox.Show(string.Format(Retornos.SelecionePorjetoNovoOuExistente), string.Format(Retornos.Erro),
                                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (listView_departamentos.Items.Count != 0) {
                    for (var i = 0; i < listView_departamentos.Items.Count; i++) {
                        var listaDeDepartamentos = DepartmentController.GetAll();

                        string departamentoJaExistente = null;

                        foreach (DepartmentModel departamentoModel in listaDeDepartamentos) {
                            if (listView_departamentos.Items[i].SubItems[0].Text == departamentoModel.Name) {
                                departamentos.Add(departamentoModel);

                                departamentoJaExistente = "existe";
                                break;
                            } 
                        }  
                        
                        if (departamentoJaExistente != "existe") {
                            var departamento = new DepartmentModel {
                                Name = listView_departamentos.Items[i].SubItems[0].Text,
                                Description = listView_departamentos.Items[i].SubItems[1].Text
                            };

                            var departamentoCriado = DepartmentController.PostOne(departamento);

                            departamentos.Add(departamentoCriado);
                        }
                    }

                    var user = new FullUserModel {
                        FirstName = nome,
                        LastName = sobrenome,
                        Project = projeto,
                        Departments = departamentos
                    };

                    var retornaUsuario = UserController.InsertFull(user);

                    if (retornaUsuario != null) {
                        MessageBox.Show(string.Format(Retornos.UsuarioCriadoComSucesso, retornaUsuario.FirstName, retornaUsuario.Id), string.Format(Retornos.Sucesso), MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                    }

                } else {
                    MessageBox.Show(string.Format(Retornos.NenhumDepartamentoInserido), string.Format(Retornos.Erro), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else {
                MessageBox.Show(string.Format(Retornos.PreenchaTodosCampos), string.Format(Retornos.Erro), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos() {
            textBox_nome.Clear();
            textBox_sobrenome.Clear();

            textBox_nomeProjeto.Clear();
            textBox_descrProjeto.Clear();

            textBox_nomeDepartamento.Clear();
            textBox_descrDepartamento.Clear();

            listView_departamentos.Items.Clear();
        }

        private void radioButton_projetoExistente_CheckedChanged(object sender, EventArgs e) {
            panel_selecioneProjeto.Show();
            comboBox_projetos.Show();
            label_selecioneProjeto.Show();

            label_nomeProjeto.Hide();
            textBox_nomeProjeto.Hide();
            label_descrProjeto.Hide();
            textBox_descrProjeto.Hide();

            if (Projetos is null) {
                Projetos = ProjectController.GetAll();
            }

            comboBox_projetos.DataSource = Projetos.Select(projeto => projeto.Name).ToList();
        }

        private void radioButton_projetoNovo_CheckedChanged(object sender, EventArgs e) {
            panel_selecioneProjeto.Hide();
            comboBox_projetos.Hide();
            label_selecioneProjeto.Hide();

            label_nomeProjeto.Show();
            textBox_nomeProjeto.Show();
            label_descrProjeto.Show();
            textBox_descrProjeto.Show();
        }
    }
}
