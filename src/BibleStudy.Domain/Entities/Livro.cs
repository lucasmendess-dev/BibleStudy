using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BibleStudy.Domain.Enums;

namespace BibleStudy.Domain.Entities
{
    public class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Abreviacao { get; set; }
        public Testamento Testamento { get; set; }
        public int Ordem { get; set; }
        public List<Capitulo> Capitulos { get; set; } = new();
    }
}