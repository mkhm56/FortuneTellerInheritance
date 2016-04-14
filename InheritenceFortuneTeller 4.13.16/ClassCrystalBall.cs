using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceFortuneTeller_4._13._16
{
    class ClassCrystalBall:ClassMagic

    {
        //FIELD
        private Random random = new Random();

        //PROPERTY
        protected List<string> Phrases { get; set; } = new List<string>();

        public override void Work()
        {
            this.Result = 
        }
        protected void CreatePhrases()
        {   Phrases.Add("Night time is a dark place for you.");
            Phrases.Add("I see shiny objects in your near future");
            Phrases.Add("The decorating around you needs some help.");
        }

        protected void CreatePhrases(string phrase)
        {
            Phrases.Add(phrase);
        }
       
        private string GetPhrase()
        {
            int randomNumber = random.Next(Phrases.Count);
            return Phrases.ElementAt(randomNumber);
        }

        //CONSTRUCTORS

        public ClassCrystalBall()
        {
            this.Price = 45.00M;
            this.PercentEffective = 65;
            this.BackMagic = false;
            this.Expertise = "beginner";
            //I want to call my initializer for phrases
            CreatePhrases();
        }


        }
    }
}
