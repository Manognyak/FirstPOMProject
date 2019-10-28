using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FirstPOMProject.Utilities
{
    static class FileUtil
    {
        public static string ReadTextFile(string filename)
        {
            string txtContent;
            var filePath = System.IO.Path.Combine(@"d:\Learning", filename);
            if (File.Exists(filePath))
                txtContent = System.IO.File.ReadAllText(filePath);
            else txtContent = "File not found";
            return txtContent;
        }
        public static void WriteToFile(string filepath, String contents)
        {
            if (File.Exists(filepath))
                System.IO.File.WriteAllText(filepath, contents);
        }
    }
}
