namespace ControleDeUsuario02.WinForm01.Windows.Departamentos {
    partial class TodosDepartamentosView {
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
            this.panel_descricao = new System.Windows.Forms.Panel();
            this.label_descricaoTitulo = new System.Windows.Forms.Label();
            this.label_descricaoDepartamentoSelecionado = new System.Windows.Forms.Label();
            this.listBox_nomesDosDepartamentos = new System.Windows.Forms.ListBox();
            this.panel_header = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.opçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoDepartamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_body.SuspendLayout();
            this.panel_descricao.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel_body.Controls.Add(this.panel_descricao);
            this.panel_body.Controls.Add(this.listBox_nomesDosDepartamentos);
            this.panel_body.Controls.Add(this.panel_header);
            this.panel_body.Controls.Add(this.menuStrip1);
            this.panel_body.Location = new System.Drawing.Point(0, 0);
            this.panel_body.Margin = new System.Windows.Forms.Padding(2);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(978, 513);
            this.panel_body.TabIndex = 0;
            // 
            // panel_descricao
            // 
            this.panel_descricao.Controls.Add(this.label_descricaoTitulo);
            this.panel_descricao.Controls.Add(this.label_descricaoDepartamentoSelecionado);
            this.panel_descricao.Location = new System.Drawing.Point(518, 125);
            this.panel_descricao.Name = "panel_descricao";
            this.panel_descricao.Size = new System.Drawing.Size(445, 221);
            this.panel_descricao.TabIndex = 4;
            // 
            // label_descricaoTitulo
            // 
            this.label_descricaoTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_descricaoTitulo.AutoSize = true;
            this.label_descricaoTitulo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_descricaoTitulo.Location = new System.Drawing.Point(22, 11);
            this.label_descricaoTitulo.Name = "label_descricaoTitulo";
            this.label_descricaoTitulo.Size = new System.Drawing.Size(401, 28);
            this.label_descricaoTitulo.TabIndex = 4;
            this.label_descricaoTitulo.Text = "Descrição do Departamento selecionado:";
            // 
            // label_descricaoDepartamentoSelecionado
            // 
            this.label_descricaoDepartamentoSelecionado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_descricaoDepartamentoSelecionado.Location = new System.Drawing.Point(22, 52);
            this.label_descricaoDepartamentoSelecionado.Name = "label_descricaoDepartamentoSelecionado";
            this.label_descricaoDepartamentoSelecionado.Size = new System.Drawing.Size(391, 159);
            this.label_descricaoDepartamentoSelecionado.TabIndex = 3;
            this.label_descricaoDepartamentoSelecionado.Text = " ";
            // 
            // listBox_nomesDosDepartamentos
            // 
            this.listBox_nomesDosDepartamentos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_nomesDosDepartamentos.FormattingEnabled = true;
            this.listBox_nomesDosDepartamentos.ItemHeight = 25;
            this.listBox_nomesDosDepartamentos.Location = new System.Drawing.Point(12, 124);
            this.listBox_nomesDosDepartamentos.Margin = new System.Windows.Forms.Padding(2);
            this.listBox_nomesDosDepartamentos.Name = "listBox_nomesDosDepartamentos";
            this.listBox_nomesDosDepartamentos.Size = new System.Drawing.Size(500, 379);
            this.listBox_nomesDosDepartamentos.TabIndex = 2;
            this.listBox_nomesDosDepartamentos.SelectedIndexChanged += new System.EventHandler(this.listBox_Departamentos_SelectedIndexChanged);
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.LightGray;
            this.panel_header.Controls.Add(this.label_title);
            this.panel_header.Location = new System.Drawing.Point(0, 36);
            this.panel_header.Margin = new System.Windows.Forms.Padding(2);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(978, 78);
            this.panel_header.TabIndex = 1;
            // 
            // label_title
            // 
            this.label_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(251, 21);
            this.label_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(474, 34);
            this.label_title.TabIndex = 4;
            this.label_title.Text = "Listar Todos os Departamentos";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(978, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // opçõesToolStripMenuItem
            // 
            this.opçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoDepartamentoToolStripMenuItem,
            this.toolStripMenuItem1,
            this.fecharToolStripMenuItem});
            this.opçõesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.opçõesToolStripMenuItem.Name = "opçõesToolStripMenuItem";
            this.opçõesToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.opçõesToolStripMenuItem.Text = "Opções";
            // 
            // novoDepartamentoToolStripMenuItem
            // 
            this.novoDepartamentoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.novoDepartamentoToolStripMenuItem.Name = "novoDepartamentoToolStripMenuItem";
            this.novoDepartamentoToolStripMenuItem.Size = new System.Drawing.Size(278, 34);
            this.novoDepartamentoToolStripMenuItem.Text = "Novo Departamento";
            this.novoDepartamentoToolStripMenuItem.Click += new System.EventHandler(this.novoDepartamentoToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(275, 6);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(278, 34);
            this.fecharToolStripMenuItem.Text = "Fechar";
            this.fecharToolStripMenuItem.Click += new System.EventHandler(this.fecharToolStripMenuItem_Click);
            // 
            // TodosDepartamentosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 513);
            this.Controls.Add(this.panel_body);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1000, 569);
            this.MinimumSize = new System.Drawing.Size(1000, 569);
            this.Name = "TodosDepartamentosView";
            this.Text = "  Controle de Usuário  |  Todos Departamentos";
            this.Load += new System.EventHandler(this.TodosDepartamentosView_Load);
            this.panel_body.ResumeLayout(false);
            this.panel_body.PerformLayout();
            this.panel_descricao.ResumeLayout(false);
            this.panel_descricao.PerformLayout();
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_body;
        private Panel panel_header;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opçõesToolStripMenuItem;
        private Label label_title;
        private ListBox listBox_nomesDosDepartamentos;
        private ToolStripMenuItem novoDepartamentoToolStripMenuItem;
        private ToolStripMenuItem fecharToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private Label label_descricaoDepartamentoSelecionado;
        private Panel panel_descricao;
        private Label label_descricaoTitulo;
    }
}