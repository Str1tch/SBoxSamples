using System;
using System.Collections.Generic;

namespace arrayFunction
{
    public class Program
    {
        public static string FunctionExample(string str1, string str2) {
          return str1 + str2;
        }
        
        public static void Main(string[] args)
        {
            // abbreviated way
            var MyDict = new Dictionary<string, Func<int, int>> { // In my sample i use Func delegate not Action
              ["key"] = (int arg1) => { return arg1 + 5; } // Using anonymous function for setup key function
            };
            // full way
            Dictionary<string, Func<int, int>> MyDict = new Dictionary<string, Func<int, int>> { // In my sample i use Func delegate not Action
              ["key"] = (int arg1) => { return arg1 + 5; } // Using anonymous function for setup key function
            };
            // setup of an existing method
            Dictionary<string, Func<int, int>> MyDict = new Dictionary<string, Func<int, int>> { // In my sample i use Func delegate not Action
              ["key"] = FunctionExample; // Warning! The functions arguments must be converges with types in delegate! Func<arguments_type, return_type>
            };            
        }
    }
}
