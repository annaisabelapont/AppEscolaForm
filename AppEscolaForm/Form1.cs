using AppEscolaForm.Formularios;
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

namespace AppEscolaForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCadastrarSalaDeAula_Click(object sender, EventArgs e)
        {
           new CadastrarSalaDeAula().ShowDialog();
        }

        private void btMatricularAluno_Click(object sender, EventArgs e)
        {
            new MatricularAluno().ShowDialog();
        }

        private void btConsultarAluno_Click(object sender, EventArgs e)
        {
            new ConsultarAlunos().ShowDialog();
        }

        private void btConsultarTurma_Click(object sender, EventArgs e)
        {
            new ConsultarTurmas().ShowDialog();
        }

        private void btConsultarAprovadosTurma_Click(object sender, EventArgs e)
        {
            new ExibirAlunosAprovados().ShowDialog();
        }

        private void btConsultarReprovadosTurma_Click(object sender, EventArgs e)
        {
            new ExibirAlunosReprovados().ShowDialog();
        }

        private void btConsultarAprovadosReprovadosTurma_Click(object sender, EventArgs e)
        {
            new ExibirPercentual().ShowDialog();
        }
    }
}
