using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncasulationDemoWithDice
{
    class Program
    {
        static void Main(string[] args)
        {
            Die[] dice = new Die[5];
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = new Die();
                Console.WriteLine(dice[i].Value);
            }
            Console.ReadKey();
        }
    }
}
