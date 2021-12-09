using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EFCore.Legado
{
    public partial class Herois
    {
        public Herois()
        {
            Armas = new HashSet<Armas>();
            HeroisBatalhas = new HashSet<HeroisBatalhas>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public virtual IdentidadesSecretas IdentidadesSecretas { get; set; }
        public virtual ICollection<Armas> Armas { get; set; }
        public virtual ICollection<HeroisBatalhas> HeroisBatalhas { get; set; }
    }
}
