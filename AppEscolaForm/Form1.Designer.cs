namespace AppEscolaForm
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
            this.btCadastrarSalaDeAula = new System.Windows.Forms.Button();
            this.btMatricularAluno = new System.Windows.Forms.Button();
            this.btConsultarAluno = new System.Windows.Forms.Button();
            this.btConsultarTurma = new System.Windows.Forms.Button();
            this.btConsultarAprovadosTurma = new System.Windows.Forms.Button();
            this.btConsultarReprovadosTurma = new System.Windows.Forms.Button();
            this.btConsultarAprovadosReprovadosTurma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCadastrarSalaDeAula
            // 
            this.btCadastrarSalaDeAula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrarSalaDeAula.Location = new System.Drawing.Point(60, 93);
            this.btCadastrarSalaDeAula.Margin = new System.Windows.Forms.Padding(4);
            this.btCadastrarSalaDeAula.Name = "btCadastrarSalaDeAula";
            this.btCadastrarSalaDeAula.Size = new System.Drawing.Size(947, 49);
            this.btCadastrarSalaDeAula.TabIndex = 0;
            this.btCadastrarSalaDeAula.Text = "CADASTRAR SALA DE AULA";
            this.btCadastrarSalaDeAula.UseVisualStyleBackColor = true;
            this.btCadastrarSalaDeAula.Click += new System.EventHandler(this.btCadastrarSalaDeAula_Click);
            // 
            // btMatricularAluno
            // 
            this.btMatricularAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMatricularAluno.Location = new System.Drawing.Point(60, 165);
            this.btMatricularAluno.Margin = new System.Windows.Forms.Padding(4);
            this.btMatricularAluno.Name = "btMatricularAluno";
            this.btMatricularAluno.Size = new System.Drawing.Size(947, 49);
            this.btMatricularAluno.TabIndex = 1;
            this.btMatricularAluno.Text = "MATRICULAR ALUNO";
            this.btMatricularAluno.UseVisualStyleBackColor = true;
            this.btMatricularAluno.Click += new System.EventHandler(this.btMatricularAluno_Click);
            // 
            // btConsultarAluno
            // 
            this.btConsultarAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarAluno.Location = new System.Drawing.Point(60, 237);
            this.btConsultarAluno.Margin = new System.Windows.Forms.Padding(4);
            this.btConsultarAluno.Name = "btConsultarAluno";
            this.btConsultarAluno.Size = new System.Drawing.Size(947, 49);
            this.btConsultarAluno.TabIndex = 2;
            this.btConsultarAluno.Text = "CONSULTAR ALUNO (EXIBIR DADOS E TURMA)";
            this.btConsultarAluno.UseVisualStyleBackColor = true;
            this.btConsultarAluno.Click += new System.EventHandler(this.btConsultarAluno_Click);
            // 
            // btConsultarTurma
            // 
            this.btConsultarTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarTurma.Location = new System.Drawing.Point(60, 309);
            this.btConsultarTurma.Margin = new System.Windows.Forms.Padding(4);
            this.btConsultarTurma.Name = "btConsultarTurma";
            this.btConsultarTurma.Size = new System.Drawing.Size(947, 49);
            this.btConsultarTurma.TabIndex = 3;
            this.btConsultarTurma.Text = "CONSULTAR TURMAS (EXIBIR DADOS SALA DE AULA E ALUNOS MATRICULADOS)";
            this.btConsultarTurma.UseVisualStyleBackColor = true;
            this.btConsultarTurma.Click += new System.EventHandler(this.btConsultarTurma_Click);
            // 
            // btConsultarAprovadosTurma
            // 
            this.btConsultarAprovadosTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarAprovadosTurma.Location = new System.Drawing.Point(60, 381);
            this.btConsultarAprovadosTurma.Margin = new System.Windows.Forms.Padding(4);
            this.btConsultarAprovadosTurma.Name = "btConsultarAprovadosTurma";
            this.btConsultarAprovadosTurma.Size = new System.Drawing.Size(947, 49);
            this.btConsultarAprovadosTurma.TabIndex = 4;
            this.btConsultarAprovadosTurma.Text = "CONSULTAR TURMAS( EXIBIR APENAS ALUNOS APROVADOS)";
            this.btConsultarAprovadosTurma.UseVisualStyleBackColor = true;
            this.btConsultarAprovadosTurma.Click += new System.EventHandler(this.btConsultarAprovadosTurma_Click);
            // 
            // btConsultarReprovadosTurma
            // 
            this.btConsultarReprovadosTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarReprovadosTurma.Location = new System.Drawing.Point(60, 453);
            this.btConsultarReprovadosTurma.Margin = new System.Windows.Forms.Padding(4);
            this.btConsultarReprovadosTurma.Name = "btConsultarReprovadosTurma";
            this.btConsultarReprovadosTurma.Size = new System.Drawing.Size(947, 49);
            this.btConsultarReprovadosTurma.TabIndex = 5;
            this.btConsultarReprovadosTurma.Text = "CONSULTAR TURMAS( EXIBIR APENAS ALUNOS REPROVADOS)";
            this.btConsultarReprovadosTurma.UseVisualStyleBackColor = true;
            this.btConsultarReprovadosTurma.Click += new System.EventHandler(this.btConsultarReprovadosTurma_Click);
            // 
            // btConsultarAprovadosReprovadosTurma
            // 
            this.btConsultarAprovadosReprovadosTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConsultarAprovadosReprovadosTurma.Location = new System.Drawing.Point(60, 525);
            this.btConsultarAprovadosReprovadosTurma.Margin = new System.Windows.Forms.Padding(4);
            this.btConsultarAprovadosReprovadosTurma.Name = "btConsultarAprovadosReprovadosTurma";
            this.btConsultarAprovadosReprovadosTurma.Size = new System.Drawing.Size(947, 49);
            this.btConsultarAprovadosReprovadosTurma.TabIndex = 6;
            this.btConsultarAprovadosReprovadosTurma.Text = "CONSULTAR TURMA (PERCENTUAL DE APROVADOS E REPROVADOS DA TURMA)";
            this.btConsultarAprovadosReprovadosTurma.UseVisualStyleBackColor = true;
            this.btConsultarAprovadosReprovadosTurma.Click += new System.EventHandler(this.btConsultarAprovadosReprovadosTurma_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1085, 80);
            this.label1.TabIndex = 7;
            this.label1.Text = "Anna Isabela, Dhuliana Paula e Giovanna Rodrigues - 2° A Informática";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1067, 607);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btConsultarAprovadosReprovadosTurma);
            this.Controls.Add(this.btConsultarReprovadosTurma);
            this.Controls.Add(this.btConsultarAprovadosTurma);
            this.Controls.Add(this.btConsultarTurma);
            this.Controls.Add(this.btConsultarAluno);
            this.Controls.Add(this.btMatricularAluno);
            this.Controls.Add(this.btCadastrarSalaDeAula);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCadastrarSalaDeAula;
        private System.Windows.Forms.Button btMatricularAluno;
        private System.Windows.Forms.Button btConsultarAluno;
        private System.Windows.Forms.Button btConsultarTurma;
        private System.Windows.Forms.Button btConsultarAprovadosTurma;
        private System.Windows.Forms.Button btConsultarReprovadosTurma;
        private System.Windows.Forms.Button btConsultarAprovadosReprovadosTurma;
        private System.Windows.Forms.Label label1;
    }
}

