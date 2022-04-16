using System;

namespace ConwaysGameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            ConwaysRules gameOfLife = new ConwaysRules();

            //gameOfLife.gridBool[5, 5] = true;
            


            gameOfLife.StartGame();
        }
    }
}
