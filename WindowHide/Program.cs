using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowHide
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string[] args = Environment.GetCommandLineArgs();

            // Without arguments we simply quit
            if (args.Length < 2)
                return;

            StringBuilder arguments = new StringBuilder();
            for (int i = 2; i < args.Length; i++)
                arguments.AppendFormat(" {0}", args[i]);

            Process proc = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo(args[1]);
            startInfo.Arguments = arguments.ToString().Trim();
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            proc.StartInfo = startInfo;
            proc.Start();
            proc.WaitForExit();

        }
    }
}
