using System;
using System.Collections.Generic;
namespace addpath
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.Machine);
            string NEW_PATH;
            if (path[path.Length - 1] == ';')
            {
                NEW_PATH = String.Format("{0}{1}", path, Environment.CurrentDirectory);
            }
            else
            {
                NEW_PATH = String.Format("{0};{1}", path, Environment.CurrentDirectory);
            }

            Environment.SetEnvironmentVariable("PATH", NEW_PATH, EnvironmentVariableTarget.Machine);
            Console.WriteLine(NEW_PATH);
        }
    }
}
