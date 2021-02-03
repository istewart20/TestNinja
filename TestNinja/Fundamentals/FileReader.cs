using System.IO;

namespace TestNinja.Fundamentals
{
    public class FileReader : IFileReader
    {
        public string Read(string path)
        {
            return File.ReadAllText(path);
        }
    }
}
