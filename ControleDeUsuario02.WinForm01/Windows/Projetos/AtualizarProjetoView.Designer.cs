namespace ControleDeUsuario02.WinForm01.Windows.Projetos {
    partial class AtualizarProjetoView {
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
            this.panel_body = new System.Windows.Forms.Panel();
            this.dataGridView_projetos = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.projectModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel_header = new System.Windows.Forms.Panel();
            this.lable_title = new System.Windows.Forms.Label();
            this.panel_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_projetos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectModelBindingSource)).BeginInit();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_body.Controls.Add(this.dataGridView_projetos);
            this.panel_body.Controls.Add(this.panel_header);
            this.panel_body.Location = new System.Drawing.Point(0, 0);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(740, 400);
            this.panel_body.TabIndex = 0;
            // 
            // dataGridView_projetos
            // 
            this.dataGridView_projetos.AllowUserToAddRows = false;
            this.dataGridView_projetos.AllowUserToDeleteRows = false;
            this.dataGridView_projetos.AllowUserToResizeColumns = false;
            this.dataGridView_projetos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_projetos.AutoGenerateColumns = false;
            this.dataGridView_projetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_projetos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nome,
            this.descricao,
            this.Icon});
            this.dataGridView_projetos.DataSource = this.projectModelBindingSource;
            this.dataGridView_projetos.Location = new System.Drawing.Point(0, 83);
            this.dataGridView_projetos.Name = "dataGridView_projetos";
            this.dataGridView_projetos.ReadOnly = true;
            this.dataGridView_projetos.RowHeadersWidth = 62;
            this.dataGridView_projetos.RowTemplate.Height = 33;
            this.dataGridView_projetos.Size = new System.Drawing.Size(740, 317);
            this.dataGridView_projetos.TabIndex = 1;
            this.dataGridView_projetos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_projetos_CellContentClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 55;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Name";
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 8;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 255;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "Description";
            this.descricao.HeaderText = "Descrição";
            this.descricao.MinimumWidth = 8;
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            this.descricao.Width = 300;
            // 
            // Icon
            // 
            this.Icon.HeaderText = "Editar";
            this.Icon.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Icon.MinimumWidth = 8;
            this.Icon.Name = "Icon";
            this.Icon.ReadOnly = true;
            this.Icon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Icon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Icon.Width = 65;
            // 
            // projectModelBindingSource
            // 
            this.projectModelBindingSource.DataSource = typeof(ControleDeUsuario02.WinForm01.Model.ProjectModel);
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.LightGray;
            this.panel_header.Controls.Add(this.lable_title);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(740, 83);
            this.panel_header.TabIndex = 1;
            // 
            // lable_title
            // 
            this.lable_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lable_title.AutoSize = true;
            this.lable_title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lable_title.Location = new System.Drawing.Point(240, 24);
            this.lable_title.Name = "lable_title";
            this.lable_title.Size = new System.Drawing.Size(261, 34);
            this.lable_title.TabIndex = 3;
            this.lable_title.Text = "Atualizar Projeto";
            // 
            // AtualizarProjetoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 400);
            this.Controls.Add(this.panel_body);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(808, 456);
            this.MinimumSize = new System.Drawing.Size(0, 456);
            this.Name = "AtualizarProjetoView";
            this.Text = "  Controle de Usuário  |  Atualizar Projeto";
            this.Load += new System.EventHandler(this.AtualizarProjetoView_Load);
            this.panel_body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_projetos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectModelBindingSource)).EndInit();
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_body;
        private DataGridView dataGridView_projetos;
        private BindingSource projectModelBindingSource;
        private Panel panel_header;
        private Label lable_title;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewImageColumn Icon;
    }
}