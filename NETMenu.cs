using System;
using System.Collections.Generic;

namespace NETMenu
{
    public class Menu
    {
        public Menu (int HorizontalPadding = 0, int VerticalPadding = 1)
        {
            this.HorizontalPadding = HorizontalPadding;
            this.VerticalPadding = VerticalPadding;            
        }

        List<string> items = new List<string>();

        bool isChoosing = true;

        bool showCursor = false;

        bool initialCursorState = Console.CursorVisible;

        bool textCenter = false;

        bool showArrow = true;

        string selectSymbol = ">";

        ConsoleColor textColor = ConsoleColor.White;
        ConsoleColor selectedTextColor = ConsoleColor.Red;
        ConsoleColor arrowColor = ConsoleColor.White;
        ConsoleColor initialColor = Console.ForegroundColor;
    
        int HorizontalPadding = 0;
        int VerticalPadding = 1;
        int CurrentHoverItemIndex = 0;


        /// <summary>
        /// Starts the menu system.
        /// <para> The function returns an integer when the user clicks on the (Enter key). </para>
        /// <para> The integer value is 0 for the first item, 1 for the second item, and n for the nth item. </para>
        /// </summary>
        public int Start()
        {
            Clear.ClearAll();
            Console.CursorVisible = showCursor;

            while (isChoosing)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    if (i == CurrentHoverItemIndex)
                    {
                        //Choose Hover Item Color
                        if (showArrow && textCenter)
                        {
                            Console.ForegroundColor = arrowColor;
                            Write.Middle(selectSymbol, textCenter, -((items[i].Length / 2) + selectSymbol.Length), i * VerticalPadding);
                        }

                        else if (showArrow && !textCenter)
                        {
                            Console.ForegroundColor = arrowColor;
                            Write.Middle(selectSymbol, textCenter, -selectSymbol.Length, i * VerticalPadding);
                        }

                        Console.ForegroundColor = selectedTextColor;
                        Write.Middle(items[i], textCenter, i * HorizontalPadding, i * VerticalPadding);
                        //Normal Item Color
                        Console.ForegroundColor = textColor;
                        continue;
                    }

                    Write.Middle(items[i], textCenter, i * HorizontalPadding, i * VerticalPadding);
                }

                CheckForMenuInput();
                Clear.ClearAll();
            }

            isChoosing = true;

            Console.ForegroundColor = initialColor;
            Console.CursorVisible = initialCursorState;

            return CurrentHoverItemIndex;
        }

        /// <summar>
        /// Adds item to the menu list.
        /// </summar>
        public void AddItem(string s)
        {
            try 
            {
                items.Add(s);
            }
            catch(Exception e)
            {
                Console.WriteLine("Error while adding the item to the list\n" + e);
            }
        }

        /// <summar>
        /// Adds items to the menu list.
        /// </summar>
        public void AddItems(params string[] items)
        {
            try 
            {
                this.items.AddRange(items);
            }

            catch(Exception e)
            {
                Console.WriteLine("Error while adding the items to the list\n" + e);
            }
        }

        /// <summary>
        /// Clears the menu items.
        /// </summary>
        public void ResetMenu()
        {
            isChoosing = true;
            items.Clear();
            CurrentHoverItemIndex = 0;
        }

        /// <summary>
        /// Adds Horizontal Padding, default is 0;
        /// </summary>
        public void SetHorizontalPadding(int x)
        {
            HorizontalPadding = x;   
        }

        /// <summary>
        /// Adds Vertical Padding. default is 1.
        /// </summary>
        public void SetVerticalPadding(int y)
        {
            VerticalPadding = y;   
        }

        /// <summary>
        /// Sets the menu font color. default is White.
        /// </summary>
        public void SetMenuFontColor(ConsoleColor color)
        {
            textColor = color;
        }

        /// <summary>
        /// Sets the menu symbol color. default is White.
        /// </summary>
        public void SetSelectSymbolColor(ConsoleColor color)
        {
            arrowColor = color;
        }

        /// <summary>
        /// Sets the menu Select symbol. default is >.
        /// </summary>
        public void SetSelectSymbol(string symbol)
        {
            selectSymbol = symbol;
        }

        /// <summary>
        /// Sets the menu Select symbol. default is >.
        /// </summary>
        public void SetSelectSymbol(char symbol)
        {
            selectSymbol = symbol + "";
        }

        /// <summary>
        /// Sets the selected text color. default is Red.
        /// </summary>
        public void SetSelectedTextColor(ConsoleColor color)
        {
            selectedTextColor = color;
        }

        /// <summary>
        /// Centers the menu text.
        /// </summary>
        public void CenterText()
        {
            textCenter = true;
        }

        /// <summary>
        /// Disables the select symbol.
        /// </summary>
        public void DisableSymbol()
        {
            showArrow = false;
        }

        /// <summary>
        /// Enables the cursor.
        /// </summary>
        public void EnableCursor()
        {
            showCursor = true;
        }

        void CheckForMenuInput()
        {
            var key = Console.ReadKey().Key;

            if (key == ConsoleKey.W || key == ConsoleKey.UpArrow)
            {
                if (CurrentHoverItemIndex != 0)
                    CurrentHoverItemIndex--;
            }

            if (key == ConsoleKey.S || key == ConsoleKey.DownArrow)
            {
                if (CurrentHoverItemIndex != items.Count - 1)
                    CurrentHoverItemIndex++;
            }

            if (key == ConsoleKey.Enter)
            {
                isChoosing = false;
            }
        }
    }
}

