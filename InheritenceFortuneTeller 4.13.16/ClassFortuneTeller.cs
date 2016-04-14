using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceFortuneTeller_4._13._16
{
    class FortuneTeller 
    {
        //


        // PROPERTY

        public string Name { get; set; } = "Esmerelda";
        
        public string ExperienceLevel { get; set; }  
               

        //METHOD
            public void Greet()
            {
            Console.WriteLine("Hello!     ");
            Console.WriteLine("What can I help you with today?");
            }

            public void StartService(Service service)
            {
                Console.WriteLine("For    ");
            }

            public void Farewell()
            {
            Console.WriteLine("Thank you      ");
            }

        //CONSTRUCTORS

        public FortuneTeller(string name, string experienceLevel)
        {
            this.Name = name;
            this.ExperienceLevel = experienceLevel;
        }

        public FortuneTeller()
        {

        }

        
    }
}
