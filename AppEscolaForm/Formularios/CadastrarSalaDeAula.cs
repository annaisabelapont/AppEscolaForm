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
        public CadastrarSalaDeAula()
        {
            InitializeComponent();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            var salaDeAula = new SalaDeAula();
            salaDeAula.Serie = Convert.ToInt32(txtSerie.Text);
            salaDeAula.NomeTurma = txtNomeTurma.Text;
            
            Context.ListaSalas.Add(salaDeAula);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            txtSerie.Clear();
            txtNomeTurma.Clear();
        }
    }
}
