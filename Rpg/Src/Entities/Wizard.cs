using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg.Src.Entities
{
    class Wizard : Character
    {
        public Wizard(string Name, int Leval, string HeroType) : base(Name, Leval, HeroType)
        {
            this.Name = Name;
            this.Leval = Leval;
            this.HeroType = HeroType;
        }

         public override string Attack()
        {
            return this.Name + " Atacou com magia";
        }
    
    }
}
