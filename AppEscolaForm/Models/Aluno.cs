using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscolaForm.Models
{
    public class Aluno
    {
        //atributos
        public int Id { get; set; }
        public int NumMatricula { get; set; }
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public int IdSalaDeAula { get; set; }

        //métodos 
        public double CalcularMedia()
        {
            return (Nota1 + Nota2) / 2;
        }

        public string VerificarSituacao()
        {
            var situacao = "REPROVADO(A)";
            if (CalcularMedia() >= 60) situacao = "APROVADO(A)";
            return situacao;
        }
    }
}
