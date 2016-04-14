using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceFortuneTeller_4._13._16
{
    class ClassMagic
    {
        //
        public virtual string Name { get; set; }

        public virtual bool BlackMagic { get; set; }

        public virtual int PercentEffective { get; set; }

        protected virtual string Expertise { get; set; }

        public virtual void Work()
        {
            Console.WriteLine("Let me pull out my {0}", this.Name);
        }

        public virtual void Show()
        {
            Console.WriteLine("oh my, the {0} told me, yes, your future", this.Name);
        }


    }

}
