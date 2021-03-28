using System.Drawing;

namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelPath = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.labelServidor = new System.Windows.Forms.Label();
            this.textBoxServidor = new System.Windows.Forms.TextBox();
            this.labelSenha = new System.Windows.Forms.Label();
            this.textBoxSenha = new System.Windows.Forms.TextBox();
            this.labelNomePrograma = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNomeArquivo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDataBase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTempo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCaminhoMySQL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonStart.Location = new System.Drawing.Point(142, 456);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(279, 54);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Iniciar Backup";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(140, 160);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(396, 22);
            this.textBoxUsuario.TabIndex = 1;
            this.textBoxUsuario.Text = "root";
            this.textBoxUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.BackColor = System.Drawing.Color.Silver;
            this.labelUsuario.Location = new System.Drawing.Point(62, 164);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(74, 17);
            this.labelUsuario.TabIndex = 2;
            this.labelUsuario.Text = "USUÁRIO:";
            this.labelUsuario.UseWaitCursor = true;
            // 
            // labelPath
            // 
            this.labelPath.AutoSize = true;
            this.labelPath.BackColor = System.Drawing.Color.Silver;
            this.labelPath.Location = new System.Drawing.Point(9, 363);
            this.labelPath.Name = "labelPath";
            this.labelPath.Size = new System.Drawing.Size(125, 17);
            this.labelPath.TabIndex = 4;
            this.labelPath.Text = "CAMINHO SALVO:";
            this.labelPath.UseWaitCursor = true;
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(140, 360);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(396, 22);
            this.textBoxPath.TabIndex = 3;
            this.textBoxPath.Text = "C:\\Backups\\FiveM\\";
            this.textBoxPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelServidor
            // 
            this.labelServidor.AutoSize = true;
            this.labelServidor.BackColor = System.Drawing.Color.Silver;
            this.labelServidor.Location = new System.Drawing.Point(53, 124);
            this.labelServidor.Name = "labelServidor";
            this.labelServidor.Size = new System.Drawing.Size(83, 17);
            this.labelServidor.TabIndex = 6;
            this.labelServidor.Text = "SERVIDOR:";
            this.labelServidor.UseWaitCursor = true;
            // 
            // textBoxServidor
            // 
            this.textBoxServidor.Location = new System.Drawing.Point(140, 120);
            this.textBoxServidor.Name = "textBoxServidor";
            this.textBoxServidor.Size = new System.Drawing.Size(396, 22);
            this.textBoxServidor.TabIndex = 5;
            this.textBoxServidor.Text = "localhost";
            this.textBoxServidor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.BackColor = System.Drawing.Color.Silver;
            this.labelSenha.Location = new System.Drawing.Point(77, 203);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(59, 17);
            this.labelSenha.TabIndex = 8;
            this.labelSenha.Text = "SENHA:";
            this.labelSenha.UseWaitCursor = true;
            // 
            // textBoxSenha
            // 
            this.textBoxSenha.Location = new System.Drawing.Point(140, 200);
            this.textBoxSenha.Name = "textBoxSenha";
            this.textBoxSenha.Size = new System.Drawing.Size(396, 22);
            this.textBoxSenha.TabIndex = 7;
            this.textBoxSenha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelNomePrograma
            // 
            this.labelNomePrograma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNomePrograma.AutoSize = true;
            this.labelNomePrograma.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold);
            this.labelNomePrograma.Location = new System.Drawing.Point(115, 28);
            this.labelNomePrograma.Name = "labelNomePrograma";
            this.labelNomePrograma.Size = new System.Drawing.Size(389, 59);
            this.labelNomePrograma.TabIndex = 9;
            this.labelNomePrograma.Text = "BACKUPZEIRO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(14, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "NOME ARQUIVO:";
            this.label1.UseWaitCursor = true;
            // 
            // textBoxNomeArquivo
            // 
            this.textBoxNomeArquivo.Location = new System.Drawing.Point(140, 320);
            this.textBoxNomeArquivo.Name = "textBoxNomeArquivo";
            this.textBoxNomeArquivo.Size = new System.Drawing.Size(396, 22);
            this.textBoxNomeArquivo.TabIndex = 10;
            this.textBoxNomeArquivo.Text = "backup";
            this.textBoxNomeArquivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(51, 245);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "DATABASE:";
            this.label2.UseWaitCursor = true;
            // 
            // textBoxDataBase
            // 
            this.textBoxDataBase.Location = new System.Drawing.Point(140, 240);
            this.textBoxDataBase.Name = "textBoxDataBase";
            this.textBoxDataBase.Size = new System.Drawing.Size(396, 22);
            this.textBoxDataBase.TabIndex = 12;
            this.textBoxDataBase.Text = "skips";
            this.textBoxDataBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(10, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "TEMPO (Minutos):";
            this.label3.UseWaitCursor = true;
            // 
            // textBoxTempo
            // 
            this.textBoxTempo.Location = new System.Drawing.Point(140, 280);
            this.textBoxTempo.Name = "textBoxTempo";
            this.textBoxTempo.Size = new System.Drawing.Size(396, 22);
            this.textBoxTempo.TabIndex = 14;
            this.textBoxTempo.Text = "10";
            this.textBoxTempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Location = new System.Drawing.Point(9, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "CAMINHO MYSQL:";
            this.label4.UseWaitCursor = true;
            // 
            // textBoxCaminhoMySQL
            // 
            this.textBoxCaminhoMySQL.Location = new System.Drawing.Point(140, 400);
            this.textBoxCaminhoMySQL.Name = "textBoxCaminhoMySQL";
            this.textBoxCaminhoMySQL.Size = new System.Drawing.Size(396, 22);
            this.textBoxCaminhoMySQL.TabIndex = 16;
            this.textBoxCaminhoMySQL.Text = "C:\\xampp\\mysql\\bin\\";
            this.textBoxCaminhoMySQL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(581, 536);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCaminhoMySQL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxTempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDataBase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNomeArquivo);
            this.Controls.Add(this.labelNomePrograma);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.textBoxSenha);
            this.Controls.Add(this.labelServidor);
            this.Controls.Add(this.textBoxServidor);
            this.Controls.Add(this.labelPath);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.buttonStart);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelPath;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label labelServidor;
        private System.Windows.Forms.TextBox textBoxServidor;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textBoxSenha;
        private System.Windows.Forms.Label labelNomePrograma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNomeArquivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDataBase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTempo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCaminhoMySQL;
    }
}

