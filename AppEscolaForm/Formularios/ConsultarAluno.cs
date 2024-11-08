using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppEscolaForm.Models;
using AppEscolaForm.Contexto;

namespace AppEscolaForm.Formularios
{
    public partial class ConsultarAluno : Form
    {
        public ConsultarAluno()
        {
            InitializeComponent();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtNomeAluno.Text;

            Aluno alunoEncontrado = Context.ListaAlunos
                .Where(aluno => aluno.Nome == nome)
                .FirstOrDefault();

            if (alunoEncontrado != null)
            {
                SalaDeAula turmaDoAluno = Context.ListaSalasDeAula
                    .Where(sala => sala.Id == alunoEncontrado.IdSalaDeAula)
                    .First();

                txtNomeAlunoEncontrado.Text = alunoEncontrado.Nome;
                txtMatricula.Text = alunoEncontrado.NumMatricula.ToString();
                txtNota1.Text = alunoEncontrado.Nota1.ToString();
                txtNota2.Text = alunoEncontrado.Nota2.ToString();
                txtMedia.Text = alunoEncontrado.CalcularMedia().ToString();
                txtSituacao.Text = alunoEncontrado.VerificarSituacao();

                txtTurma.Text = turmaDoAluno.SerieNomeEAno;
            }
            else
            {
                txtNomeAlunoEncontrado.Clear();
                txtMatricula.Clear();
                txtTurma.Clear();
                txtNota1.Clear();
                txtNota2.Clear();
                txtMedia.Clear();
                txtSituacao.Clear();
                MessageBox.Show("ALUNO NÃO ENCONTRADO", "2º A INF", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
