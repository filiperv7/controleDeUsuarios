namespace ControleDeUsuario02.WinForm01.Windows.Usuarios {
    partial class NovoUsuarioView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoUsuarioView));
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_form = new System.Windows.Forms.Panel();
            this.label_nomeProjeto = new System.Windows.Forms.Label();
            this.textBox_nomeProjeto = new System.Windows.Forms.TextBox();
            this.panel_selecioneProjeto = new System.Windows.Forms.Panel();
            this.label_selecioneProjeto = new System.Windows.Forms.Label();
            this.comboBox_projetos = new System.Windows.Forms.ComboBox();
            this.label_descrProjeto = new System.Windows.Forms.Label();
            this.textBox_descrProjeto = new System.Windows.Forms.TextBox();
            this.radioButton_projetoExistente = new System.Windows.Forms.RadioButton();
            this.radioButton_projetoNovo = new System.Windows.Forms.RadioButton();
            this.label_usuario = new System.Windows.Forms.Label();
            this.listView_departamentos = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_addDepartamento = new System.Windows.Forms.Button();
            this.label_departamento = new System.Windows.Forms.Label();
            this.label_nomeDepartamento = new System.Windows.Forms.Label();
            this.textBox_descrDepartamento = new System.Windows.Forms.TextBox();
            this.textBox_nomeDepartamento = new System.Windows.Forms.TextBox();
            this.label_descrDepartamento = new System.Windows.Forms.Label();
            this.button_salvar = new System.Windows.Forms.Button();
            this.label_Projeto = new System.Windows.Forms.Label();
            this.textBox_sobrenome = new System.Windows.Forms.TextBox();
            this.label_sobrenome = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label_nome = new System.Windows.Forms.Label();
            this.panel_header = new System.Windows.Forms.Panel();
            this.lable_title = new System.Windows.Forms.Label();
            this.projectModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel_body.SuspendLayout();
            this.panel_form.SuspendLayout();
            this.panel_selecioneProjeto.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.panel_form);
            this.panel_body.Controls.Add(this.panel_header);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 0);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1062, 544);
            this.panel_body.TabIndex = 0;
            // 
            // panel_form
            // 
            this.panel_form.Controls.Add(this.label_nomeProjeto);
            this.panel_form.Controls.Add(this.textBox_nomeProjeto);
            this.panel_form.Controls.Add(this.panel_selecioneProjeto);
            this.panel_form.Controls.Add(this.label_descrProjeto);
            this.panel_form.Controls.Add(this.textBox_descrProjeto);
            this.panel_form.Controls.Add(this.radioButton_projetoExistente);
            this.panel_form.Controls.Add(this.radioButton_projetoNovo);
            this.panel_form.Controls.Add(this.label_usuario);
            this.panel_form.Controls.Add(this.listView_departamentos);
            this.panel_form.Controls.Add(this.panel1);
            this.panel_form.Controls.Add(this.button_salvar);
            this.panel_form.Controls.Add(this.label_Projeto);
            this.panel_form.Controls.Add(this.textBox_sobrenome);
            this.panel_form.Controls.Add(this.label_sobrenome);
            this.panel_form.Controls.Add(this.textBox_nome);
            this.panel_form.Controls.Add(this.label_nome);
            this.panel_form.Location = new System.Drawing.Point(0, 79);
            this.panel_form.Name = "panel_form";
            this.panel_form.Size = new System.Drawing.Size(1062, 465);
            this.panel_form.TabIndex = 1;
            // 
            // label_nomeProjeto
            // 
            this.label_nomeProjeto.AutoSize = true;
            this.label_nomeProjeto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_nomeProjeto.Location = new System.Drawing.Point(12, 158);
            this.label_nomeProjeto.Name = "label_nomeProjeto";
            this.label_nomeProjeto.Size = new System.Drawing.Size(154, 25);
            this.label_nomeProjeto.TabIndex = 5;
            this.label_nomeProjeto.Text = "Nome do Projeto:";
            // 
            // textBox_nomeProjeto
            // 
            this.textBox_nomeProjeto.Location = new System.Drawing.Point(12, 187);
            this.textBox_nomeProjeto.Name = "textBox_nomeProjeto";
            this.textBox_nomeProjeto.Size = new System.Drawing.Size(257, 31);
            this.textBox_nomeProjeto.TabIndex = 5;
            // 
            // panel_selecioneProjeto
            // 
            this.panel_selecioneProjeto.Controls.Add(this.label_selecioneProjeto);
            this.panel_selecioneProjeto.Controls.Add(this.comboBox_projetos);
            this.panel_selecioneProjeto.Location = new System.Drawing.Point(287, 129);
            this.panel_selecioneProjeto.Name = "panel_selecioneProjeto";
            this.panel_selecioneProjeto.Size = new System.Drawing.Size(194, 74);
            this.panel_selecioneProjeto.TabIndex = 22;
            // 
            // label_selecioneProjeto
            // 
            this.label_selecioneProjeto.AutoSize = true;
            this.label_selecioneProjeto.Location = new System.Drawing.Point(5, 7);
            this.label_selecioneProjeto.Name = "label_selecioneProjeto";
            this.label_selecioneProjeto.Size = new System.Drawing.Size(164, 25);
            this.label_selecioneProjeto.TabIndex = 23;
            this.label_selecioneProjeto.Text = "Selecione o Projeto";
            // 
            // comboBox_projetos
            // 
            this.comboBox_projetos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_projetos.Location = new System.Drawing.Point(6, 35);
            this.comboBox_projetos.Name = "comboBox_projetos";
            this.comboBox_projetos.Size = new System.Drawing.Size(182, 33);
            this.comboBox_projetos.TabIndex = 21;
            // 
            // label_descrProjeto
            // 
            this.label_descrProjeto.AutoSize = true;
            this.label_descrProjeto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_descrProjeto.Location = new System.Drawing.Point(286, 133);
            this.label_descrProjeto.Name = "label_descrProjeto";
            this.label_descrProjeto.Size = new System.Drawing.Size(92, 25);
            this.label_descrProjeto.TabIndex = 7;
            this.label_descrProjeto.Text = "Descrição:";
            // 
            // textBox_descrProjeto
            // 
            this.textBox_descrProjeto.Location = new System.Drawing.Point(286, 161);
            this.textBox_descrProjeto.Multiline = true;
            this.textBox_descrProjeto.Name = "textBox_descrProjeto";
            this.textBox_descrProjeto.Size = new System.Drawing.Size(286, 58);
            this.textBox_descrProjeto.TabIndex = 6;
            // 
            // radioButton_projetoExistente
            // 
            this.radioButton_projetoExistente.AutoSize = true;
            this.radioButton_projetoExistente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_projetoExistente.Location = new System.Drawing.Point(101, 129);
            this.radioButton_projetoExistente.Name = "radioButton_projetoExistente";
            this.radioButton_projetoExistente.Size = new System.Drawing.Size(108, 25);
            this.radioButton_projetoExistente.TabIndex = 4;
            this.radioButton_projetoExistente.TabStop = true;
            this.radioButton_projetoExistente.Text = "Existente";
            this.radioButton_projetoExistente.UseVisualStyleBackColor = true;
            this.radioButton_projetoExistente.CheckedChanged += new System.EventHandler(this.radioButton_projetoExistente_CheckedChanged);
            // 
            // radioButton_projetoNovo
            // 
            this.radioButton_projetoNovo.AutoSize = true;
            this.radioButton_projetoNovo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_projetoNovo.Location = new System.Drawing.Point(17, 129);
            this.radioButton_projetoNovo.Name = "radioButton_projetoNovo";
            this.radioButton_projetoNovo.Size = new System.Drawing.Size(77, 25);
            this.radioButton_projetoNovo.TabIndex = 3;
            this.radioButton_projetoNovo.TabStop = true;
            this.radioButton_projetoNovo.Text = "Novo";
            this.radioButton_projetoNovo.UseVisualStyleBackColor = true;
            this.radioButton_projetoNovo.CheckedChanged += new System.EventHandler(this.radioButton_projetoNovo_CheckedChanged);
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_usuario.Location = new System.Drawing.Point(12, 2);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(84, 28);
            this.label_usuario.TabIndex = 17;
            this.label_usuario.Text = "Usuário";
            // 
            // listView_departamentos
            // 
            this.listView_departamentos.Location = new System.Drawing.Point(12, 244);
            this.listView_departamentos.Name = "listView_departamentos";
            this.listView_departamentos.Size = new System.Drawing.Size(869, 207);
            this.listView_departamentos.TabIndex = 20;
            this.listView_departamentos.UseCompatibleStateImageBehavior = false;
            this.listView_departamentos.View = System.Windows.Forms.View.List;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button_addDepartamento);
            this.panel1.Controls.Add(this.label_departamento);
            this.panel1.Controls.Add(this.label_nomeDepartamento);
            this.panel1.Controls.Add(this.textBox_descrDepartamento);
            this.panel1.Controls.Add(this.textBox_nomeDepartamento);
            this.panel1.Controls.Add(this.label_descrDepartamento);
            this.panel1.Location = new System.Drawing.Point(588, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 233);
            this.panel1.TabIndex = 10;
            // 
            // button_addDepartamento
            // 
            this.button_addDepartamento.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_addDepartamento.Location = new System.Drawing.Point(318, 175);
            this.button_addDepartamento.Name = "button_addDepartamento";
            this.button_addDepartamento.Size = new System.Drawing.Size(125, 42);
            this.button_addDepartamento.TabIndex = 9;
            this.button_addDepartamento.Text = "Adicionar";
            this.button_addDepartamento.UseVisualStyleBackColor = true;
            this.button_addDepartamento.Click += new System.EventHandler(this.button_addDepartamento_Click);
            // 
            // label_departamento
            // 
            this.label_departamento.AutoSize = true;
            this.label_departamento.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_departamento.Location = new System.Drawing.Point(11, 1);
            this.label_departamento.Name = "label_departamento";
            this.label_departamento.Size = new System.Drawing.Size(150, 28);
            this.label_departamento.TabIndex = 9;
            this.label_departamento.Text = "Departamento";
            // 
            // label_nomeDepartamento
            // 
            this.label_nomeDepartamento.AutoSize = true;
            this.label_nomeDepartamento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_nomeDepartamento.Location = new System.Drawing.Point(11, 29);
            this.label_nomeDepartamento.Name = "label_nomeDepartamento";
            this.label_nomeDepartamento.Size = new System.Drawing.Size(212, 25);
            this.label_nomeDepartamento.TabIndex = 10;
            this.label_nomeDepartamento.Text = "Nome do Departamento:";
            // 
            // textBox_descrDepartamento
            // 
            this.textBox_descrDepartamento.Location = new System.Drawing.Point(11, 162);
            this.textBox_descrDepartamento.Multiline = true;
            this.textBox_descrDepartamento.Name = "textBox_descrDepartamento";
            this.textBox_descrDepartamento.Size = new System.Drawing.Size(283, 58);
            this.textBox_descrDepartamento.TabIndex = 8;
            // 
            // textBox_nomeDepartamento
            // 
            this.textBox_nomeDepartamento.Location = new System.Drawing.Point(11, 57);
            this.textBox_nomeDepartamento.Name = "textBox_nomeDepartamento";
            this.textBox_nomeDepartamento.Size = new System.Drawing.Size(283, 31);
            this.textBox_nomeDepartamento.TabIndex = 7;
            // 
            // label_descrDepartamento
            // 
            this.label_descrDepartamento.AutoSize = true;
            this.label_descrDepartamento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_descrDepartamento.Location = new System.Drawing.Point(11, 132);
            this.label_descrDepartamento.Name = "label_descrDepartamento";
            this.label_descrDepartamento.Size = new System.Drawing.Size(92, 25);
            this.label_descrDepartamento.TabIndex = 12;
            this.label_descrDepartamento.Text = "Descrição:";
            // 
            // button_salvar
            // 
            this.button_salvar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_salvar.Location = new System.Drawing.Point(887, 400);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(159, 51);
            this.button_salvar.TabIndex = 10;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.UseVisualStyleBackColor = true;
            this.button_salvar.Click += new System.EventHandler(this.button_salvar_Click);
            // 
            // label_Projeto
            // 
            this.label_Projeto.AutoSize = true;
            this.label_Projeto.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Projeto.Location = new System.Drawing.Point(12, 97);
            this.label_Projeto.Name = "label_Projeto";
            this.label_Projeto.Size = new System.Drawing.Size(81, 28);
            this.label_Projeto.TabIndex = 4;
            this.label_Projeto.Text = "Projeto";
            // 
            // textBox_sobrenome
            // 
            this.textBox_sobrenome.Location = new System.Drawing.Point(287, 58);
            this.textBox_sobrenome.Name = "textBox_sobrenome";
            this.textBox_sobrenome.Size = new System.Drawing.Size(286, 31);
            this.textBox_sobrenome.TabIndex = 2;
            // 
            // label_sobrenome
            // 
            this.label_sobrenome.AutoSize = true;
            this.label_sobrenome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_sobrenome.Location = new System.Drawing.Point(287, 30);
            this.label_sobrenome.Name = "label_sobrenome";
            this.label_sobrenome.Size = new System.Drawing.Size(109, 25);
            this.label_sobrenome.TabIndex = 2;
            this.label_sobrenome.Text = "Sobrenome:";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(12, 58);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(257, 31);
            this.textBox_nome.TabIndex = 1;
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_nome.Location = new System.Drawing.Point(12, 30);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(65, 25);
            this.label_nome.TabIndex = 0;
            this.label_nome.Text = "Nome:";
            // 
            // panel_header
            // 
            this.panel_header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_header.BackColor = System.Drawing.Color.LightGray;
            this.panel_header.Controls.Add(this.lable_title);
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1062, 77);
            this.panel_header.TabIndex = 0;
            // 
            // lable_title
            // 
            this.lable_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lable_title.AutoSize = true;
            this.lable_title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lable_title.Location = new System.Drawing.Point(384, 21);
            this.lable_title.Name = "lable_title";
            this.lable_title.Size = new System.Drawing.Size(294, 34);
            this.lable_title.TabIndex = 2;
            this.lable_title.Text = "Criar Novo Usuário";
            // 
            // projectModelBindingSource
            // 
            this.projectModelBindingSource.DataSource = typeof(ControleDeUsuario02.WinForm01.Model.ProjectModel);
            // 
            // NovoUsuarioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 544);
            this.Controls.Add(this.panel_body);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1084, 600);
            this.MinimumSize = new System.Drawing.Size(1084, 600);
            this.Name = "NovoUsuarioView";
            this.Text = "  Controle de Usuário  |  Novo Usuário";
            this.Load += new System.EventHandler(this.NovoUsuarioView_Load);
            this.panel_body.ResumeLayout(false);
            this.panel_form.ResumeLayout(false);
            this.panel_form.PerformLayout();
            this.panel_selecioneProjeto.ResumeLayout(false);
            this.panel_selecioneProjeto.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.projectModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_body;
        private Panel panel_form;
        private Label label_nome;
        private Panel panel_header;
        private Button button_salvar;
        private TextBox textBox_descrDepartamento;
        private Label label_descrDepartamento;
        private TextBox textBox_nomeDepartamento;
        private Label label_nomeDepartamento;
        private Label label_departamento;
        private TextBox textBox_nomeProjeto;
        private Label label_nomeProjeto;
        private Label label_Projeto;
        private TextBox textBox_sobrenome;
        private Label label_sobrenome;
        private TextBox textBox_nome;
        private Label lable_title;
        private ListView listView_departamentos;
        private Panel panel1;
        private Button button_addDepartamento;
        private Label label_usuario;
        private RadioButton radioButton_projetoExistente;
        private RadioButton radioButton_projetoNovo;
        private BindingSource projectModelBindingSource;
        private Panel panel_selecioneProjeto;
        private Label label_selecioneProjeto;
        private ComboBox comboBox_projetos;
        private Label label_descrProjeto;
        private TextBox textBox_descrProjeto;
    }
}