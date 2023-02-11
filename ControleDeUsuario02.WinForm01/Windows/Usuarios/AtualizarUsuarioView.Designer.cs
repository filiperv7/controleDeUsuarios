namespace ControleDeUsuario02.WinForm01.Windows.Usuarios {
    partial class AtualizarUsuarioView {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtualizarUsuarioView));
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_form = new System.Windows.Forms.Panel();
            this.panel_selecioneDepartamentos = new System.Windows.Forms.Panel();
            this.checkedListBox_selecioneDepartamentos = new System.Windows.Forms.CheckedListBox();
            this.label_departamentos = new System.Windows.Forms.Label();
            this.panel_selecioneProjeto = new System.Windows.Forms.Panel();
            this.comboBox_projetos = new System.Windows.Forms.ComboBox();
            this.label_projeto = new System.Windows.Forms.Label();
            this.button_limpar = new System.Windows.Forms.Button();
            this.textBox_sobrenome = new System.Windows.Forms.TextBox();
            this.panel_areaBusca = new System.Windows.Forms.Panel();
            this.button_buscar = new System.Windows.Forms.Button();
            this.divider = new System.Windows.Forms.Panel();
            this.label_digiteId = new System.Windows.Forms.Label();
            this.numericUpDown_id = new System.Windows.Forms.NumericUpDown();
            this.button_salvar = new System.Windows.Forms.Button();
            this.label_sobrenome = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label_nome = new System.Windows.Forms.Label();
            this.panel_header = new System.Windows.Forms.Panel();
            this.lable_title = new System.Windows.Forms.Label();
            this.departmentModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel_body.SuspendLayout();
            this.panel_form.SuspendLayout();
            this.panel_selecioneDepartamentos.SuspendLayout();
            this.panel_selecioneProjeto.SuspendLayout();
            this.panel_areaBusca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_id)).BeginInit();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.panel_form);
            this.panel_body.Controls.Add(this.panel_header);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 0);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(911, 447);
            this.panel_body.TabIndex = 0;
            // 
            // panel_form
            // 
            this.panel_form.Controls.Add(this.panel_selecioneDepartamentos);
            this.panel_form.Controls.Add(this.panel_selecioneProjeto);
            this.panel_form.Controls.Add(this.button_limpar);
            this.panel_form.Controls.Add(this.textBox_sobrenome);
            this.panel_form.Controls.Add(this.panel_areaBusca);
            this.panel_form.Controls.Add(this.button_salvar);
            this.panel_form.Controls.Add(this.label_sobrenome);
            this.panel_form.Controls.Add(this.textBox_nome);
            this.panel_form.Controls.Add(this.label_nome);
            this.panel_form.Location = new System.Drawing.Point(3, 80);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(905, 364);
            this.panel_form.TabIndex = 2;
            // 
            // panel_selecioneDepartamentos
            // 
            this.panel_selecioneDepartamentos.Controls.Add(this.checkedListBox_selecioneDepartamentos);
            this.panel_selecioneDepartamentos.Controls.Add(this.label_departamentos);
            this.panel_selecioneDepartamentos.Location = new System.Drawing.Point(542, 122);
            this.panel_selecioneDepartamentos.Name = "panel_selecioneDepartamentos";
            this.panel_selecioneDepartamentos.Size = new System.Drawing.Size(353, 180);
            this.panel_selecioneDepartamentos.TabIndex = 30;
            // 
            // checkedListBox_selecioneDepartamentos
            // 
            this.checkedListBox_selecioneDepartamentos.CheckOnClick = true;
            this.checkedListBox_selecioneDepartamentos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.checkedListBox_selecioneDepartamentos.FormattingEnabled = true;
            this.checkedListBox_selecioneDepartamentos.Location = new System.Drawing.Point(0, 36);
            this.checkedListBox_selecioneDepartamentos.Name = "checkedListBox_selecioneDepartamentos";
            this.checkedListBox_selecioneDepartamentos.Size = new System.Drawing.Size(353, 144);
            this.checkedListBox_selecioneDepartamentos.TabIndex = 24;
            // 
            // label_departamentos
            // 
            this.label_departamentos.AutoSize = true;
            this.label_departamentos.BackColor = System.Drawing.Color.Transparent;
            this.label_departamentos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_departamentos.Location = new System.Drawing.Point(1, 4);
            this.label_departamentos.Name = "label_departamentos";
            this.label_departamentos.Size = new System.Drawing.Size(282, 28);
            this.label_departamentos.TabIndex = 29;
            this.label_departamentos.Text = "Selecione os Departamentos";
            // 
            // panel_selecioneProjeto
            // 
            this.panel_selecioneProjeto.Controls.Add(this.comboBox_projetos);
            this.panel_selecioneProjeto.Controls.Add(this.label_projeto);
            this.panel_selecioneProjeto.Location = new System.Drawing.Point(286, 122);
            this.panel_selecioneProjeto.Name = "panel_selecioneProjeto";
            this.panel_selecioneProjeto.Size = new System.Drawing.Size(247, 77);
            this.panel_selecioneProjeto.TabIndex = 28;
            // 
            // comboBox_projetos
            // 
            this.comboBox_projetos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_projetos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_projetos.FormattingEnabled = true;
            this.comboBox_projetos.Location = new System.Drawing.Point(6, 35);
            this.comboBox_projetos.Name = "comboBox_projetos";
            this.comboBox_projetos.Size = new System.Drawing.Size(235, 33);
            this.comboBox_projetos.TabIndex = 21;
            // 
            // label_projeto
            // 
            this.label_projeto.AutoSize = true;
            this.label_projeto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_projeto.Location = new System.Drawing.Point(6, 4);
            this.label_projeto.Name = "label_projeto";
            this.label_projeto.Size = new System.Drawing.Size(213, 28);
            this.label_projeto.TabIndex = 4;
            this.label_projeto.Text = "Selecione um Projeto";
            // 
            // button_limpar
            // 
            this.button_limpar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_limpar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_limpar.Location = new System.Drawing.Point(288, 307);
            this.button_limpar.Name = "button_limpar";
            this.button_limpar.Size = new System.Drawing.Size(143, 51);
            this.button_limpar.TabIndex = 26;
            this.button_limpar.Text = "Limpar";
            this.button_limpar.UseVisualStyleBackColor = true;
            this.button_limpar.Click += new System.EventHandler(this.button_limpar_Click);
            // 
            // textBox_sobrenome
            // 
            this.textBox_sobrenome.Location = new System.Drawing.Point(15, 229);
            this.textBox_sobrenome.Name = "textBox_sobrenome";
            this.textBox_sobrenome.Size = new System.Drawing.Size(261, 31);
            this.textBox_sobrenome.TabIndex = 21;
            // 
            // panel_areaBusca
            // 
            this.panel_areaBusca.Controls.Add(this.button_buscar);
            this.panel_areaBusca.Controls.Add(this.divider);
            this.panel_areaBusca.Controls.Add(this.label_digiteId);
            this.panel_areaBusca.Controls.Add(this.numericUpDown_id);
            this.panel_areaBusca.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_areaBusca.Location = new System.Drawing.Point(0, 0);
            this.panel_areaBusca.Name = "panel_areaBusca";
            this.panel_areaBusca.Size = new System.Drawing.Size(905, 120);
            this.panel_areaBusca.TabIndex = 16;
            // 
            // button_buscar
            // 
            this.button_buscar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_buscar.Location = new System.Drawing.Point(504, 57);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(86, 31);
            this.button_buscar.TabIndex = 16;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // divider
            // 
            this.divider.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.divider.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.divider.Location = new System.Drawing.Point(273, 106);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(375, 1);
            this.divider.TabIndex = 18;
            // 
            // label_digiteId
            // 
            this.label_digiteId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_digiteId.AutoSize = true;
            this.label_digiteId.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_digiteId.Location = new System.Drawing.Point(321, 21);
            this.label_digiteId.Name = "label_digiteId";
            this.label_digiteId.Size = new System.Drawing.Size(280, 25);
            this.label_digiteId.TabIndex = 15;
            this.label_digiteId.Text = "Digite o Id do Usuário desejado:";
            // 
            // numericUpDown_id
            // 
            this.numericUpDown_id.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numericUpDown_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_id.Location = new System.Drawing.Point(326, 57);
            this.numericUpDown_id.Name = "numericUpDown_id";
            this.numericUpDown_id.Size = new System.Drawing.Size(93, 31);
            this.numericUpDown_id.TabIndex = 4;
            // 
            // button_salvar
            // 
            this.button_salvar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_salvar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_salvar.Location = new System.Drawing.Point(479, 307);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(143, 51);
            this.button_salvar.TabIndex = 14;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.UseVisualStyleBackColor = true;
            this.button_salvar.Click += new System.EventHandler(this.button_salvar_Click);
            // 
            // label_sobrenome
            // 
            this.label_sobrenome.AutoSize = true;
            this.label_sobrenome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_sobrenome.Location = new System.Drawing.Point(13, 198);
            this.label_sobrenome.Name = "label_sobrenome";
            this.label_sobrenome.Size = new System.Drawing.Size(124, 28);
            this.label_sobrenome.TabIndex = 2;
            this.label_sobrenome.Text = "Sobrenome:";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(15, 157);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(261, 31);
            this.textBox_nome.TabIndex = 1;
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_nome.Location = new System.Drawing.Point(13, 126);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(74, 28);
            this.label_nome.TabIndex = 0;
            this.label_nome.Text = "Nome:";
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.LightGray;
            this.panel_header.Controls.Add(this.lable_title);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(911, 78);
            this.panel_header.TabIndex = 0;
            // 
            // lable_title
            // 
            this.lable_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lable_title.AutoSize = true;
            this.lable_title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lable_title.Location = new System.Drawing.Point(321, 21);
            this.lable_title.Name = "lable_title";
            this.lable_title.Size = new System.Drawing.Size(269, 34);
            this.lable_title.TabIndex = 3;
            this.lable_title.Text = "Atualizar Usuário";
            // 
            // departmentModelBindingSource
            // 
            this.departmentModelBindingSource.DataSource = typeof(ControleDeUsuario02.WinForm01.Model.DepartmentModel);
            // 
            // AtualizarUsuarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 447);
            this.Controls.Add(this.panel_body);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1084, 700);
            this.Name = "AtualizarUsuarioView";
            this.Text = "  Controle de Usuários  |  Atualizar Usuário";
            this.Load += new System.EventHandler(this.AtualizarUsuarioView_Load);
            this.panel_body.ResumeLayout(false);
            this.panel_form.ResumeLayout(false);
            this.panel_form.PerformLayout();
            this.panel_selecioneDepartamentos.ResumeLayout(false);
            this.panel_selecioneDepartamentos.PerformLayout();
            this.panel_selecioneProjeto.ResumeLayout(false);
            this.panel_selecioneProjeto.PerformLayout();
            this.panel_areaBusca.ResumeLayout(false);
            this.panel_areaBusca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_id)).EndInit();
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_body;
        private Panel panel_header;
        private Label lable_title;
        private Panel panel_form;
        private Panel panel_areaBusca;
        private Button button_buscar;
        private Panel divider;
        private Label label_digiteId;
        private NumericUpDown numericUpDown_id;
        private Button button_salvar;
        private Label label_projeto;
        private Label label_sobrenome;
        private TextBox textBox_nome;
        private Label label_nome;
        private TextBox textBox_sobrenome;
        private Button button_limpar;
        private BindingSource departmentModelBindingSource;
        private Panel panel_selecioneProjeto;
        private Label label_selecioneProjeto;
        private ComboBox comboBox_projetos;
        private Panel panel_selecioneDepartamentos;
        private Label label_departamentos;
        private FolderBrowserDialog folderBrowserDialog1;
        private CheckedListBox checkedListBox_selecioneDepartamentos;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}