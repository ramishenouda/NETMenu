using System;

namespace NETMenu
{
    class Write
    {
        public static void Middle(string s, bool textCenter = false, int x = 0, int y = 0)
        {
            if (!textCenter)
                Console.SetCursorPosition(Math.Abs((Console.WindowWidth / 2) + x), Math.Abs((Console.WindowHeight / 2) + y));
            else
                Console.SetCursorPosition(Math.Abs(((Console.WindowWidth - s.Length) / 2) + x), Math.Abs((Console.WindowHeight / 2) + y));
            
            Console.Write(s);
        }
    }
}