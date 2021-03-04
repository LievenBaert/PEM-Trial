using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CopyFolder
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string path = "";
            if (((IEnumerable<string>)args).Count<string>() == 0)
                path = Directory.GetCurrentDirectory();
            if (((IEnumerable<string>)args).Count<string>() >= 1)
                path = args[0];
            if (!Directory.Exists(path))
                throw new Exception("Unknown path given");
            string distFolder = path + "\\dist";
            string publicFolder = path + "\\public";
            if (Directory.Exists(publicFolder))
                return;
            if (!Directory.Exists(distFolder))
                throw new Exception("no dist folder found to copy");
            Directory.CreateDirectory(publicFolder);
            foreach (string directory in Directory.GetDirectories(distFolder, "*", SearchOption.AllDirectories))
                Directory.CreateDirectory(directory.Replace(distFolder, publicFolder));
            foreach (string file in Directory.GetFiles(distFolder, "*.*", SearchOption.AllDirectories))
                File.Copy(file, file.Replace(distFolder, publicFolder), true);
        }
    }
}
