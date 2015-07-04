using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "I am the MasterBranch";
            SomeFunctionInError(name);
            
        }

        private static void SomeFunctionInError(string name)
        {
            //You better do something here;
            int val = 1 = 1;
        }
    }
}
