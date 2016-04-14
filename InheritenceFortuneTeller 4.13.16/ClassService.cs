using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceFortuneTeller_4._13._16
{
    class Service
    {
        public virtual decimal Price { get; set; }
        //I want the price to be override-able, services have costs
        public virtual string Name { get; set; }
        //all services have a name
        public virtual string Result { get; set; }
        //we might want to track other things too, but we can add on later if we want



    }

}
