namespace ControleDeUsuario02.WinForm01.Windows.Projetos {
    partial class TodosProjetosView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodosProjetosView));
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_mostrarTodos = new System.Windows.Forms.Panel();
            this.pictureBox_loading = new System.Windows.Forms.PictureBox();
            this.dataGridView_projetos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel_header = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.timer_refresh = new System.Windows.Forms.Timer(this.components);
            this.timer_gifLoading = new System.Windows.Forms.Timer(this.components);
            this.panel_body.SuspendLayout();
            this.panel_mostrarTodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_projetos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectModelBindingSource)).BeginInit();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.panel_mostrarTodos);
            this.panel_body.Controls.Add(this.panel_header);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 0);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1115, 622);
            this.panel_body.TabIndex = 1;
            // 
            // panel_mostrarTodos
            // 
            this.panel_mostrarTodos.BackColor = System.Drawing.Color.White;
            this.panel_mostrarTodos.Controls.Add(this.pictureBox_loading);
            this.panel_mostrarTodos.Controls.Add(this.dataGridView_projetos);
            this.panel_mostrarTodos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_mostrarTodos.Location = new System.Drawing.Point(0, 75);
            this.panel_mostrarTodos.Name = "panel_mostrarTodos";
            this.panel_mostrarTodos.Size = new System.Drawing.Size(1115, 547);
            this.panel_mostrarTodos.TabIndex = 2;
            // 
            // pictureBox_loading
            // 
            this.pictureBox_loading.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox_loading.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_loading.Image")));
            this.pictureBox_loading.Location = new System.Drawing.Point(1027, 7);
            this.pictureBox_loading.Name = "pictureBox_loading";
            this.pictureBox_loading.Size = new System.Drawing.Size(80, 80);
            this.pictureBox_loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_loading.TabIndex = 1;
            this.pictureBox_loading.TabStop = false;
            // 
            // dataGridView_projetos
            // 
            this.dataGridView_projetos.AllowUserToAddRows = false;
            this.dataGridView_projetos.AllowUserToDeleteRows = false;
            this.dataGridView_projetos.AutoGenerateColumns = false;
            this.dataGridView_projetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_projetos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView_projetos.DataSource = this.projectModelBindingSource;
            this.dataGridView_projetos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_projetos.Location = new System.Drawing.Point(0, 96);
            this.dataGridView_projetos.Name = "dataGridView_projetos";
            this.dataGridView_projetos.ReadOnly = true;
            this.dataGridView_projetos.RowHeadersWidth = 62;
            this.dataGridView_projetos.RowTemplate.Height = 33;
            this.dataGridView_projetos.Size = new System.Drawing.Size(1115, 451);
            this.dataGridView_projetos.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 300;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionDataGridViewTextBoxColumn.Width = 600;
            // 
            // projectModelBindingSource
            // 
            this.projectModelBindingSource.DataSource = typeof(ControleDeUsuario02.WinForm01.Model.ProjectModel);
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.LightGray;
            this.panel_header.Controls.Add(this.label_title);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1115, 77);
            this.panel_header.TabIndex = 1;
            // 
            // label_title
            // 
            this.label_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(373, 21);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(369, 34);
            this.label_title.TabIndex = 3;
            this.label_title.Text = "Listar Todos os Projetos";
            // 
            // timer_refresh
            // 
            this.timer_refresh.Interval = 9500;
            this.timer_refresh.Tick += new System.EventHandler(this.timer_refresh_Tick);
            // 
            // timer_gifLoading
            // 
            this.timer_gifLoading.Interval = 9000;
            this.timer_gifLoading.Tick += new System.EventHandler(this.timer_gifLoading_Tick);
            // 
            // TodosProjetosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 622);
            this.Controls.Add(this.panel_body);
            this.MaximizeBox = false;
            this.Name = "TodosProjetosView";
            this.Text = "  Controle de Usuário  |  Todos Projetos";
            this.Load += new System.EventHandler(this.TodosProjetosView_Load);
            this.panel_body.ResumeLayout(false);
            this.panel_mostrarTodos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_loading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_projetos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectModelBindingSource)).EndInit();
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_body;
        private Panel panel_mostrarTodos;
        private Panel panel_header;
        private Label label_title;
        private DataGridView dataGridView_projetos;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private BindingSource projectModelBindingSource;
        private PictureBox pictureBox_loading;
        private System.Windows.Forms.Timer timer_refresh;
        private Label label1;
        private System.Windows.Forms.Timer timer_gifLoading;
    }
}