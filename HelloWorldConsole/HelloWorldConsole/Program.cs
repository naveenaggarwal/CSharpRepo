using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingPuzzles;
using System.Collections;

namespace HelloWorldConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Stack source<int> = new System.Collections.Stack<int>();
            source.Push(1);
            source.Push(2);
            source.Push(3);
            source.Push(4);
            Stack<int> target = ReverseStack.Reverse(source);
            
        }
    }
}
