using System;

namespace Corgdirile.Library
{
    public static class ColorsLines
    {
        public enum SetColor : int { Black, DarkBlue, DarkGreen, DarkCyan, DarkRed, DarkMagenta, DarkYellow, DarkGray, Gray, Blue, Green, Cyan, Red, Magenta, Yellow, White };
        public static bool Ask() {
            Console.Write("(Yes = ");ColorsLines.WriteC("Y", SetColor.Green);
            Console.Write(")/(No = ");
            ColorsLines.WriteC("Another One", SetColor.Red);Console.Write("): ");
            return Console.ReadKey().KeyChar.ToString().ToLower().Equals("y");
        }
        public static void WriteC(string write, SetColor color)
        {
            switch (color)
            {
                case SetColor.Black: // 0
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Write(write); Console.ResetColor();
                    break;
                case SetColor.DarkBlue: // 1
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write(write); Console.ResetColor();
                    break;
                case SetColor.DarkGreen: // 2
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(write); Console.ResetColor();
                    break;
                case SetColor.DarkCyan: // 3
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write(write); Console.ResetColor();
                    break;
                case SetColor.DarkRed: // 4
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(write); Console.ResetColor();
                    break;
                case SetColor.DarkMagenta: // 5
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write(write); Console.ResetColor();
                    break;
                case SetColor.DarkYellow:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(write); Console.ResetColor();
                    break;
                case SetColor.DarkGray:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write(write); Console.ResetColor();
                    break;
                case SetColor.Gray:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(write); Console.ResetColor();
                    break;
                case SetColor.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(write); Console.ResetColor();
                    break;
                case SetColor.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(write); Console.ResetColor();
                    break;
                case SetColor.Cyan:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(write); Console.ResetColor();
                    break;
                case SetColor.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(write); Console.ResetColor();
                    break;
                case SetColor.Magenta:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(write); Console.ResetColor();
                    break;
                case SetColor.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(write); Console.ResetColor();
                    break;
                case SetColor.White:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(write); Console.ResetColor();
                    break;
                default:
                    //Console.Write(write); Console.Write("(Error:ForegroundColor " + '"' + (color != null ? color + '"' + "not found." : SetColor.You did not choose a color"));
                    break;
            }
        }
        public static void WriteLineC(string write, SetColor color)
        {
            switch (color)
            {
                case SetColor.Black:
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                case SetColor.DarkBlue:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                case SetColor.DarkGreen:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                case SetColor.DarkCyan:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                case SetColor.DarkRed:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                case SetColor.DarkMagenta:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                case SetColor.DarkYellow:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                case SetColor.DarkGray:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                case SetColor.Gray:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                case SetColor.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                case SetColor.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                case SetColor.Cyan:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                case SetColor.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                case SetColor.Magenta:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                case SetColor.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                case SetColor.White:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                default:
                    //Console.Write(write); Console.Write("(Error:ForegroundColor " + '"' + (color != null ? color + '"' + "not found." : SetColor.You did not choose a color"));
                    break;
            }
        }
        public static void BackgroundC(string write, SetColor color)
        {
            switch (color)
            {
                case SetColor.Black:
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                case SetColor.DarkBlue:
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                case SetColor.DarkGreen:
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                case SetColor.DarkCyan:
                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                case SetColor.DarkRed:
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                case SetColor.DarkMagenta:
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                case SetColor.DarkYellow:
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                case SetColor.DarkGray:
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                case SetColor.Gray:
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                case SetColor.Blue:
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                case SetColor.Green:
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                case SetColor.Cyan:
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                case SetColor.Red:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                case SetColor.Magenta:
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                case SetColor.Yellow:
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                case SetColor.White:
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine(write); Console.ResetColor();
                    break;
                default:
                    //Console.Write(write); Console.Write("(Error:BackgroundColor " + '"' + (color != null ? color + '"' + "not found." : SetColor.You did not choose a color"));
                    break;
            }
        }
        public static string ReadLineC( SetColor color)
        {
            switch (color)
            {
                case SetColor.Black:
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case SetColor.DarkBlue:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case SetColor.DarkGreen:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case SetColor.DarkCyan:
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case SetColor.DarkRed:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    break;
                case SetColor.DarkMagenta:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    break;
                case SetColor.DarkYellow:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    break;
                case SetColor.DarkGray:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case SetColor.Gray:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                case SetColor.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case SetColor.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case SetColor.Cyan:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case SetColor.Red:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case SetColor.Magenta:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case SetColor.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case SetColor.White:
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    //Console.WriteLine("(Error:ForegroundColor " + '"' + (color != null ? color + '"' + "not found." : SetColor.You did not choose a color"));
                    break;
            }
            string res = Console.ReadLine();
            Console.ResetColor();
            return res;
        }
    }
}