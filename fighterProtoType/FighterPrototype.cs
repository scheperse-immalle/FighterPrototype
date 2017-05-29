using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fighterProtoType
{
    public abstract class FighterPrototype
    {
        private string name;

        protected FighterPrototype(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public FighterPrototype Clone()
        {
            return (FighterPrototype)this.MemberwiseClone();
        }

        public void ShowFighter()
        {
            Console.WriteLine("The name of the Fighter is {0}", this.name);
        }
    }
}
