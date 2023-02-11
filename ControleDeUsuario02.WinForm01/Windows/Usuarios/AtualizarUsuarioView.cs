using ControleDeUsuario02.WinForm01.Controllers;
using ControleDeUsuario02.WinForm01.Model;
using System.Collections;

namespace ControleDeUsuario02.WinForm01.Windows.Usuarios {
    public partial class AtualizarUsuarioView : Form {
        public AtualizarUsuarioView() {
            InitializeComponent();
        }

        #region PROPRIEDADES
        private List<DepartmentModel> _departamentos;
        private List<ProjectModel> _projetos;
        private FullUserModel _usuario;

        public List<DepartmentModel> Departamentos {
            get { return _departamentos; }
            set { _departamentos = value; }
        }

        public List<ProjectModel> Projetos {
            get { return _projetos; }
            set { _projetos = value; }
        }

        public FullUserModel Usuario {
            get { return _usuario; }
            set { _usuario = value; }
        }
        #endregion

        private void AtualizarUsuarioView_Load(object sender, EventArgs e) {
            numericUpDown_id.Select();

            textBox_nome.Enabled = false;
            textBox_sobrenome.Enabled = false;
            comboBox_projetos.Enabled = false;
            checkedListBox_selecioneDepartamentos.Enabled = false;
            button_limpar.Enabled = false;
            button_salvar.Enabled = false;
        }

        private void button_buscar_Click(object sender, EventArgs e) {

            var id = Convert.ToInt32(numericUpDown_id.Value);
            Usuario = UserController.GetUserCompleteById(id);

            if (Usuario != null) {

                textBox_nome.Enabled = true;
                textBox_sobrenome.Enabled = true;
                comboBox_projetos.Enabled = true;
                checkedListBox_selecioneDepartamentos.Enabled = true;
                button_limpar.Enabled = true;
                button_salvar.Enabled = true;

                foreach (int checado in checkedListBox_selecioneDepartamentos.CheckedIndices) {
                    checkedListBox_selecioneDepartamentos.SetItemChecked(checado, false);
                }

                Departamentos = DepartmentController.GetAll();
                foreach (var departamento in Departamentos) {
                    checkedListBox_selecioneDepartamentos.Items.Add(departamento.Name);
                }

                Projetos = ProjectController.GetAll();
                comboBox_projetos.DataSource = Projetos.Select(projeto => projeto.Name).ToList();

                textBox_nome.Text = Usuario.FirstName;
                textBox_sobrenome.Text = Usuario.LastName;

                foreach (ProjectModel projeto in Projetos) {
                    if (projeto.Id == Usuario.Project.Id) {
                        comboBox_projetos.SelectedIndex = (projeto.Id - 1);
                    }
                }

                foreach (DepartmentModel departamentoModel in Usuario.Departments) {
                    foreach (DepartmentModel departamento in Departamentos) {
                        if (departamentoModel.Name == departamento.Name) {
                            checkedListBox_selecioneDepartamentos.SetItemChecked((departamento.Id - 1), true);
                        }
                    }
                }

            } else {
                MessageBox.Show(string.Format(Retornos.UsuairoNaoEncontrado, Usuario?.Id), string.Format(Retornos.Erro), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_salvar_Click(object sender, EventArgs e) {
            var nome = textBox_nome.Text;
            var sobrenome = textBox_sobrenome.Text;

            if (nome != string.Empty && sobrenome != string.Empty) {
                int id = Usuario.Id;

                var projeto = new ProjectModel();

                var projetos = ProjectController.GetAll();

                foreach (ProjectModel item in projetos) {
                    if (item.Name == comboBox_projetos.SelectedItem.ToString()) {
                        projeto = new ProjectModel {
                            Id = item.Id,
                            Name = item.Name,
                            Description = item.Description
                        };
                    }
                }

                var departamentos = new List<DepartmentModel>();
                
                var listaDepartamentos = DepartmentController.GetAll();

                foreach (string checado in checkedListBox_selecioneDepartamentos.CheckedItems) {
                    foreach (DepartmentModel item in listaDepartamentos) {
                        if (checado == item.Name) {
                            DepartmentModel departamento = new DepartmentModel {
                                Id = item.Id,
                                Name = item.Name,
                                Description = item.Description
                            };

                            departamentos.Add(departamento);
                        }
                    }
                }

                if (departamentos.Count > 0) {
                    if (projeto != null) {
                        var retornaUsuario = UserController.PutOne(id, nome, sobrenome, projeto, departamentos);

                        if (retornaUsuario != null) {
                            MessageBox.Show(string.Format(Retornos.AtualizadoComSucesso, retornaUsuario.FirstName), Retornos.Sucesso,
                                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            LimparCampos();
                        } else {
                            MessageBox.Show(Retornos.EscolhaUmProjeto, Retornos.Erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    } else {
                        MessageBox.Show(Retornos.EscolhaUmProjeto, Retornos.Erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                } else {
                    MessageBox.Show(Retornos.EscolhaAoMenosUmDepartamento, Retornos.Erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } else {
                MessageBox.Show(Retornos.PreenchaTodosCampos, Retornos.Erro, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_limpar_Click(object sender, EventArgs e) {
            LimparCampos();
        }

        private void LimparCampos() {
            textBox_nome.Text = string.Empty;
            textBox_sobrenome.Text = string.Empty;

            comboBox_projetos.DataSource = null;
            checkedListBox_selecioneDepartamentos.Items.Clear();

            numericUpDown_id.Value = 0;
            numericUpDown_id.Focus();

            textBox_nome.Enabled = false;
            textBox_sobrenome.Enabled = false;
            comboBox_projetos.Enabled = false;
            checkedListBox_selecioneDepartamentos.Enabled = false;
            button_limpar.Enabled = false;
            button_salvar.Enabled = false;
        }
    }
}
