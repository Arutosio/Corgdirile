using System;
using Corgdirile.Library;
//using static Corgdirile.Library.ColorsLines;
//using sc = Corgdirile.Library.ColorsLines.SetColor;
using static Corgdirile.Library.ColorsLines.SetColor;

namespace Corgdirile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write the path where will get all files: ");
            ColorsLines.ReadLineC(Yellow);
        }
    }
}