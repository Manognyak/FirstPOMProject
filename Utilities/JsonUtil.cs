using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace FirstPOMProject.Utilities
{
    class JsonUtil
    {
        public static String ReadJsonFile(string filePath)
        {
            string jsonContent = File.ReadAllText(filePath);
            return jsonContent;

        }
    }
}
