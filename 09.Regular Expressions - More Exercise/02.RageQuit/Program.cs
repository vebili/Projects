﻿using System;
using System.Linq;
using System.Text;

namespace _02.RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            StringBuilder message = new StringBuilder();
            StringBuilder appender = new StringBuilder();

            string number = "";
            foreach (char symbol in input)
            {
                if (!Char.IsDigit(symbol))
                {
                    if (number.Length != 0)
                    {
                        int times = int.Parse(number);
                        for (int i = 1; i <= times; i++)
                        {
                            message.Append(appender);
                        }
                        number = "";
                        appender.Clear();
                    }

                    appender.Append(symbol);
                }
                else
                {
                    number += symbol;
                }
            }

            if (number.Length != 0)
            {
                int times = int.Parse(number);
                for (int i = 1; i <= times; i++)
                {
                    message.Append(appender);
                }
                number = string.Empty;
                appender.Clear();
            }

            if (message.Length == 0)
            {
                message.Append(input);
            }

            string distincted = new string(message.ToString().Distinct().ToArray());
            Console.WriteLine($"Unique symbols used: {distincted.Length}");
            Console.WriteLine(message);
        }
    }
}