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

                double totalAlunos = Context.ListaAlunos
                            .Where(aluno => aluno.IdSalaDeAula == salaDeAulaSelecionada.Id)
                            .Count();

                double totalAprovados = Context.ListaAlunos
                    .Where(aluno => aluno.IdSalaDeAula == salaDeAulaSelecionada.Id
                           && aluno.VerificarSituacao() == "APROVADO(A0")
                    .Count();

                double totalReprovados = Context.ListaAlunos
                    .Where(aluno => aluno.IdSalaDeAula == salaDeAulaSelecionada.Id
                           && aluno.VerificarSituacao() == "REPROVADO(A)")
                    .Count();

                double percentualAprovados = totalAprovados / totalAlunos * 100;

                double percentualReprovados = totalReprovados / totalAlunos * 100;

                txtPercentual.Text = $"{(percentualAprovados).ToString("F2")}% está APROVADA e {(percentualReprovados).ToString("F2")}% está REPROVADA!";
            }
            else
            {
                txtPercentual.Clear();
            }
        }
    }
}
