namespace ControleDeUsuario02.WinForm01.Windows.Usuarios {
    partial class CardUsuarioCompleto {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.pictureBox_avatar = new System.Windows.Forms.PictureBox();
            this.panel_body = new System.Windows.Forms.Panel();
            this.label_departamentos = new System.Windows.Forms.Label();
            this.label_projeto = new System.Windows.Forms.Label();
            this.label_usuario = new System.Windows.Forms.Label();
            this.panel_avatar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar)).BeginInit();
            this.panel_body.SuspendLayout();
            this.panel_avatar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_avatar
            // 
            this.pictureBox_avatar.Image = global::ControleDeUsuario02.WinForm01.Imagens.user;
            this.pictureBox_avatar.Location = new System.Drawing.Point(15, 10);
            this.pictureBox_avatar.Name = "pictureBox_avatar";
            this.pictureBox_avatar.Size = new System.Drawing.Size(100, 100);
            this.pictureBox_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_avatar.TabIndex = 0;
            this.pictureBox_avatar.TabStop = false;
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.label_departamentos);
            this.panel_body.Controls.Add(this.label_projeto);
            this.panel_body.Controls.Add(this.label_usuario);
            this.panel_body.Controls.Add(this.panel_avatar);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 0);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(875, 121);
            this.panel_body.TabIndex = 1;
            // 
            // label_departamentos
            // 
            this.label_departamentos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_departamentos.Location = new System.Drawing.Point(456, 64);
            this.label_departamentos.Name = "label_departamentos";
            this.label_departamentos.Padding = new System.Windows.Forms.Padding(2);
            this.label_departamentos.Size = new System.Drawing.Size(288, 36);
            this.label_departamentos.TabIndex = 3;
            this.label_departamentos.Text = "Departamentos";
            this.label_departamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_departamentos.MouseEnter += new System.EventHandler(this.label_departamentos_MouseEnter);
            this.label_departamentos.MouseLeave += new System.EventHandler(this.label_departamentos_MouseLeave);
            // 
            // label_projeto
            // 
            this.label_projeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_projeto.Location = new System.Drawing.Point(168, 64);
            this.label_projeto.Name = "label_projeto";
            this.label_projeto.Padding = new System.Windows.Forms.Padding(2);
            this.label_projeto.Size = new System.Drawing.Size(267, 36);
            this.label_projeto.TabIndex = 2;
            this.label_projeto.Text = "Projeto";
            this.label_projeto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label_projeto.Click += new System.EventHandler(this.label_projeto_Click);
            this.label_projeto.MouseEnter += new System.EventHandler(this.label_projeto_MouseEnter);
            this.label_projeto.MouseLeave += new System.EventHandler(this.label_projeto_MouseLeave);
            // 
            // label_usuario
            // 
            this.label_usuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_usuario.Location = new System.Drawing.Point(168, 21);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(576, 38);
            this.label_usuario.TabIndex = 1;
            this.label_usuario.Text = "Usuário";
            // 
            // panel_avatar
            // 
            this.panel_avatar.BackColor = System.Drawing.Color.LightBlue;
            this.panel_avatar.Controls.Add(this.pictureBox_avatar);
            this.panel_avatar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_avatar.Location = new System.Drawing.Point(0, 0);
            this.panel_avatar.Name = "panel_avatar";
            this.panel_avatar.Size = new System.Drawing.Size(130, 121);
            this.panel_avatar.TabIndex = 0;
            // 
            // CardUsuarioCompleto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_body);
            this.Name = "CardUsuarioCompleto";
            this.Size = new System.Drawing.Size(875, 121);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_avatar)).EndInit();
            this.panel_body.ResumeLayout(false);
            this.panel_avatar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox_avatar;
        private Panel panel_body;
        private Label label_departamentos;
        private Label label_projeto;
        private Label label_usuario;
        private Panel panel_avatar;
    }
}
