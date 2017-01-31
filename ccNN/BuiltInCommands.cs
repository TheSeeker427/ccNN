using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ccNN
{
    class BuiltInCommands
    {
        public static string nmap()
        {
            string result;
            // Start the child process.
            Process p = new Process();
            // Redirect the output stream of the child process.
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardOutput = true;
            
            Console.WriteLine(AppDomain.CurrentDomain.BaseDirectory + @"../Plugins/nmap/nmap.exe");
            p.StartInfo.FileName = AppDomain.CurrentDomain.BaseDirectory + @"..\..\..\Plugins\nmap\nmap.exe";
            p.StartInfo.Arguments = @"10.252.16.0/24";
            p.Start();
            // Do not wait for the child process to exit before
            // reading to the end of its redirected stream.
            // p.WaitForExit();
            // Read the output stream first and then wait.
            string output = p.StandardOutput.ReadToEnd();
            p.WaitForExit();

            return output;
        }

    }
}
