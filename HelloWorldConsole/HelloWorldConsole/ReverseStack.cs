﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

//Necessary for Stack

namespace CodingPuzzles
{
    //Reverse a stack
    public static class ReverseStack
    {
        //This method returns a stack
        public static Stack<T> Reverse(Stack<T> input)
        {
            //Declare another stack to store the values from the passed stack
            Stack<T> temp = new Stack<T>();

            //While the passed stack isn't empty, pop elements from the passed stack onto the temp stack
            while (input.Count != 0)
                temp.Push(input.Pop());

            return temp;
        }
    }
}