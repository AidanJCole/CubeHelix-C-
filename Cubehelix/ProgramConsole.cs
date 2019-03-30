using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cubehelix
{
    class ProgramConsole
    {
        

        static void Main(string[] args)
        {
            Cubehelix helix = new Cubehelix();
            helix.Hue = 2;
            helix.Rotations = 1;
            helix.Start = 0;
            helix.StartLightness = .5;
            helix.EndLightness = .5;

            double[,] numbers = { { 0, 0 }, { 0, 0 }, { Math.PI, 0 } };
            while (numbers[0,0]!=numbers[2,0])
            {
                numbers[1,0] = (numbers[0,0]+numbers[2,0]) / 2;
                Console.WriteLine(numbers[0,0] + " " + numbers[1,0] + " " + numbers[2,0]);
                for (int i = 0; i < 3; i++)
                {
                    numbers[i, 1] = helix.getAPoint(numbers[i, 0])[2, 0];
                }
                if (numbers[0, 1] > numbers[2, 1])
                {
                    numbers[2, 0] = numbers[1, 0];
                }
                else
                {
                    numbers[0, 0] = numbers[1, 0];
                }
            }
            Console.Write(numbers[0,1]);
            Console.Read();
        }
    }
}
