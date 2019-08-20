using System;
using System.IO;
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
            //Fase Preparing..
            Console.WriteLine("AHAHAHAHAHAAHAHAHAHAHAHA");
            string pathSource = SetDirectory("Write the path where will get all files: ");
            string pathDestination = SetDirectory("Inserisci il nome della directori di destinazione: ");
            //string[] allfiles = Directory.GetFileSystemEntries(pathSource);
            string[] allfiles = Directory.GetFiles(pathSource, "*", SearchOption.AllDirectories);
            // Fase Processing..
            for (int i = 0; i < allfiles.Length; i++) {
                string fileName = Path.GetFileName(allfiles[i]);
                string yearFile = File.GetCreationTime(allfiles[i]).Year.ToString();
                string monthFile = File.GetCreationTime(allfiles[i]).Month.ToString();
                Console.Write($"File Num: {i+1} - Name: ");ColorsLines.WriteLineC(fileName,Cyan);
                CreateFolder(pathDestination, yearFile);
                CreateFolder(Path.Combine(pathDestination, yearFile), yearFile+"-"+monthFile);
                MoveFile(allfiles[i], fileName, Path.Combine(pathDestination, yearFile, yearFile+"-"+monthFile)); // PathTooLongException move file
            }
        }
        public static string SetDirectory(string dir) {
            Console.Write(dir);
            dir = @ColorsLines.ReadLineC(Yellow);
            while(!Directory.Exists(dir)) {
                Console.Write("The specified directory does not exist.\r\nPlease try again: ");
                dir = @ColorsLines.ReadLineC(Yellow);
            }
            return dir;
        }
        public static void CreateFolder(string path, string name)
        {
            try
            {
                // Determine whether the directory exists.
                if (!Directory.Exists(Path.Combine(path, name))) {
                    Console.Write("    Creating folder in: "); ColorsLines.WriteLineC(path, DarkYellow);
                    Console.Write("    Name: "); ColorsLines.WriteC(name, Yellow);
                }
                else return;

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(Path.Combine(path, name));
                Console.Write(" - ");ColorsLines.WriteC("Done!", Green);Console.Write(" - In the: ");
                ColorsLines.WriteLineC(Directory.GetCreationTime(Path.Combine(path, name)).ToString(), Magenta);

                // Delete the directory.
                //di.Delete();
                //Console.WriteLine("The directory was deleted successfully.");
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"The process failed: {0}",e); Console.WriteLine(e.ToString());
                Console.ResetColor();
            }
            finally { }
        }
        public static string MoveFile(string filePath, string fileName, string newPath) {
            Console.Write("    Moving File: "); 
            ColorsLines.WriteLineC(filePath, DarkYellow);
            File.Move(filePath, Path.Combine(newPath, fileName)); // PathTooLongException move file
            Console.Write("   in to "); ColorsLines.WriteC(newPath+'/', Yellow); ColorsLines.WriteC(fileName, Cyan);
            Console.Write(" ... "); ColorsLines.WriteLineC("Done!\r\n", Green);
            return newPath;
        }
    }
}