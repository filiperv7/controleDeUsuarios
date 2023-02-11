namespace ControleDeUsuario02.WinForm01.Windows.Departamentos {
    partial class NovoDepartamentoView {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.textBox_descricao = new System.Windows.Forms.TextBox();
            this.label_nome = new System.Windows.Forms.Label();
            this.label_descricao = new System.Windows.Forms.Label();
            this.button_salvar = new System.Windows.Forms.Button();
            this.panel_header = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel_header);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(544, 334);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.textBox_nome);
            this.panel2.Controls.Add(this.textBox_descricao);
            this.panel2.Controls.Add(this.label_nome);
            this.panel2.Controls.Add(this.label_descricao);
            this.panel2.Controls.Add(this.button_salvar);
            this.panel2.Location = new System.Drawing.Point(86, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 146);
            this.panel2.TabIndex = 9;
            // 
            // textBox_nome
            // 
            this.textBox_nome.Location = new System.Drawing.Point(86, 10);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(273, 31);
            this.textBox_nome.TabIndex = 6;
            // 
            // textBox_descricao
            // 
            this.textBox_descricao.Location = new System.Drawing.Point(116, 61);
            this.textBox_descricao.Name = "textBox_descricao";
            this.textBox_descricao.Size = new System.Drawing.Size(243, 31);
            this.textBox_descricao.TabIndex = 8;
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_nome.Location = new System.Drawing.Point(10, 10);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(70, 28);
            this.label_nome.TabIndex = 4;
            this.label_nome.Text = "Nome:";
            // 
            // label_descricao
            // 
            this.label_descricao.AutoSize = true;
            this.label_descricao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_descricao.Location = new System.Drawing.Point(10, 61);
            this.label_descricao.Name = "label_descricao";
            this.label_descricao.Size = new System.Drawing.Size(100, 28);
            this.label_descricao.TabIndex = 7;
            this.label_descricao.Text = "Descrição:";
            // 
            // button_salvar
            // 
            this.button_salvar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_salvar.Location = new System.Drawing.Point(260, 101);
            this.button_salvar.Name = "button_salvar";
            this.button_salvar.Size = new System.Drawing.Size(99, 34);
            this.button_salvar.TabIndex = 5;
            this.button_salvar.Text = "Salvar";
            this.button_salvar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_salvar.UseVisualStyleBackColor = true;
            this.button_salvar.Click += new System.EventHandler(this.button_salvar_Click);
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.LightGray;
            this.panel_header.Controls.Add(this.label_title);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(2);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(544, 77);
            this.panel_header.TabIndex = 3;
            // 
            // label_title
            // 
            this.label_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(77, 21);
            this.label_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(391, 34);
            this.label_title.TabIndex = 4;
            this.label_title.Text = "Criar Novo Departamento";
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // NovoDepartamentoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 334);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NovoDepartamentoView";
            this.Text = "  Controle de Usuário  |  Novo Projeto";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel_header;
        private Label label_title;
        private TextBox textBox_nome;
        private Button button_salvar;
        private Label label_nome;
        private Panel panel2;
        private TextBox textBox_descricao;
        private Label label_descricao;
        private ErrorProvider errorProvider_nome;
        private ErrorProvider errorProvider_descricao;
        private ErrorProvider errorProvider;
    }
}