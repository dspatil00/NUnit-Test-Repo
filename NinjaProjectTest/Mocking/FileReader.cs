using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaProjectTest.Mocking
{    
    public class FileReader : IFileReader
    {
        public string Read (string path)
        {
           return File.ReadAllText(path);
        }
    }
}
