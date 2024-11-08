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
    public partial class CadastrarSalaDeAula : Form
    {
        static private int IdSalaDeAula = 1;

        public CadastrarSalaDeAula()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            var salaDeAula = new SalaDeAula();
            salaDeAula.Id = IdSalaDeAula++;

            salaDeAula.Serie = Convert.ToInt32(txtSerie.Text);
            salaDeAula.NomeTurma = txtNomeTurma.Text;
            salaDeAula.Ano = Convert.ToInt32(txtAno.Text);

            Context.ListaSalasDeAula.Add(salaDeAula);

            MessageBox.Show("SALVO COM SUCESSO", "2º A INF", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimparTudo();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            LimparTudo();
        }
        void LimparTudo()
        {
            txtSerie.Clear();
            txtNomeTurma.Clear();
            txtAno.Clear();
        }
    }
}
