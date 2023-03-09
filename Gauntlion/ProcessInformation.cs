using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gauntlion
{
    public class ProcessInformation
    {
        public byte[] GetBytesFiles(string filepath)
        {
            byte[] read_file_data = File.ReadAllBytes(filepath);
            return read_file_data;
        }
        public int GetProcessID()
        {
            Process procession = Process.GetCurrentProcess();
            return procession.Id;
        }
        public int Gauntlion_GetProcessIDCurrent(string processname)
        {
            int process_id = 0;
            Process[] x = Process.GetProcessesByName(processname);
            foreach (Process process in x)
            {
                process_id = process.Id;
            }
            return process_id;
        }
    }
}
