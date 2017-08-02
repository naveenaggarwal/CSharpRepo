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
            Stack<int> source = new Stack<int>();
            source.Push(1);
            source.Push(2);
            source.Push(3);
            source.Push(4);
            Stack<int> target = ReverseStack.Reverse(source);
            while (target.Count != 0)
            {
                Console.WriteLine(target.Pop());
            }
            Console.ReadLine();
            
        }
    }
}
