﻿namespace AppEscolaForm.Formularios
{
    partial class CadastrarSalaDeAula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.txtNomeTurma = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(621, 30);
            this.label5.TabIndex = 38;
            this.label5.Text = "CADASTRO DE SALA DE AULA";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "NOME DA TURMA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "NÚMERO DA SÉRIE";
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.Color.Honeydew;
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btSalvar.Location = new System.Drawing.Point(488, 154);
            this.btSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(257, 48);
            this.btSalvar.TabIndex = 3;
            this.btSalvar.Text = "SALVAR";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // txtNomeTurma
            // 
            this.txtNomeTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeTurma.Location = new System.Drawing.Point(68, 207);
            this.txtNomeTurma.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeTurma.Name = "txtNomeTurma";
            this.txtNomeTurma.Size = new System.Drawing.Size(363, 30);
            this.txtNomeTurma.TabIndex = 1;
            // 
            // txtSerie
            // 
            this.txtSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerie.Location = new System.Drawing.Point(68, 132);
            this.txtSerie.Margin = new System.Windows.Forms.Padding(4);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(363, 30);
            this.txtSerie.TabIndex = 0;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.MistyRose;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btCancelar.Location = new System.Drawing.Point(488, 230);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(257, 46);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // txtAno
            // 
            this.txtAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAno.Location = new System.Drawing.Point(68, 280);
            this.txtAno.Margin = new System.Windows.Forms.Padding(4);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(363, 30);
            this.txtAno.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "ANO";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(0, 347);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(800, 17);
            this.label11.TabIndex = 107;
            this.label11.Text = "Anna Isabela, Dhuliana Paula e Giovanna Rodrigues";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CadastrarSalaDeAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(800, 366);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.txtNomeTurma);
            this.Controls.Add(this.txtSerie);
            this.Name = "CadastrarSalaDeAula";
            this.Text = "CadastrarSalaDeAula";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.TextBox txtNomeTurma;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
    }
}