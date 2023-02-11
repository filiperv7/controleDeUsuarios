namespace ControleDeUsuario02.WinForm01.Windows {
    partial class ReembolsoDeslocamentoView {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_enviarSolicitacao = new System.Windows.Forms.Button();
            this.label_descricao = new System.Windows.Forms.Label();
            this.label_enderecoFinal = new System.Windows.Forms.Label();
            this.textBox_descricao = new System.Windows.Forms.TextBox();
            this.textBox_enderecoFinal = new System.Windows.Forms.TextBox();
            this.textBox_enderecoInicial = new System.Windows.Forms.TextBox();
            this.label_enderecoInicial = new System.Windows.Forms.Label();
            this.panel_header = new System.Windows.Forms.Panel();
            this.lable_title = new System.Windows.Forms.Label();
            this.panel_body.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.panel1);
            this.panel_body.Controls.Add(this.panel_header);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 0);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(800, 450);
            this.panel_body.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_enviarSolicitacao);
            this.panel1.Controls.Add(this.label_descricao);
            this.panel1.Controls.Add(this.label_enderecoFinal);
            this.panel1.Controls.Add(this.textBox_descricao);
            this.panel1.Controls.Add(this.textBox_enderecoFinal);
            this.panel1.Controls.Add(this.textBox_enderecoInicial);
            this.panel1.Controls.Add(this.label_enderecoInicial);
            this.panel1.Location = new System.Drawing.Point(86, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 297);
            this.panel1.TabIndex = 8;
            // 
            // button_enviarSolicitacao
            // 
            this.button_enviarSolicitacao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_enviarSolicitacao.Location = new System.Drawing.Point(479, 238);
            this.button_enviarSolicitacao.Name = "button_enviarSolicitacao";
            this.button_enviarSolicitacao.Size = new System.Drawing.Size(122, 43);
            this.button_enviarSolicitacao.TabIndex = 4;
            this.button_enviarSolicitacao.Text = "Enviar";
            this.button_enviarSolicitacao.UseVisualStyleBackColor = true;
            this.button_enviarSolicitacao.Click += new System.EventHandler(this.button_enviarSolicitacao_Click);
            // 
            // label_descricao
            // 
            this.label_descricao.AutoSize = true;
            this.label_descricao.Location = new System.Drawing.Point(16, 113);
            this.label_descricao.Name = "label_descricao";
            this.label_descricao.Size = new System.Drawing.Size(206, 25);
            this.label_descricao.TabIndex = 3;
            this.label_descricao.Text = "Descrição da Solicitação:";
            // 
            // label_enderecoFinal
            // 
            this.label_enderecoFinal.AutoSize = true;
            this.label_enderecoFinal.Location = new System.Drawing.Point(312, 17);
            this.label_enderecoFinal.Name = "label_enderecoFinal";
            this.label_enderecoFinal.Size = new System.Drawing.Size(180, 25);
            this.label_enderecoFinal.TabIndex = 7;
            this.label_enderecoFinal.Text = "Endereço de Destino:";
            // 
            // textBox_descricao
            // 
            this.textBox_descricao.Location = new System.Drawing.Point(16, 141);
            this.textBox_descricao.Multiline = true;
            this.textBox_descricao.Name = "textBox_descricao";
            this.textBox_descricao.Size = new System.Drawing.Size(586, 90);
            this.textBox_descricao.TabIndex = 3;
            // 
            // textBox_enderecoFinal
            // 
            this.textBox_enderecoFinal.Location = new System.Drawing.Point(312, 47);
            this.textBox_enderecoFinal.Multiline = true;
            this.textBox_enderecoFinal.Name = "textBox_enderecoFinal";
            this.textBox_enderecoFinal.Size = new System.Drawing.Size(290, 56);
            this.textBox_enderecoFinal.TabIndex = 2;
            // 
            // textBox_enderecoInicial
            // 
            this.textBox_enderecoInicial.Location = new System.Drawing.Point(16, 47);
            this.textBox_enderecoInicial.Multiline = true;
            this.textBox_enderecoInicial.Name = "textBox_enderecoInicial";
            this.textBox_enderecoInicial.Size = new System.Drawing.Size(290, 56);
            this.textBox_enderecoInicial.TabIndex = 1;
            // 
            // label_enderecoInicial
            // 
            this.label_enderecoInicial.AutoSize = true;
            this.label_enderecoInicial.Location = new System.Drawing.Point(16, 17);
            this.label_enderecoInicial.Name = "label_enderecoInicial";
            this.label_enderecoInicial.Size = new System.Drawing.Size(173, 25);
            this.label_enderecoInicial.TabIndex = 5;
            this.label_enderecoInicial.Text = "Endereço de Partida:";
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.LightGray;
            this.panel_header.Controls.Add(this.lable_title);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(800, 77);
            this.panel_header.TabIndex = 1;
            // 
            // lable_title
            // 
            this.lable_title.AutoSize = true;
            this.lable_title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lable_title.Location = new System.Drawing.Point(194, 20);
            this.lable_title.Name = "lable_title";
            this.lable_title.Size = new System.Drawing.Size(395, 34);
            this.lable_title.TabIndex = 3;
            this.lable_title.Text = "Solicitação de Reembolso";
            // 
            // ReembolsoDeslocamentoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_body);
            this.MaximumSize = new System.Drawing.Size(822, 506);
            this.MinimumSize = new System.Drawing.Size(822, 506);
            this.Name = "ReembolsoDeslocamentoView";
            this.Text = "Solicitação de Reembolso de Deslocamento";
            this.panel_body.ResumeLayout(false);
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
        private Label label_enderecoInicial;
        private TextBox textBox_enderecoInicial;
        private Label label_descricao;
        private TextBox textBox_descricao;
        private Panel panel1;
        private Label label_enderecoFinal;
        private TextBox textBox_enderecoFinal;
        private Button button_enviarSolicitacao;
    }
}