namespace ControleDeUsuario02.WinForm01.Windows.Projetos {
    partial class NovoProjetoView {
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
            this.panel_body = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_opcoes = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_voltarAoInício = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_divider = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_fechar = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_salvar = new System.Windows.Forms.Button();
            this.textBox_descrProjeto = new System.Windows.Forms.TextBox();
            this.label_descrProjeto = new System.Windows.Forms.Label();
            this.textBox_nomeProjeto = new System.Windows.Forms.TextBox();
            this.label_nomeProjeto = new System.Windows.Forms.Label();
            this.panel_header = new System.Windows.Forms.Panel();
            this.lable_title = new System.Windows.Forms.Label();
            this.panel_body.SuspendLayout();
            this.menu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.menu);
            this.panel_body.Controls.Add(this.panel1);
            this.panel_body.Controls.Add(this.panel_header);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 0);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(804, 338);
            this.panel_body.TabIndex = 0;
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_opcoes});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menu.Size = new System.Drawing.Size(804, 33);
            this.menu.TabIndex = 4;
            this.menu.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_opcoes
            // 
            this.ToolStripMenuItem_opcoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_voltarAoInício,
            this.toolStripMenuItem_divider,
            this.ToolStripMenuItem_fechar});
            this.ToolStripMenuItem_opcoes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ToolStripMenuItem_opcoes.Name = "ToolStripMenuItem_opcoes";
            this.ToolStripMenuItem_opcoes.Size = new System.Drawing.Size(91, 29);
            this.ToolStripMenuItem_opcoes.Text = "Opções";
            // 
            // ToolStripMenuItem_voltarAoInício
            // 
            this.ToolStripMenuItem_voltarAoInício.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToolStripMenuItem_voltarAoInício.Name = "ToolStripMenuItem_voltarAoInício";
            this.ToolStripMenuItem_voltarAoInício.Size = new System.Drawing.Size(232, 34);
            this.ToolStripMenuItem_voltarAoInício.Text = "Voltar ao Início";
            this.ToolStripMenuItem_voltarAoInício.Click += new System.EventHandler(this.ToolStripMenuItem_voltarAoInício_Click);
            // 
            // toolStripMenuItem_divider
            // 
            this.toolStripMenuItem_divider.Name = "toolStripMenuItem_divider";
            this.toolStripMenuItem_divider.Size = new System.Drawing.Size(229, 6);
            // 
            // ToolStripMenuItem_fechar
            // 
            this.ToolStripMenuItem_fechar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ToolStripMenuItem_fechar.Name = "ToolStripMenuItem_fechar";
            this.ToolStripMenuItem_fechar.Size = new System.Drawing.Size(232, 34);
            this.ToolStripMenuItem_fechar.Text = "Fechar";
            this.ToolStripMenuItem_fechar.Click += new System.EventHandler(this.ToolStripMenuItem_fechar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_salvar);
            this.panel1.Controls.Add(this.textBox_descrProjeto);
            this.panel1.Controls.Add(this.label_descrProjeto);
            this.panel1.Controls.Add(this.textBox_nomeProjeto);
            this.panel1.Controls.Add(this.label_nomeProjeto);
            this.panel1.Location = new System.Drawing.Point(83, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 169);
            this.panel1.TabIndex = 3;
            // 
            // button_salvar
            // 
            this.button_salvar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_salvar.Location = new System.Drawing.Point(458, 113);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(134, 39);
            this.button_salvar.TabIndex = 3;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.UseVisualStyleBackColor = true;
            this.button_salvar.Click += new System.EventHandler(this.button_salvar_Click);
            // 
            // textBox_descrProjeto
            // 
            this.textBox_descrProjeto.Location = new System.Drawing.Point(306, 48);
            this.textBox_descrProjeto.Multiline = true;
            this.textBox_descrProjeto.Name = "textBox_descrProjeto";
            this.textBox_descrProjeto.Size = new System.Drawing.Size(286, 58);
            this.textBox_descrProjeto.TabIndex = 2;
            // 
            // label_descrProjeto
            // 
            this.label_descrProjeto.AutoSize = true;
            this.label_descrProjeto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_descrProjeto.Location = new System.Drawing.Point(306, 18);
            this.label_descrProjeto.Name = "label_descrProjeto";
            this.label_descrProjeto.Size = new System.Drawing.Size(92, 25);
            this.label_descrProjeto.TabIndex = 16;
            this.label_descrProjeto.Text = "Descrição:";
            // 
            // textBox_nomeProjeto
            // 
            this.textBox_nomeProjeto.Location = new System.Drawing.Point(33, 48);
            this.textBox_nomeProjeto.Name = "textBox_nomeProjeto";
            this.textBox_nomeProjeto.Size = new System.Drawing.Size(257, 31);
            this.textBox_nomeProjeto.TabIndex = 1;
            // 
            // label_nomeProjeto
            // 
            this.label_nomeProjeto.AutoSize = true;
            this.label_nomeProjeto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_nomeProjeto.Location = new System.Drawing.Point(31, 18);
            this.label_nomeProjeto.Name = "label_nomeProjeto";
            this.label_nomeProjeto.Size = new System.Drawing.Size(154, 25);
            this.label_nomeProjeto.TabIndex = 15;
            this.label_nomeProjeto.Text = "Nome do Projeto:";
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.LightGray;
            this.panel_header.Controls.Add(this.lable_title);
            this.panel_header.Location = new System.Drawing.Point(0, 38);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(804, 77);
            this.panel_header.TabIndex = 0;
            // 
            // lable_title
            // 
            this.lable_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lable_title.AutoSize = true;
            this.lable_title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lable_title.Location = new System.Drawing.Point(257, 21);
            this.lable_title.Name = "lable_title";
            this.lable_title.Size = new System.Drawing.Size(286, 34);
            this.lable_title.TabIndex = 3;
            this.lable_title.Text = "Criar Novo Projeto";
            // 
            // NovoProjetoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 338);
            this.Controls.Add(this.panel_body);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(826, 394);
            this.MinimumSize = new System.Drawing.Size(826, 394);
            this.Name = "NovoProjetoView";
            this.Text = "  Controle de Usuário  |  Novo Projeto";
            this.Load += new System.EventHandler(this.NovoProjetoView_Load);
            this.panel_body.ResumeLayout(false);
            this.panel_body.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_body;
        private Panel panel_header;
        private Label lable_title;
        private Panel panel1;
        private TextBox textBox_descrProjeto;
        private Label label_descrProjeto;
        private TextBox textBox_nomeProjeto;
        private Label label_nomeProjeto;
        private Button button_salvar;
        private MenuStrip menu;
        private ToolStripMenuItem ToolStripMenuItem_opcoes;
        private ToolStripMenuItem ToolStripMenuItem_voltarAoInício;
        private ToolStripSeparator toolStripMenuItem_divider;
        private ToolStripMenuItem ToolStripMenuItem_fechar;
    }
}