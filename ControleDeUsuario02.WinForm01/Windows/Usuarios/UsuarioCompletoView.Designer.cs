namespace ControleDeUsuario02.WinForm01.Windows.Usuarios {
    partial class UsuarioCompletoView {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioCompletoView));
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_controlesDeBusca = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_id = new System.Windows.Forms.RadioButton();
            this.radioButton_nome = new System.Windows.Forms.RadioButton();
            this.textBox_buscarIdOuNome = new System.Windows.Forms.TextBox();
            this.button_buscar = new System.Windows.Forms.Button();
            this.label_buscarIdOuNome = new System.Windows.Forms.Label();
            this.panel_mostrarUsuario = new System.Windows.Forms.Panel();
            this.treeView_usuarioBuscado = new System.Windows.Forms.TreeView();
            this.panel_header = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_body.SuspendLayout();
            this.panel_controlesDeBusca.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel_mostrarUsuario.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.panel_controlesDeBusca);
            this.panel_body.Controls.Add(this.panel_mostrarUsuario);
            this.panel_body.Controls.Add(this.panel_header);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 0);
            this.panel_body.Margin = new System.Windows.Forms.Padding(2);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1108, 641);
            this.panel_body.TabIndex = 0;
            // 
            // panel_controlesDeBusca
            // 
            this.panel_controlesDeBusca.Controls.Add(this.groupBox1);
            this.panel_controlesDeBusca.Controls.Add(this.textBox_buscarIdOuNome);
            this.panel_controlesDeBusca.Controls.Add(this.button_buscar);
            this.panel_controlesDeBusca.Controls.Add(this.label_buscarIdOuNome);
            this.panel_controlesDeBusca.Location = new System.Drawing.Point(0, 75);
            this.panel_controlesDeBusca.Margin = new System.Windows.Forms.Padding(2);
            this.panel_controlesDeBusca.Name = "panel_controlesDeBusca";
            this.panel_controlesDeBusca.Size = new System.Drawing.Size(1112, 162);
            this.panel_controlesDeBusca.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_id);
            this.groupBox1.Controls.Add(this.radioButton_nome);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(288, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(158, 107);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Por";
            // 
            // radioButton_id
            // 
            this.radioButton_id.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_id.AutoSize = true;
            this.radioButton_id.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_id.Location = new System.Drawing.Point(19, 31);
            this.radioButton_id.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_id.Name = "radioButton_id";
            this.radioButton_id.Size = new System.Drawing.Size(53, 29);
            this.radioButton_id.TabIndex = 1;
            this.radioButton_id.TabStop = true;
            this.radioButton_id.Text = "Id";
            this.radioButton_id.UseVisualStyleBackColor = true;
            this.radioButton_id.Enter += new System.EventHandler(this.radioButton_id_Enter);
            // 
            // radioButton_nome
            // 
            this.radioButton_nome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton_nome.AutoSize = true;
            this.radioButton_nome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radioButton_nome.Location = new System.Drawing.Point(19, 62);
            this.radioButton_nome.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton_nome.Name = "radioButton_nome";
            this.radioButton_nome.Size = new System.Drawing.Size(86, 29);
            this.radioButton_nome.TabIndex = 6;
            this.radioButton_nome.TabStop = true;
            this.radioButton_nome.Text = "Nome";
            this.radioButton_nome.UseVisualStyleBackColor = true;
            this.radioButton_nome.Enter += new System.EventHandler(this.radioButton_nome_Enter);
            // 
            // textBox_buscarIdOuNome
            // 
            this.textBox_buscarIdOuNome.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_buscarIdOuNome.Location = new System.Drawing.Point(668, 61);
            this.textBox_buscarIdOuNome.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_buscarIdOuNome.MaxLength = 4;
            this.textBox_buscarIdOuNome.Name = "textBox_buscarIdOuNome";
            this.textBox_buscarIdOuNome.Size = new System.Drawing.Size(122, 31);
            this.textBox_buscarIdOuNome.TabIndex = 10;
            this.textBox_buscarIdOuNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_buscarIdOuNome_KeyPress);
            // 
            // button_buscar
            // 
            this.button_buscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_buscar.Location = new System.Drawing.Point(668, 98);
            this.button_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(126, 34);
            this.button_buscar.TabIndex = 11;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // label_buscarIdOuNome
            // 
            this.label_buscarIdOuNome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_buscarIdOuNome.AutoSize = true;
            this.label_buscarIdOuNome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_buscarIdOuNome.Location = new System.Drawing.Point(665, 28);
            this.label_buscarIdOuNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_buscarIdOuNome.Name = "label_buscarIdOuNome";
            this.label_buscarIdOuNome.Size = new System.Drawing.Size(117, 28);
            this.label_buscarIdOuNome.TabIndex = 9;
            this.label_buscarIdOuNome.Text = "Digite o Id:";
            // 
            // panel_mostrarUsuario
            // 
            this.panel_mostrarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_mostrarUsuario.Controls.Add(this.treeView_usuarioBuscado);
            this.panel_mostrarUsuario.Location = new System.Drawing.Point(2, 239);
            this.panel_mostrarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.panel_mostrarUsuario.Name = "panel_mostrarUsuario";
            this.panel_mostrarUsuario.Size = new System.Drawing.Size(1102, 399);
            this.panel_mostrarUsuario.TabIndex = 1;
            // 
            // treeView_usuarioBuscado
            // 
            this.treeView_usuarioBuscado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.treeView_usuarioBuscado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.treeView_usuarioBuscado.Location = new System.Drawing.Point(0, 2);
            this.treeView_usuarioBuscado.Margin = new System.Windows.Forms.Padding(2);
            this.treeView_usuarioBuscado.Name = "treeView_usuarioBuscado";
            this.treeView_usuarioBuscado.Size = new System.Drawing.Size(1102, 397);
            this.treeView_usuarioBuscado.TabIndex = 0;
            // 
            // panel_header
            // 
            this.panel_header.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_header.BackColor = System.Drawing.Color.LightGray;
            this.panel_header.Controls.Add(this.label_title);
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(2);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1108, 75);
            this.panel_header.TabIndex = 0;
            // 
            // label_title
            // 
            this.label_title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(432, 21);
            this.label_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(242, 34);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "Buscar Usuário";
            // 
            // UsuarioCompletoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 641);
            this.Controls.Add(this.panel_body);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1130, 697);
            this.MinimumSize = new System.Drawing.Size(1130, 697);
            this.Name = "UsuarioCompletoView";
            this.Text = "  Controle de Usuário  |  Buscar Usuario";
            this.Load += new System.EventHandler(this.UsuarioCompletoView_Load);
            this.panel_body.ResumeLayout(false);
            this.panel_controlesDeBusca.ResumeLayout(false);
            this.panel_controlesDeBusca.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel_mostrarUsuario.ResumeLayout(false);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_body;
        private Panel panel_header;
        private Panel panel_mostrarUsuario;
        private Label label_title;
        private RadioButton radioButton_id;
        private Panel panel_controlesDeBusca;
        private RadioButton radioButton_nome;
        private TextBox textBox_buscarIdOuNome;
        private Label label_buscarIdOuNome;
        private Button button_buscar;
        private TreeView treeView_usuarioBuscado;
        private GroupBox groupBox1;
    }
}