namespace ControleDeUsuario02.WinForm01.Windows.Usuarios {
    partial class TodosUsuariosView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodosUsuariosView));
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_mostrarTodos = new System.Windows.Forms.Panel();
            this.button_refresh = new System.Windows.Forms.Button();
            this.treeView_todosUsuarios = new System.Windows.Forms.TreeView();
            this.panel_header = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.lable_title = new System.Windows.Forms.Label();
            this.panel_body.SuspendLayout();
            this.panel_mostrarTodos.SuspendLayout();
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
            this.panel_body.Size = new System.Drawing.Size(1145, 618);
            this.panel_body.TabIndex = 0;
            // 
            // panel_mostrarTodos
            // 
            this.panel_mostrarTodos.Controls.Add(this.button_refresh);
            this.panel_mostrarTodos.Controls.Add(this.treeView_todosUsuarios);
            this.panel_mostrarTodos.Location = new System.Drawing.Point(0, 75);
            this.panel_mostrarTodos.Name = "panel_mostrarTodos";
            this.panel_mostrarTodos.Size = new System.Drawing.Size(1145, 543);
            this.panel_mostrarTodos.TabIndex = 2;
            // 
            // button_refresh
            // 
            this.button_refresh.AccessibleDescription = "";
            this.button_refresh.BackColor = System.Drawing.Color.LightGray;
            this.button_refresh.BackgroundImage = global::ControleDeUsuario02.WinForm01.Imagens.update;
            this.button_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_refresh.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.button_refresh.FlatAppearance.BorderSize = 0;
            this.button_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_refresh.Location = new System.Drawing.Point(1051, 461);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Padding = new System.Windows.Forms.Padding(10);
            this.button_refresh.Size = new System.Drawing.Size(60, 60);
            this.button_refresh.TabIndex = 2;
            this.button_refresh.UseVisualStyleBackColor = false;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // treeView_todosUsuarios
            // 
            this.treeView_todosUsuarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView_todosUsuarios.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.treeView_todosUsuarios.Location = new System.Drawing.Point(3, 3);
            this.treeView_todosUsuarios.Name = "treeView_todosUsuarios";
            this.treeView_todosUsuarios.Size = new System.Drawing.Size(1139, 537);
            this.treeView_todosUsuarios.TabIndex = 0;
            // 
            // panel_header
            // 
            this.panel_header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_header.BackColor = System.Drawing.Color.LightGray;
            this.panel_header.Controls.Add(this.label_title);
            this.panel_header.Controls.Add(this.lable_title);
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1145, 77);
            this.panel_header.TabIndex = 1;
            // 
            // label_title
            // 
            this.label_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(384, 21);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(377, 34);
            this.label_title.TabIndex = 3;
            this.label_title.Text = "Listar Todos os Usuários";
            // 
            // lable_title
            // 
            this.lable_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lable_title.AutoSize = true;
            this.lable_title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lable_title.Location = new System.Drawing.Point(1329, 21);
            this.lable_title.Name = "lable_title";
            this.lable_title.Size = new System.Drawing.Size(294, 34);
            this.lable_title.TabIndex = 2;
            this.lable_title.Text = "Criar Novo Usuário";
            // 
            // TodosUsuariosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 618);
            this.Controls.Add(this.panel_body);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TodosUsuariosView";
            this.Text = "  Controle de Usuário  |  Todos os Usuários";
            this.Load += new System.EventHandler(this.TodosUsuariosView_Load);
            this.panel_body.ResumeLayout(false);
            this.panel_mostrarTodos.ResumeLayout(false);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_body;
        private Panel panel_header;
        private Label lable_title;
        private Label label_title;
        private Panel panel_mostrarTodos;
        private TreeView treeView_todosUsuarios;
        private Button button_refresh;
    }
}