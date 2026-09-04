using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BibleStudy.Domain.Entities
{
    public class Versiculo
    {
        public int Id { get; set; }

        public int Numero { get; set; }

        public string Texto { get; set; } = string.Empty;

        public int CapituloId { get; set; }

        public Capitulo Capitulo { get; set; } = null!;
    }
}