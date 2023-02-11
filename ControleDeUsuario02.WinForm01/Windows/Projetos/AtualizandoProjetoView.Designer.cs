namespace ControleDeUsuario02.WinForm01.Windows.Projetos {
    partial class AtualizandoProjetoView {
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_atualizar = new System.Windows.Forms.Button();
            this.textBox_descricao = new System.Windows.Forms.TextBox();
            this.label_descricao = new System.Windows.Forms.Label();
            this.textBox_nome = new System.Windows.Forms.TextBox();
            this.label_nome = new System.Windows.Forms.Label();
            this.panel_header = new System.Windows.Forms.Panel();
            this.lable_title = new System.Windows.Forms.Label();
            this.panel_body.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.panel2);
            this.panel_body.Controls.Add(this.panel_header);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 0);
            this.panel_body.Margin = new System.Windows.Forms.Padding(2);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(371, 296);
            this.panel_body.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.Controls.Add(this.button_atualizar);
            this.panel2.Controls.Add(this.textBox_descricao);
            this.panel2.Controls.Add(this.label_descricao);
            this.panel2.Controls.Add(this.textBox_nome);
            this.panel2.Controls.Add(this.label_nome);
            this.panel2.Location = new System.Drawing.Point(42, 82);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 186);
            this.panel2.TabIndex = 4;
            // 
            // button_atualizar
            // 
            this.button_atualizar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_atualizar.Location = new System.Drawing.Point(153, 134);
            this.button_atualizar.Margin = new System.Windows.Forms.Padding(2);
            this.button_atualizar.Name = "button_atualizar";
            this.button_atualizar.Size = new System.Drawing.Size(98, 30);
            this.button_atualizar.TabIndex = 9;
            this.button_atualizar.Text = "Atualizar";
            this.button_atualizar.UseVisualStyleBackColor = true;
            this.button_atualizar.Click += new System.EventHandler(this.button_atualizar_Click);
            // 
            // textBox_descricao
            // 
            this.textBox_descricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_descricao.Location = new System.Drawing.Point(106, 69);
            this.textBox_descricao.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_descricao.Multiline = true;
            this.textBox_descricao.Name = "textBox_descricao";
            this.textBox_descricao.Size = new System.Drawing.Size(145, 51);
            this.textBox_descricao.TabIndex = 8;
            // 
            // label_descricao
            // 
            this.label_descricao.AutoSize = true;
            this.label_descricao.Location = new System.Drawing.Point(30, 70);
            this.label_descricao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_descricao.Name = "label_descricao";
            this.label_descricao.Size = new System.Drawing.Size(77, 20);
            this.label_descricao.TabIndex = 7;
            this.label_descricao.Text = "Descrição:";
            // 
            // textBox_nome
            // 
            this.textBox_nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_nome.Location = new System.Drawing.Point(106, 26);
            this.textBox_nome.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_nome.Name = "textBox_nome";
            this.textBox_nome.Size = new System.Drawing.Size(145, 27);
            this.textBox_nome.TabIndex = 6;
            // 
            // label_nome
            // 
            this.label_nome.AutoSize = true;
            this.label_nome.Location = new System.Drawing.Point(30, 27);
            this.label_nome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_nome.Name = "label_nome";
            this.label_nome.Size = new System.Drawing.Size(53, 20);
            this.label_nome.TabIndex = 5;
            this.label_nome.Text = "Nome:";
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.LightGray;
            this.panel_header.Controls.Add(this.lable_title);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(2);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(371, 62);
            this.panel_header.TabIndex = 2;
            // 
            // lable_title
            // 
            this.lable_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lable_title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lable_title.Location = new System.Drawing.Point(30, 17);
            this.lable_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable_title.Name = "lable_title";
            this.lable_title.Size = new System.Drawing.Size(310, 27);
            this.lable_title.TabIndex = 3;
            this.lable_title.Text = "Atualizar Projeto";
            this.lable_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AtualizandoProjetoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 296);
            this.Controls.Add(this.panel_body);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(389, 385);
            this.MinimumSize = new System.Drawing.Size(389, 343);
            this.Name = "AtualizandoProjetoView";
            this.Text = "Atualizar Projeto";
            this.Load += new System.EventHandler(this.AtualizandoProjetoView_Load);
            this.panel_body.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_body;
        private Panel panel2;
        private TextBox textBox_descricao;
        private Label label_descricao;
        private TextBox textBox_nome;
        private Label label_nome;
        private Panel panel_header;
        private Label lable_title;
        private Button button_atualizar;
    }
}