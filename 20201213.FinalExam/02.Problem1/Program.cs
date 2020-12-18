﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"!(?<command>[A-Z][a-z]{2,})!:\[(?<message>[A-Za-z]{8,})\]";
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match text = Regex.Match(input, pattern);
                if (text.Success)
                {
                    newMessage(text);
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
        private static void newMessage(Match text)
        {
            string command = text.Groups["command"].Value;
            List<int> decrypted = new List<int>();
            string message = text.Groups["message"].Value;
            foreach (var item in message)
            {
                //int current = (int)item;
                decrypted.Add(item);
            }
            string result = string.Join(" ", decrypted);
            Console.WriteLine($"{command}: {result}");
        }
    }
}