using System;
using System.IO;
using Traveler.Contracts;

namespace Traveler
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IDirectoryFinder directoryFinder = new DirectoryFinder();
            var slnDirectory = directoryFinder.TryGetSolutionDirectoryInfo();

            var inputFilePath = Path.Combine(slnDirectory.FullName, "data\\input.txt");
            var input = File.ReadAllText(inputFilePath);

            var walkedRobots = TravelParser.Run(input);

            foreach (var item in walkedRobots)
            {
                Console.WriteLine("X={0} Y={1} D={2}", item.Position.X, item.Position.Y, item.Position.Orientation);
            }
        }
    }
}
