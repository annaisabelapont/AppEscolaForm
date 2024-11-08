using AppEscolaForm.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppEscolaForm.Formularios;
using AppEscolaForm.Contexto;

namespace AppEscolaForm.Formularios
{
    public partial class ExibirAlunosReprovados : Form
    {
        public ExibirAlunosReprovados()
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
                txtSerie.Text = salaDeAulaSelecionada.Serie.ToString();
                txtNomeTurma.Text = salaDeAulaSelecionada.NomeTurma;
                txtAno.Text = salaDeAulaSelecionada.Ano.ToString();
                dtTabela.DataSource = Context.ListaAlunos
                    .Where(aluno => aluno.IdSalaDeAula == salaDeAulaSelecionada.Id && aluno.VerificarSituacao() == "REPROVADO(A)")
                    .ToList();
            }
            else
            {
                LimparCaixasTexto();
            }
        }

        private void LimparCaixasTexto()
        {
            txtNomeTurma.Clear();
            txtSerie.Clear();
            txtAno.Clear();
            dtTabela.DataSource = new List<Aluno>();
        }
    }
}

