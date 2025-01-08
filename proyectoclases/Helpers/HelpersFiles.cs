using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoclases.Helpers
{
    public class HelpersFiles
    {
        //NECESITAMOS DOS METODOS
        public async Task<string> ReadFileAsync(string path)
        {
            FileInfo file = new FileInfo(path);
            using (TextReader reader = file.OpenText())
            {
                string data = await reader.ReadToEndAsync();
                reader.Close();
                return data;
            }
        }
        public async Task WriteFileAsync(string path, string data)
        {
            FileInfo file = new FileInfo(path);
            using (TextReader writer = file.CreateText())
            {
                await writer.Write();
            }
        }
    }
}
