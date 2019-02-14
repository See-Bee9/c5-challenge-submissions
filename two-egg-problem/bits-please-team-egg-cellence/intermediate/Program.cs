using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwoEggs_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t = Task.Run(() => Run(int.Parse(args[0]), int.Parse(args[1])));
            t.Wait();
        }

        private static async Task Run(int floors, int breakingFloor)
        {
            List<KeyValuePair<int, string>> results = new List<KeyValuePair<int, string>>();

            List<Task> tasks = new List<Task>
            {
                Task.Run(() => { results.Add(Min(floors, breakingFloor)); }),
                Task.Run(() => { results.Add(Median(floors, breakingFloor)); }),
                Task.Run(() => { results.Add(Max(floors, breakingFloor)); })
            };

            await Task.WhenAll(tasks);

            Console.WriteLine(results.Where(x => x.Key == results.Min(y => y.Key)).Select(x => x.Value).FirstOrDefault());
        }

        private static KeyValuePair<int, string> Search(int floors, int breakingFloor, Func<int, int> CalculateJumpSize)
        {
            int currentFloor = 0, jumpSize, floorsTried = 0, firstBreak= 0, breakCount = 0;
            string message = "";

            while (currentFloor <= floors)
            {
                jumpSize = (breakCount > 0) ? 1 : CalculateJumpSize(floors - currentFloor);
                currentFloor = (currentFloor + jumpSize <= floors) ? currentFloor + jumpSize : floors;
                if (firstBreak != 0 && currentFloor == firstBreak) break; //we've seen the floor and it broke

                bool didBreak = (currentFloor >= breakingFloor);
                floorsTried++;
                message += currentFloor + "\n" + didBreak + "\n";

                if (didBreak)
                {
                    breakCount++;
                    if (breakCount == 2) break; //we've broken 2 eggs
                    firstBreak = currentFloor;
                    currentFloor = currentFloor - jumpSize;
                }
            }

            message += "Floor " + currentFloor;

            return new KeyValuePair<int, string>(floorsTried, message);
        }

        private static int CalculateMinJumpSize(int floors)
        {
            int jumpSize = floors;
            int worstCase;
            for (int i = 1; i < floors; i++)
            {
                worstCase = (floors / jumpSize + jumpSize - 1);
                int steps = (floors / i + i - 1);

                if (steps < worstCase)
                {
                    jumpSize = i;
                }
                else if (steps > worstCase)
                {
                    break;
                }
            }

            return jumpSize;
        }

        private static int CalculateMaxJumpSize(int floors)
        {
            int jumpSize = floors;
            int worstCase;
            for (int i = 1; i < floors; i++)
            {
                worstCase = (floors / jumpSize + jumpSize - 1);
                int steps = (floors / i + i - 1);

                jumpSize = (steps <= worstCase) ? i : jumpSize;
                if (steps > worstCase)
                {
                    break;
                }
            }

            return jumpSize;
        }

        private static int CalculateMedianJumpSize(int floors)
        {
            int x = CalculateMinJumpSize(floors);
            int y = CalculateMaxJumpSize(floors);
            int jumpSize = (CalculateMinJumpSize(floors) + CalculateMaxJumpSize(floors)) / 2;

            return jumpSize;
        }

        static KeyValuePair<int, string> Min(int floors, int breakingFloor)
        {
            return Search(floors, breakingFloor, CalculateMinJumpSize);
        }

        static KeyValuePair<int, string> Median(int floors, int breakingFloor)
        {
            return Search(floors, breakingFloor, CalculateMedianJumpSize);
        }

        static KeyValuePair<int, string> Max(int floors, int breakingFloor)
        {
            return Search(floors, breakingFloor, CalculateMaxJumpSize);
        }
    }
}