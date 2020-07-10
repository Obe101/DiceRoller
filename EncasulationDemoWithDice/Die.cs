using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncasulationDemoWithDice
{
    class Die
    {
        //static fields are shared across all istances of a class
        static Random rand;

        static Die() //Static constructor are called once for all constructors 
        {
            rand = new Random();
        }
        public Die()
        {
            Roll(); // Roll Die on creation to generate first random number
        }
        ///<summaryy> Face value of die
        
        public byte Value { get; private set; }

        public bool IsHeld { get; set; }

        ///<Summary>
        ///Roll a new random number value between 1-6
        ///and return the newly rolled value
        ///If die is held, the current value will be returned
        ///annd no new value generated
        /// </Summary>

        public byte Roll() 
        {
            if (!IsHeld) 
            {
                Value = (byte)rand.Next(1, 7);
            
            }
            return Value;
        }
    }
}
