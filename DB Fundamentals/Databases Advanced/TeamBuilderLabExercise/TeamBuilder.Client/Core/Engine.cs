﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBuilder.Client.Core
{
    public class Engine
    {
        private readonly CommandDispatcher commandDispatcher;

        public Engine(CommandDispatcher commandDispatcher)
        {
            this.commandDispatcher = commandDispatcher;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    string input = Console.ReadLine().Trim();
                    string[] data = input.Split(' ');
                    string result = this.commandDispatcher.DispatchCommand(data);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(result);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
