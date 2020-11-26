using System;
using System.Security.AccessControl;
using System.Collections.Generic;

namespace AdventureGameWDP
{
    /*    
    [Big Brain Brennan]
    [A silly text-based adventure game]
    [Wyatt Donnelley-Power]
    [11/03/2020]
    Uses elements from "Programming Is Fun: C# Code Adventure" by Janell Baxter: http://programmingisfun.com/learn/c-sharp-adventure-game/
    */


    class Program
    { 
        static void Main()
        {
            
            Game.StartGame();
            Game.EndGame();

            Console.ReadKey();
        }
    }
}
