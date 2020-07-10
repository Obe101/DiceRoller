using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncasulationDemoWithDice
{
    class Die
    {
        Random rand;
        public Die()
        {
            rand = new Random();
            Roll(); // Roll Die on creation to generate first random number
        }
        ///<summaryy> Face value of die
        
        public byte Value { get; private set; }

        public bool IsHeld { get; set; }

        ///<Summary>
        ///Roll a new random number value between 1-6
        ///and return the newly rolled value
        /// </Summary>

        public byte Roll() 
        {
            Value = (byte)rand.Next(1, 7);
            return Value
        }
    }
}
