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
using AppEscolaForm.Models;

namespace AppEscolaForm.Formularios
{
    public partial class ExibirPercentual : Form
    {
        public ExibirPercentual()
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

                List<Aluno> alunosSalaSelecionada = Context.ListaAlunos
                            .Where(aluno => aluno.IdSalaDeAula == salaDeAulaSelecionada.Id)
                            .ToList();

                double totalAlunos = alunosSalaSelecionada.Count();

                double totalAprovados = alunosSalaSelecionada
                    .Where(aluno => aluno.VerificarSituacao() == "APROVADO(A)")
                    .Count();

                double totalReprovados = alunosSalaSelecionada
                    .Where(aluno => aluno.VerificarSituacao() == "REPROVADO(A)")
                    .Count();

                double percentualAprovados = totalAlunos > 0
                        ? totalAprovados / totalAlunos * 100
                        : 0;

                double percentualReprovados = totalAlunos > 0
                        ? totalReprovados / totalAlunos * 100
                        : 0;

                txtPercentual.Text = $"{(percentualAprovados).ToString("F2")}% está APROVADA e {(percentualReprovados).ToString("F2")}% está REPROVADA!";
            }
            else
            {
                txtSerie.Clear();
                txtNomeTurma.Clear();
                txtAno.Clear();
                txtPercentual.Clear();
            }
        }
    }
}
