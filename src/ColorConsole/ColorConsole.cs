using ColorConsole.Fonts;
using System;
using System.Collections.Generic;

namespace ColorConsole
{
    /// <summary>
    /// The main class of the library
    /// Allows to interact with the console
    /// </summary>
    public static class CConsole
    {
        /// <summary>
        /// Used to write a line in the console
        /// </summary>
        /// <param name="value">The text to write</param>
        /// <param name="color">The color that must be used</param>
        public static void WriteLine(string value, ConsoleColor color=ConsoleColor.White)
        {
            var previousColor = Console.ForegroundColor;
            try
            {
                Console.ForegroundColor = color;
                Console.WriteLine(value);
            }
            finally
            {
                Console.ForegroundColor = previousColor;
            }
        }
        /// <summary>
        /// Used to write text in the console
        /// </summary>
        /// <param name="value">The text to write</param>
        /// <param name="color">The color that must be used</param>
        public static void Write(string value, ConsoleColor color = ConsoleColor.White)
        {
            var previousColor = Console.ForegroundColor;
            try
            {
                Console.ForegroundColor = color;
                Console.Write(value);
            }
            finally
            {
                Console.ForegroundColor = previousColor;
            }
        }


        /// <summary>
        /// Used to write a line in the console
        /// </summary>
        /// <param name="value">The text to write</param>
        /// <param name="color">The color that must be used</param>
        public static void WriteLine<F>(string value, ConsoleColor color = ConsoleColor.White, FontDefinition fontDefinition = null)
            where F : Font, new()
        {
            var font = Activator.CreateInstance<F>();
            var text = font.Convert(value, fontDefinition);
            WriteLine(text, color);
        }

        /// <summary>
        /// Used to write text in the console
        /// </summary>
        /// <param name="value">The text to write</param>
        /// <param name="color">The color that must be used</param>
        public static void Write<F>(string value, ConsoleColor color = ConsoleColor.White,  FontDefinition fontDefinition = null)
            where F : Font, new()
        {
            var font = Activator.CreateInstance<F>();

            var text = font.Convert(value, fontDefinition);
            WriteLine(text, color);
        }
    }
}
