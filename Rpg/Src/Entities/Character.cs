using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg.Src.Entities
{
    public abstract class Character


    {
        public string Name { get; set; }
        public int Leval { get; set; }
        public string HeroType { get; set; }

        public Character(string Name, int Leval, string HeroType)
        {
            this.Name = Name;
            this.Leval = Leval;
            this.HeroType = HeroType;
        }

        public override string ToString()
        {
            return Name + " " + Leval + " " + HeroType;
        }

        public virtual string Attack()
        {
            return this.Name + " ";
        }
    }
}
