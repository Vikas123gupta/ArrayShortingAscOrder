using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Permissions;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        /// <summary>
        /// This program is use to Short Your array in asc order 
        /// </summary>
        /// <param name="args"></param>
        
        static void Main(string[] args)
        {
            int[] IntegerArray = { 2, 4, 3, 1, 6, 5 };
            int IntegerArrayLength = IntegerArray.Length;
            for (int i = 0; i < IntegerArrayLength - 1; i++)
            {
                for (int j = 0; j < (IntegerArrayLength - 1) - i; j++)
                {
                    if (IntegerArray[j] > IntegerArray[j + 1])
                    {
                       int greatervalue = IntegerArray[j];
                       IntegerArray[j] = IntegerArray[j + 1];
                       IntegerArray[j + 1] = greatervalue;
                    }
                }
            }
            for (int i = 0; i < IntegerArrayLength; i++)
            {
                Console.WriteLine(IntegerArray[i]);
            }
        }
    }
}
