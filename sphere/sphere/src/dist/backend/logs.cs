using System.IO;

namespace sphere.src.dist.backend
{
    internal class logs
    {
        public static void write(string error, string action)
        {
            File.WriteAllText("errorlog.txt", $"Sphere has experienced an error: {error}; the following action was taken: {action}");
        }
    }
}
