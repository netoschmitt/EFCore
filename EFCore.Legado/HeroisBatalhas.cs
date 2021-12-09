using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace EFCore.Legado
{
    public partial class HeroisBatalhas
    {
        public int HeroId { get; set; }
        public int BatalhaId { get; set; }
        public int? HeroiId { get; set; }

        public virtual Batalhas Batalha { get; set; }
        public virtual Herois Heroi { get; set; }
    }
}
