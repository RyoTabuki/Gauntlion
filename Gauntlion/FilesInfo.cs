using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauntlion
{
    public class FilesInfo
    {
        public string ReadText(string pathname)
        {
            String const_name = String.Empty;
            string m = File.ReadAllText(pathname);
            const_name = m;
            return const_name;
        }
    }
}
