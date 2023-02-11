namespace ControleDeUsuario02.WinForm01.Windows {
    partial class RelatorioReembolsos {
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
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_painelDeControle = new System.Windows.Forms.Panel();
            this.label_escolhaStatus = new System.Windows.Forms.Label();
            this.radioButton_reprovados = new System.Windows.Forms.RadioButton();
            this.radioButton_aprovados = new System.Windows.Forms.RadioButton();
            this.radioButton_criados = new System.Windows.Forms.RadioButton();
            this.dataGridView_relatorioReembolsos = new System.Windows.Forms.DataGridView();
            this.descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoInicial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecoFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kmDeslocamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataCriacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_header = new System.Windows.Forms.Panel();
            this.lable_title = new System.Windows.Forms.Label();
            this.BindingSource_reembolsoDeslocamento = new System.Windows.Forms.BindingSource(this.components);
            this.panel_body.SuspendLayout();
            this.panel_painelDeControle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_relatorioReembolsos)).BeginInit();
            this.panel_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_reembolsoDeslocamento)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.panel_painelDeControle);
            this.panel_body.Controls.Add(this.dataGridView_relatorioReembolsos);
            this.panel_body.Controls.Add(this.panel_header);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 0);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1221, 673);
            this.panel_body.TabIndex = 0;
            // 
            // panel_painelDeControle
            // 
            this.panel_painelDeControle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_painelDeControle.Controls.Add(this.label_escolhaStatus);
            this.panel_painelDeControle.Controls.Add(this.radioButton_reprovados);
            this.panel_painelDeControle.Controls.Add(this.radioButton_aprovados);
            this.panel_painelDeControle.Controls.Add(this.radioButton_criados);
            this.panel_painelDeControle.Location = new System.Drawing.Point(145, 85);
            this.panel_painelDeControle.Name = "panel_painelDeControle";
            this.panel_painelDeControle.Size = new System.Drawing.Size(930, 123);
            this.panel_painelDeControle.TabIndex = 4;
            // 
            // label_escolhaStatus
            // 
            this.label_escolhaStatus.AutoSize = true;
            this.label_escolhaStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_escolhaStatus.Location = new System.Drawing.Point(220, 15);
            this.label_escolhaStatus.Name = "label_escolhaStatus";
            this.label_escolhaStatus.Size = new System.Drawing.Size(500, 34);
            this.label_escolhaStatus.TabIndex = 4;
            this.label_escolhaStatus.Text = "Escolha o Estados do Reembolso";
            // 
            // radioButton_reprovados
            // 
            this.radioButton_reprovados.AutoSize = true;
            this.radioButton_reprovados.Location = new System.Drawing.Point(653, 71);
            this.radioButton_reprovados.Name = "radioButton_reprovados";
            this.radioButton_reprovados.Size = new System.Drawing.Size(132, 29);
            this.radioButton_reprovados.TabIndex = 3;
            this.radioButton_reprovados.TabStop = true;
            this.radioButton_reprovados.Tag = "2";
            this.radioButton_reprovados.Text = "Reprovados";
            this.radioButton_reprovados.UseVisualStyleBackColor = true;
            this.radioButton_reprovados.CheckedChanged += new System.EventHandler(this.radioButton_reprovados_CheckedChanged);
            // 
            // radioButton_aprovados
            // 
            this.radioButton_aprovados.AutoSize = true;
            this.radioButton_aprovados.Location = new System.Drawing.Point(397, 71);
            this.radioButton_aprovados.Name = "radioButton_aprovados";
            this.radioButton_aprovados.Size = new System.Drawing.Size(125, 29);
            this.radioButton_aprovados.TabIndex = 2;
            this.radioButton_aprovados.TabStop = true;
            this.radioButton_aprovados.Tag = "1";
            this.radioButton_aprovados.Text = "Aprovados";
            this.radioButton_aprovados.UseVisualStyleBackColor = true;
            this.radioButton_aprovados.CheckedChanged += new System.EventHandler(this.radioButton_aprovados_CheckedChanged);
            // 
            // radioButton_criados
            // 
            this.radioButton_criados.AutoSize = true;
            this.radioButton_criados.Location = new System.Drawing.Point(169, 71);
            this.radioButton_criados.Name = "radioButton_criados";
            this.radioButton_criados.Size = new System.Drawing.Size(97, 29);
            this.radioButton_criados.TabIndex = 1;
            this.radioButton_criados.TabStop = true;
            this.radioButton_criados.Tag = "0";
            this.radioButton_criados.Text = "Criados";
            this.radioButton_criados.UseVisualStyleBackColor = true;
            this.radioButton_criados.CheckedChanged += new System.EventHandler(this.radioButton_criados_CheckedChanged);
            // 
            // dataGridView_relatorioReembolsos
            // 
            this.dataGridView_relatorioReembolsos.AllowUserToAddRows = false;
            this.dataGridView_relatorioReembolsos.AllowUserToDeleteRows = false;
            this.dataGridView_relatorioReembolsos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_relatorioReembolsos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_relatorioReembolsos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_relatorioReembolsos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descricao,
            this.enderecoInicial,
            this.enderecoFinal,
            this.kmDeslocamento,
            this.dataCriacao,
            this.Status});
            this.dataGridView_relatorioReembolsos.Location = new System.Drawing.Point(14, 217);
            this.dataGridView_relatorioReembolsos.Name = "dataGridView_relatorioReembolsos";
            this.dataGridView_relatorioReembolsos.ReadOnly = true;
            this.dataGridView_relatorioReembolsos.RowHeadersWidth = 62;
            this.dataGridView_relatorioReembolsos.RowTemplate.Height = 33;
            this.dataGridView_relatorioReembolsos.Size = new System.Drawing.Size(1189, 439);
            this.dataGridView_relatorioReembolsos.TabIndex = 4;
            // 
            // descricao
            // 
            this.descricao.DataPropertyName = "Descricao";
            this.descricao.FillWeight = 107.8544F;
            this.descricao.HeaderText = "Descrição";
            this.descricao.MinimumWidth = 8;
            this.descricao.Name = "descricao";
            this.descricao.ReadOnly = true;
            // 
            // enderecoInicial
            // 
            this.enderecoInicial.DataPropertyName = "EnderecoInicial";
            this.enderecoInicial.FillWeight = 131.7519F;
            this.enderecoInicial.HeaderText = "Endereço Inicial";
            this.enderecoInicial.MinimumWidth = 8;
            this.enderecoInicial.Name = "enderecoInicial";
            this.enderecoInicial.ReadOnly = true;
            // 
            // enderecoFinal
            // 
            this.enderecoFinal.DataPropertyName = "EnderecoFinal";
            this.enderecoFinal.FillWeight = 142.3478F;
            this.enderecoFinal.HeaderText = "Endereço Final";
            this.enderecoFinal.MinimumWidth = 8;
            this.enderecoFinal.Name = "enderecoFinal";
            this.enderecoFinal.ReadOnly = true;
            // 
            // kmDeslocamento
            // 
            this.kmDeslocamento.DataPropertyName = "KmDeslocado";
            this.kmDeslocamento.FillWeight = 30.68182F;
            this.kmDeslocamento.HeaderText = "Km\'s";
            this.kmDeslocamento.MinimumWidth = 8;
            this.kmDeslocamento.Name = "kmDeslocamento";
            this.kmDeslocamento.ReadOnly = true;
            // 
            // dataCriacao
            // 
            this.dataCriacao.DataPropertyName = "DataCriacao";
            this.dataCriacao.FillWeight = 88.25422F;
            this.dataCriacao.HeaderText = "Data";
            this.dataCriacao.MinimumWidth = 8;
            this.dataCriacao.Name = "dataCriacao";
            this.dataCriacao.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.FillWeight = 99.10979F;
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 8;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // panel_header
            // 
            this.panel_header.BackColor = System.Drawing.Color.LightGray;
            this.panel_header.Controls.Add(this.lable_title);
            this.panel_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_header.Location = new System.Drawing.Point(0, 0);
            this.panel_header.Name = "panel_header";
            this.panel_header.Size = new System.Drawing.Size(1221, 77);
            this.panel_header.TabIndex = 2;
            // 
            // lable_title
            // 
            this.lable_title.AutoSize = true;
            this.lable_title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lable_title.Location = new System.Drawing.Point(536, 21);
            this.lable_title.Name = "lable_title";
            this.lable_title.Size = new System.Drawing.Size(149, 34);
            this.lable_title.TabIndex = 3;
            this.lable_title.Text = "Relatório";
            // 
            // BindingSource_reembolsoDeslocamento
            // 
            this.BindingSource_reembolsoDeslocamento.AllowNew = false;
            this.BindingSource_reembolsoDeslocamento.DataSource = typeof(ControleDeUsuario02.WinForm01.Model.ReembolsoDeslocamentoModel);
            // 
            // RelatorioReembolsos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 673);
            this.Controls.Add(this.panel_body);
            this.Name = "RelatorioReembolsos";
            this.Text = "Relatório de Reembolsos";
            this.Load += new System.EventHandler(this.RelatorioReembolsos_Load);
            this.panel_body.ResumeLayout(false);
            this.panel_painelDeControle.ResumeLayout(false);
            this.panel_painelDeControle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_relatorioReembolsos)).EndInit();
            this.panel_header.ResumeLayout(false);
            this.panel_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource_reembolsoDeslocamento)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_body;
        private DataGridView dataGridView_relatorioReembolsos;
        private Panel panel_header;
        private Label lable_title;
        private Panel panel_painelDeControle;
        private Label label_escolhaStatus;
        private RadioButton radioButton_reprovados;
        private RadioButton radioButton_aprovados;
        private RadioButton radioButton_criados;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn descricao;
        private DataGridViewTextBoxColumn enderecoInicial;
        private DataGridViewTextBoxColumn enderecoFinal;
        private DataGridViewTextBoxColumn kmDeslocamento;
        private DataGridViewTextBoxColumn dataCriacao;
        private BindingSource BindingSource_reembolsoDeslocamento;
    }
}