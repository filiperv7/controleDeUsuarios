namespace ControleDeUsuario02.WinForm01.Windows.Projetos {
    partial class VerProjetoView {
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
            this.panel_header = new System.Windows.Forms.Panel();
            this.label_title = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel_contedoProjeto = new System.Windows.Forms.Panel();
            this.label_descricaoProjeto = new System.Windows.Forms.Label();
            this.label_idNomeProjeto = new System.Windows.Forms.Label();
            this.panel_busca = new System.Windows.Forms.Panel();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label_digiteId = new System.Windows.Forms.Label();
            this.button_buscar = new System.Windows.Forms.Button();
            this.panel_body.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.panel_contedoProjeto.SuspendLayout();
            this.panel_busca.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.BackColor = System.Drawing.SystemColors.Control;
            this.panel_body.Controls.Add(this.panel_header);
            this.panel_body.Controls.Add(this.progressBar1);
            this.panel_body.Controls.Add(this.panel_contedoProjeto);
            this.panel_body.Controls.Add(this.panel_busca);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 0);
            this.panel_body.Margin = new System.Windows.Forms.Padding(2);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(536, 361);
            this.panel_body.TabIndex = 1;
            // 
            // panel_header
            // 
            this.panel_header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_header.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_header.Controls.Add(this.label_title);
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(2);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(536, 78);
            this.panel_header.TabIndex = 2;
            // 
            // label_title
            // 
            this.label_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_title.Location = new System.Drawing.Point(178, 21);
            this.label_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(181, 34);
            this.label_title.TabIndex = 4;
            this.label_title.Text = "Ver Projeto";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 72);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(536, 10);
            this.progressBar1.TabIndex = 6;
            // 
            // panel_contedoProjeto
            // 
            this.panel_contedoProjeto.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_contedoProjeto.BackColor = System.Drawing.SystemColors.Control;
            this.panel_contedoProjeto.Controls.Add(this.label_descricaoProjeto);
            this.panel_contedoProjeto.Controls.Add(this.label_idNomeProjeto);
            this.panel_contedoProjeto.Location = new System.Drawing.Point(55, 224);
            this.panel_contedoProjeto.Margin = new System.Windows.Forms.Padding(2);
            this.panel_contedoProjeto.Name = "panel_contedoProjeto";
            this.panel_contedoProjeto.Size = new System.Drawing.Size(424, 130);
            this.panel_contedoProjeto.TabIndex = 5;
            // 
            // label_descricaoProjeto
            // 
            this.label_descricaoProjeto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_descricaoProjeto.Location = new System.Drawing.Point(2, 79);
            this.label_descricaoProjeto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_descricaoProjeto.Name = "label_descricaoProjeto";
            this.label_descricaoProjeto.Size = new System.Drawing.Size(418, 25);
            this.label_descricaoProjeto.TabIndex = 5;
            this.label_descricaoProjeto.Text = " ";
            this.label_descricaoProjeto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_idNomeProjeto
            // 
            this.label_idNomeProjeto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_idNomeProjeto.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_idNomeProjeto.Location = new System.Drawing.Point(2, 25);
            this.label_idNomeProjeto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_idNomeProjeto.Name = "label_idNomeProjeto";
            this.label_idNomeProjeto.Size = new System.Drawing.Size(418, 30);
            this.label_idNomeProjeto.TabIndex = 4;
            this.label_idNomeProjeto.Text = " ";
            this.label_idNomeProjeto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_busca
            // 
            this.panel_busca.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel_busca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_busca.Controls.Add(this.textBox_id);
            this.panel_busca.Controls.Add(this.label_digiteId);
            this.panel_busca.Controls.Add(this.button_buscar);
            this.panel_busca.Location = new System.Drawing.Point(125, 89);
            this.panel_busca.Margin = new System.Windows.Forms.Padding(2);
            this.panel_busca.Name = "panel_busca";
            this.panel_busca.Size = new System.Drawing.Size(284, 124);
            this.panel_busca.TabIndex = 3;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(26, 62);
            this.textBox_id.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_id.MaxLength = 100;
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(106, 31);
            this.textBox_id.TabIndex = 1;
            // 
            // label_digiteId
            // 
            this.label_digiteId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_digiteId.AutoSize = true;
            this.label_digiteId.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_digiteId.Location = new System.Drawing.Point(26, 29);
            this.label_digiteId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_digiteId.Name = "label_digiteId";
            this.label_digiteId.Size = new System.Drawing.Size(100, 25);
            this.label_digiteId.TabIndex = 0;
            this.label_digiteId.Text = "Digite o Id:";
            // 
            // button_buscar
            // 
            this.button_buscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_buscar.BackColor = System.Drawing.Color.Transparent;
            this.button_buscar.Location = new System.Drawing.Point(166, 61);
            this.button_buscar.Margin = new System.Windows.Forms.Padding(2);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(89, 34);
            this.button_buscar.TabIndex = 2;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_buscar.UseVisualStyleBackColor = false;
            this.button_buscar.Click += new System.EventHandler(this.button1_buscar_Click);
            // 
            // VerProjetoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 361);
            this.Controls.Add(this.panel_body);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(830, 417);
            this.MinimumSize = new System.Drawing.Size(553, 277);
            this.Name = "VerProjetoView";
            this.Text = "  Controle de Usuário  |  Ver Projeto";
            this.Load += new System.EventHandler(this.VerProjetoView_Load);
            this.panel_body.ResumeLayout(false);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.panel_contedoProjeto.ResumeLayout(false);
            this.panel_busca.ResumeLayout(false);
            this.panel_busca.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_body;
        private Label label_digiteId;
        private Panel panel_header;
        private Panel panel_busca;
        private Button button1_buscar;
        private Label label_title;
        private Label label_idNomeProjeto;
        private Panel panel_contedoProjeto;
        private Label label_descricaoProjeto;
        private TextBox textBox_id;
        private ProgressBar progressBar;
        private Button button_buscar;
        private Panel panel1;
        private ProgressBar progressBar1;
    }
}