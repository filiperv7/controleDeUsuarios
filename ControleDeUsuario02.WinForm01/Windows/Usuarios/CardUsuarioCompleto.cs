using ControleDeUsuario02.WinForm01.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeUsuario02.WinForm01.Windows.Usuarios {
    public partial class CardUsuarioCompleto : UserControl {
        public CardUsuarioCompleto() {
            InitializeComponent();
        }


        #region PROPRIEDADES
        private string _usuario;
        private string _projeto;
        private string _departamentos;

        public string Usuario {
            get { return _usuario; }
            set { _usuario = value; label_usuario.Text = value; }
        }

        public string Projeto {
            get { return _projeto; }
            set { _projeto = value; label_projeto.Text = value; }
        }

        public string Departamentos {
            get { return _departamentos; }
            set { _departamentos = value; label_departamentos.Text = value; }
        }

        private void label_projeto_MouseEnter(object sender, EventArgs e) {
            label_projeto.BackColor = Color.LightBlue;
        }
        private void label_projeto_MouseLeave(object sender, EventArgs e) {
            label_projeto.BackColor = Color.Transparent;
        }
        private void label_departamentos_MouseEnter(object sender, EventArgs e) {
            label_departamentos.BackColor = Color.LightBlue;
        }
        private void label_departamentos_MouseLeave(object sender, EventArgs e) {
            label_departamentos.BackColor = Color.Transparent;
        }


        private ProjectModel _projetoModel;
        private List<DepartmentModel> _departamentosModels;

        public List<DepartmentModel> DepartmentModels {
            get { return _departamentosModels; }
            set { _departamentosModels = value; }
        }

        public ProjectModel ProjectModel {
            get { return _projetoModel; }
            set { _projetoModel = value; }
        }
        #endregion


        private void label_projeto_Click(object sender, EventArgs e) {
            MessageBox.Show(string.Format(Retornos.ProjetoCompleto, _projetoModel.Id, _projetoModel.Name, _projetoModel.Description), string.Format(Retornos.Sucesso), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
