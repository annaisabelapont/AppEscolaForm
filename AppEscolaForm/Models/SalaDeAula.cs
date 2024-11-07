using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppEscolaForm.Models
{
    public class SalaDeAula
    {
        public int Id { get; set; }
        public int Serie { get; set; }
        public string NomeTurma { get; set; }
        public string SerieENome => $"{Serie}° {NomeTurma}";
    }
}
