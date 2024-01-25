using Newtonsoft.Json;
using System.IO;

namespace sphere.src.dist.backend
{
    internal class jsonprovider
    {
        public static string GetResult(string file, string str)
        {
            dynamic jsonFile = JsonConvert.DeserializeObject(File.ReadAllText(file));

            return $"{jsonFile[str]}";
        }
    }
}
