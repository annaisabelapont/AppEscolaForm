using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppEscolaForm.Contexto;
using AppEscolaForm.Models;

namespace AppEscolaForm.Formularios
{
    public partial class MatricularAluno : Form
    {
        private int IdSalaDeAulaSelecionada { get; set; }

        static private int IdAluno = 1;

        private List<Aluno> ListaTemporariaAlunos = new List<Aluno>();
        public MatricularAluno()
        {
            InitializeComponent();
            cbTurma.DataSource = Context.ListaSalasDeAula.ToList();
            cbTurma.DisplayMember = "SerieNomeEAno";
            cbTurma.SelectedIndex = -1;
        }

        private void cbTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indiceSelecionado = cbTurma.SelectedIndex;
            if (indiceSelecionado != -1)
            {
                SalaDeAula salaDeAulaSelecionada = Context.ListaSalasDeAula[indiceSelecionado];

                this.IdSalaDeAulaSelecionada = salaDeAulaSelecionada.Id;
            }
            else
            {
                LimparCaixasETabela();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.IdSalaDeAula = IdSalaDeAulaSelecionada;
            aluno.Id = IdAluno++;

            aluno.Nome = txtNome.Text;
            aluno.NumMatricula = Convert.ToInt32(txtMatricula.Text);
            aluno.Nota1 = Convert.ToDouble(txtNota1.Text);
            aluno.Nota2 = Convert.ToDouble(txtNota2.Text);

            ListaTemporariaAlunos.Add(aluno);
            dtTabela.DataSource = ListaTemporariaAlunos.ToList();

            LimparCaixasTexto();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            Context.ListaAlunos.AddRange(ListaTemporariaAlunos);

            MessageBox.Show("SALVO COM SUCESSO", "2º A INF", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ListaTemporariaAlunos.Clear();
            LimparTudo();
        }
        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimparCaixasTexto();
        }

        private void LimparCaixasTexto()
        {
            txtNome.Clear();
            txtMatricula.Clear();
            txtNota2.Clear();
            txtNota1.Clear();
            txtNome.Focus();
        }
        private void LimparCaixasETabela()
        {
            LimparCaixasTexto();
            dtTabela.DataSource = new List<Aluno>();
        }
        private void LimparTudo()
        {
            LimparCaixasETabela();
            cbTurma.SelectedIndex = -1;
        }

    }
}
