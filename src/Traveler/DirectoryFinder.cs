using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using Traveler.Contracts;

namespace Traveler
{
    [ExcludeFromCodeCoverage]
    public class DirectoryFinder : IDirectoryFinder
    {
        public DirectoryInfo TryGetSolutionDirectoryInfo(string currentPath = null)
        {
            var directory = new DirectoryInfo(
                currentPath ?? Directory.GetCurrentDirectory());

            while (directory != null && !directory.GetFiles("*.sln").Any())
            {
                directory = directory.Parent;
            }

            return directory;
        }
    }
}
