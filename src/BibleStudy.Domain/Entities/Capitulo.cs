using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibleStudy.Domain.Entities
{
    public class Capitulo
    {
        public int Id { get; set; }

        public int Numero { get; set; }

        public int LivroId { get; set; }

        public Livro Livro { get; set; } = null!;

        public List<Versiculo> Versiculos { get; set; } = new();
    }
}