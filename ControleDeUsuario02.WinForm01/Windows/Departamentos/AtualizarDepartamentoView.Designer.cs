namespace ControleDeUsuario02.WinForm01.Windows.Departamentos {
    partial class AtualizarDepartamentoView {
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
            this.lable_title = new System.Windows.Forms.Label();
            this.panel_body.SuspendLayout();
            this.panel_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_body.Controls.Add(this.panel_header);
            this.panel_body.Location = new System.Drawing.Point(-1, 0);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(799, 452);
            this.panel_body.TabIndex = 0;
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.LightGray;
            this.panel_header.Controls.Add(this.lable_title);
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Margin = new System.Windows.Forms.Padding(2);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(806, 78);
            this.panel_header.TabIndex = 14;
            // 
            // lable_title
            // 
            this.lable_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lable_title.AutoSize = true;
            this.lable_title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lable_title.Location = new System.Drawing.Point(241, 22);
            this.lable_title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lable_title.Name = "lable_title";
            this.lable_title.Size = new System.Drawing.Size(324, 34);
            this.lable_title.TabIndex = 0;
            this.lable_title.Text = "Controle de Usuários";
            // 
            // AtualizarDepartamentoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel_body);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "AtualizarDepartamentoView";
            this.Text = "  Controle de Usuário  |  Atualizar Departamento";
            this.panel_body.ResumeLayout(false);
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_body;
        private Panel panel_header;
        private Label lable_title;
    }
}