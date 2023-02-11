using ControleDeUsuario02.WinForm01.Controllers;
using ControleDeUsuario02.WinForm01.Model;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;

namespace ControleDeUsuario02.WinForm01.Windows {
    public partial class ControlesVisuaisView : Form {
        public ControlesVisuaisView() {
            InitializeComponent();
        }

        private List<FullUserModel> _usuarios;

        public List<FullUserModel> Usuarios {
            get { return _usuarios; }
            set { _usuarios = value; }
        }

        private void ControlesVisuaisView_Load(object sender, EventArgs e) {
            label_data.Text = string.Format(Mensagens.DiaEMes, monthCalendar_data.TodayDate.ToShortDateString());

            IniciarBarraDeProgresso();
        }

        private void IniciarBarraDeProgresso() {
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.MarqueeAnimationSpeed = 30;
            Application.DoEvents();
        }

        private void FinalizarBarraDeProgresso() {
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.MarqueeAnimationSpeed = 0;
            Application.DoEvents();
        }

        private void ControlesVisuaisView_HelpButtonClicked(object sender, System.ComponentModel.CancelEventArgs e) {
            Help.ShowHelp(this, string.Format(Mensagens.HelpPage));
        }


        #region  ----- PRIMEIROS

        private void ToolStripMenuItem_mudarFonteDoTítulo_Click(object sender, EventArgs e) {
            fontDialog_title.Font = label_title.Font;
            DialogResult dialogResult = fontDialog_title.ShowDialog();

            if (dialogResult == DialogResult.OK) {
                label_title.Font = fontDialog_title.Font;
            }
        } 

        private void mudarCorDoTítuloToolStripMenuItem_Click(object sender, EventArgs e) {
            colorDialog_title.Color = label_title.ForeColor;
            DialogResult dialogResult = colorDialog_title.ShowDialog();

            if (dialogResult == DialogResult.OK) {
                label_title.ForeColor = colorDialog_title.Color;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e) {
            label_numero.Text = trackBar.Value.ToString();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e) {
            label_textoDoRichTextBox.Text = richTextBox.Text;
        }

        private void monthCalendar_data_DateSelected(object sender, DateRangeEventArgs e) {
            label_data.Text = string.Format(Mensagens.DiaEMes, e.Start.ToShortDateString());
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Process.Start(string.Format(Mensagens.GoogleChrome), "http://google.com");
        }

        private void button_openFiles_Click(object sender, EventArgs e) {
            folderBrowserDialog.ShowDialog();

            listBox_arquivos.Items.Clear();

            string foldername = folderBrowserDialog.SelectedPath;
            if (foldername != string.Empty) {
                foreach (var item in Directory.GetFiles(foldername)) {
                    listBox_arquivos.Items.Add(item);
                }
            }
        }
        #endregion

        
        #region  ----- PRINTS

        private void printDocument_prints_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e) {
            e.Graphics.DrawString(richTextBox_prints.Text, new Font("Arial", 20), Brushes.Black, 12, 20);
        }

        private void button_configuracoesPagina_Click(object sender, EventArgs e) {
            pageSetupDialog_print.ShowDialog();
        }

        private void button_previa_Click(object sender, EventArgs e) {
            printPreviewDialog_prints.ShowDialog();
        }

        private void button_imprimir_Click(object sender, EventArgs e) {
            printDialog_prints.ShowDialog();
        }
        #endregion

        
        #region  ----- MAIS ALGUNS

        private void tabControl_Selected(object sender, TabControlEventArgs e) {
            if (tabControl.SelectedIndex == 2) {
                listBox_origem.Items.Clear();
                listBox_destino.Items.Clear();

                Usuarios = UserController.GetAllComplete();

                if (Usuarios != null) {
                    foreach (var item in Usuarios) {
                        listBox_origem.Items.Add(item.FirstName);

                        Thread.Sleep(100);
                    }
                } else {
                    MessageBox.Show(string.Format(Mensagens.ErroAoAcessarBD), string.Format(Mensagens.Erro), MessageBoxButtons.OK, MessageBoxIcon.Error);

                    listBox_origem.Items.Add(string.Format(Mensagens.SemAcessoBanco));
                }
            }
        }

        private void button_paraDireita_Click(object sender, EventArgs e) {
            if (listBox_origem.SelectedItems.Count == 1) {
                listBox_destino.Items.Add(listBox_origem.SelectedItem);

                int i = listBox_origem.SelectedIndex;
                listBox_origem.Items.RemoveAt(i);
            }
        }

        private void button_paraEsquera_Click(object sender, EventArgs e) {
            if (listBox_destino.SelectedItems.Count == 1) {
                listBox_origem.Items.Add(listBox_destino.SelectedItem);

                int i = listBox_destino.SelectedIndex;
                listBox_destino.Items.RemoveAt(i);
            }
        }

        ArrayList itens = new ArrayList();
        private void button_multiplosParaDireita_Click(object sender, EventArgs e) {
            if (listBox_origem.SelectedItems.Count > 1) {
                itens.Clear();
                
                foreach (var item in listBox_origem.SelectedItems) {
                    listBox_destino.Items.Add(item);

                    itens.Add(item);
                }

                for (int i = 0; i < itens.Count; i++) {
                    listBox_origem.Items.Remove(itens[i]);
                }
            }
        }

        private void button_multiplosParaEsquerda_Click(object sender, EventArgs e) {
            if (listBox_destino.SelectedItems.Count > 1) {
                itens.Clear();

                foreach (var item in listBox_destino.SelectedItems) {
                    listBox_origem.Items.Add(item);

                    itens.Add(item);
                }

                for (int i = 0; i < itens.Count; i++) {
                    listBox_destino.Items.Remove(itens[i]);
                }
            }
        }

        private void fileSystemWatcher_Created(object sender, FileSystemEventArgs e) {
            toolStripStatusLabel_fileSystemWatcher.Text = $">  {e.Name} criado.";
        }

        private void fileSystemWatcher_Renamed(object sender, RenamedEventArgs e) {
            toolStripStatusLabel_fileSystemWatcher.Text = $">  {e.OldName} renomeado para {e.Name}.";
        }

        private void fileSystemWatcher_Deleted(object sender, FileSystemEventArgs e) {
            toolStripStatusLabel_fileSystemWatcher.Text = $">  {e.Name} deletado.";
        }
        #endregion


        #region  ----- OUTROS
        string arquivoGeral = string.Empty;
        private void openToolStripButton_Click(object sender, EventArgs e) {
            var fileDialog = openFileDialog.ShowDialog();

            if (fileDialog == DialogResult.OK) {
                arquivoGeral = openFileDialog.FileName;

                backgroundWorker.RunWorkerAsync(arquivoGeral);
            }
        }

        private void button_cancelar_Click(object sender, EventArgs e) {
            backgroundWorker.CancelAsync();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e) {
            StringBuilder conteudo = new StringBuilder();

            var arquivo = (string)e.Argument;

            try {
                var inicio = DateTime.Now;

                StreamReader reader = new StreamReader(arquivo);
                string line;
                int lineCount = 0;

                while ((line = reader.ReadLine()) != null) {
                    if (backgroundWorker.CancellationPending) {
                        conteudo.AppendLine("Cancelado");

                        break;
                    }

                    lineCount++;
                }

                var final = DateTime.Now;

                /*string[] linhas = File.ReadAllLines(arquivo);

                for (int i = 0; i < linhas.Length; i++) {
                    if (backgroundWorker.CancellationPending) {
                        e.Cancel = true;
                    } else {
                        var valueProgressBar = linhas.Length;

                        conteudo.AppendLine(linhas[i]);

                        backgroundWorker1.ReportProgress(i, valueProgressBar);
                    }
                }
                e.Result = conteudo;*/

                conteudo.AppendLine(string.Format("Tempo: {0}", (final - inicio).TotalSeconds));
                conteudo.AppendLine(string.Format("Quantidade de linhas: {0}", lineCount));

                e.Result = conteudo;
            } catch (Exception ex) {
                MessageBox.Show($"Erro ao abrir o arquivo {ex.Message}");
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            richTextBox_contagemLinhas.Text += e.Result.ToString() + Environment.NewLine;
        }

        private void saveToolStripButton_Click(object sender, EventArgs e) {
            if (arquivoGeral != string.Empty) {
                SalvarArquivo();

                MessageBox.Show("Aruqivo Salvo!");
            } else {
                MessageBox.Show("Primeiro abra e altere algum arquivo!");
            }
        }

        public void SalvarArquivo() {
            using (StreamWriter file = new StreamWriter(arquivoGeral)) {
                foreach (string linha in richTextBox_contagemLinhas.Lines) {
                    file.WriteLine(linha);
                }
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e) {
            arquivoGeral = string.Empty;
            richTextBox_contagemLinhas.Text = string.Empty;
        }

        private void toolStripButton_notePad_Click(object sender, EventArgs e) {
            if (arquivoGeral != string.Empty) {
                Process.Start("notepad", arquivoGeral);
            } else {
                MessageBox.Show("Primeiro abra um arquivo!");
            }
        }

        #endregion


        #region  ----- PROGRESS CHANGED

        private void toolStripButton2_Click(object sender, EventArgs e) {
            string arquivo = string.Empty;

            var fileDialog = openFileDialog.ShowDialog();

            if (fileDialog == DialogResult.OK) {
                arquivo = openFileDialog.FileName;

                backgroundWorker1.RunWorkerAsync(arquivo);
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
            var conteudo = new StringBuilder();

            var arquivo = e.Argument as string;

            try {

                var inicio = DateTime.Now;

                string[] linhas = File.ReadAllLines(arquivo);

                var final = DateTime.Now;

                for (int i = 0; i < linhas.Length; i++) {
                    var valueProgressBar = linhas.Length;

                    conteudo.AppendLine(linhas[i]);

                    backgroundWorker1.ReportProgress(i, valueProgressBar);
                }

                backgroundWorker1.ReportProgress(linhas.Length, linhas.Length);

                e.Result = conteudo;
            } catch (Exception ex) {
                MessageBox.Show($"Erro ao abrir o arquivo {ex.Message}");
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            progressBar1.Maximum = Convert.ToInt32(e.UserState);

            progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            richTextBox1.Text = e.Result.ToString();
        }

        #endregion


    }
}
