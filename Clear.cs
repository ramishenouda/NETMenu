using System;

namespace NETMenu
{
    class Clear
    {
        public static void ClearAll()
        {
            Console.Clear();
        }

        public static void ClearLine(int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(x, y);
        }
    }
}