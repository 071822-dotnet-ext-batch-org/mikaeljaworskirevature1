﻿using System;

namespace console5app
{
    class Program
    {
        static void Main(string[] args)
        {
             bool b1 = 1 < 0;
  bool b2 = !(12 % 3 > 2);
  if (b1 = b2)
    Console.Write("true: ");
  else
    Console.Write("false: ");
  Console.WriteLine("b1 is {0}.  b2 is {1}.", b1, b2);
        }
    }
}
