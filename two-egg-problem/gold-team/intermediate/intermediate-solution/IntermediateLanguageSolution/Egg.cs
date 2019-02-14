using System;

namespace IntermediateLanguageSolution
{
    class Egg
    {
        static void dropEgg(ref int egg, int floor, int answer)
        {

            bool isBroken = false;

            if (floor >= answer)
            {
                egg = floor;
                isBroken = true;
            }

            Console.WriteLine("{0}\n{1}", floor, isBroken ? "True" : "False");
        }

        static void Main(string[] args)
        {
            int floors = 0, answer = 0, scale = 0, eggOne = -1, eggTwo = -1, currentFloor = 0;

            int.TryParse(args[0], out floors);
            int.TryParse(args[1], out answer);

            scale = Convert.ToInt32(Math.Round(Math.Sqrt(floors)));

            if (floors < scale)
            {
                scale = floors;
            }

            while (eggOne == -1)
            {
                currentFloor += scale;
                if (currentFloor > floors)
                {
                    scale = floors - (currentFloor - scale);
                    currentFloor = floors;
                }

                dropEgg(ref eggOne, currentFloor, answer);
            }

            currentFloor = currentFloor - scale + 1;

            for (int i = currentFloor; i < eggOne && eggTwo == -1; i++)
            {
                dropEgg(ref eggTwo, i, answer);
            }

            Console.WriteLine("Floor {0}", eggTwo == -1 ? eggOne : eggTwo);
        }
    }
}
