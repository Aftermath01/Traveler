using System.IO;

namespace Traveler.Contracts
{
    public interface IDirectoryFinder
    {
        DirectoryInfo TryGetSolutionDirectoryInfo(string currentPath = null);
    }
}
