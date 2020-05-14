using System;
using System.Collections;
using System.IO;
using Corgdirile.Library;
//using static Corgdirile.Library.ColorsLines;
//using sc = Corgdirile.Library.ColorsLines.SetColor;
using static Corgdirile.Library.ColorsLines.SetColor;

namespace Corgdirile
{
    class Program
    {
        public static ArrayList errorList;
        public static int orderBy = 0;
        static void Main(string[] args)
        {
            bool isRenameFile = false;
            Console.WriteLine("  ---        <-_ Welcome Corgdirile by Arutosio_->        ---  ");
            Console.Write("  ~  "); ColorsLines.WriteC("For more info: https://github.com/Arutosio/Corgdirile", Cyan); Console.WriteLine("  ~  ");
            do {
                errorList = new ArrayList();
                Console.WriteLine();
                //Fase Preparing..
                LineFase("Setup");
                string pathSource = SetDirectory("Write the files path: ");
                string pathDestination = SetDirectory("Write the destination path: ");
                Console.Write("Press the "); ColorsLines.WriteC("Y", Green); Console.Write(" Do you want rename files with the num count? "); ColorsLines.WriteC("exit", Red); Console.Write(": ");
                isRenameFile = Console.ReadKey().KeyChar.ToString().ToLower().Equals("y");
                ChooseOrder();
                //string[] allfiles = Directory.GetFileSystemEntries(pathSource);
                // Fase Processing..
                LineFase("Processing");
                string[] allfiles = Directory.GetFiles(pathSource, "*", SearchOption.AllDirectories);
                FileInfo[] allFileInfos = new FileInfo[allfiles.Length];
                for(uint i = 0; i < allfiles.Length; i++)
                {
                    allFileInfos[i] = new FileInfo(allfiles[i]);
                }

                for (int i = 0; i < allFileInfos.Length; i++) {
                    DateTime fileDate = OrderBy(allFileInfos[i]);
                    string yearFile = fileDate.Year.ToString();
                    string monthFile = fileDate.Month.ToString();
                    Console.Write($"File Num: {i+1} - Name: ");ColorsLines.WriteLineC(allFileInfos[i].Name, Cyan);
                    CreateFolder(pathDestination, yearFile);
                    CreateFolder(Path.Combine(pathDestination, yearFile), yearFile+"-"+monthFile);
                    string fullPath = Path.Combine(pathDestination, yearFile, $"{yearFile}-{monthFile}");
                    
                    MoveFile(allFileInfos[i], fullPath, i+1, isRenameFile); // PathTooLongException move file
                }
                Console.Write("Do you wont to delete all empy folders?"); 
                if(ColorsLines.Ask()) {
                    DelleteEmptyFolder(pathSource);
                }
                PrintErrors();
                Console.Write("\r\n======> "); ColorsLines.WriteC("PROCESS FINISH!", Green); Console.WriteLine(" <======");
                Console.Write("Press the "); ColorsLines.WriteC("Y", Green); Console.Write(" key to execute again the program or press an other key to "); ColorsLines.WriteC("exit", Red); Console.Write(": ");
            }while(Console.ReadKey().KeyChar.ToString().ToLower().Equals("y"));
            Console.WriteLine();
        }
        public static void ChooseOrder() {
            bool isOk = true;
            Console.WriteLine("Choose number to order:");
            Console.WriteLine(" - 1 - Order by date of creation. (default)");
            Console.WriteLine(" - 2 - Order by date of last write.");
            Console.WriteLine(" - 3 - Order by date of last access.");
            do {
                try {
                    orderBy = Convert.ToInt32(Console.ReadKey().KeyChar.ToString()); isOk = false;
                } catch { Console.WriteLine("This  is not a number. Try again: "); }
            } while(isOk);
        }
        public static DateTime OrderBy(FileInfo file) {
            DateTime res = new DateTime();
            switch(orderBy) {
                case 1:
                    res = file.CreationTime;
                break;
                case 2:
                    res = file.LastWriteTime;
                break;
                case 3:
                    res = file.LastAccessTime;
                break;
                case 4:
                    res = file.CreationTime; // to change
                break;
                default:
                    res = file.CreationTime;
                break;
            }
            return res;
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
        private static void DelleteEmptyFolder(string startLocation)
        {
            foreach (var directory in Directory.GetDirectories(startLocation))
            {
                DelleteEmptyFolder(directory);
                if (Directory.GetFiles(directory).Length == 0 && Directory.GetDirectories(directory).Length == 0) {
                    Directory.Delete(directory, false);
                    ColorsLines.WriteC("Deleted DIR: ", Red);Console.Write(directory);ColorsLines.WriteLineC(" - Done!", Green);
                }
            }
        }
        public static void MoveFile(FileInfo fi, string newPath, int numFile, bool isRenameFile) {
            Console.Write("    Moving File: "); 
            ColorsLines.WriteLineC(fi.FullName, DarkYellow);
            try {
                //string nameOk = NameAdaptingToNotOvveride(Path.GetFileNameWithoutExtension(fi.Name), Path.Combine(newPath, fi.Name), fi.Extension);
                //nameOk += fi.Extension;
                //File.Move(fi.FullName, Path.Combine(newPath, fileName)); // PathTooLongException move file
                if(isRenameFile)
                {
                    Console.Write("   in to "); ColorsLines.WriteC(newPath+'\\', Yellow); ColorsLines.WriteC(numFile.ToString()+fi.Extension, Cyan);
                    fi.MoveTo(Path.Combine(newPath, $"{numFile}{fi.Extension}"), false);
                }
                else
                {
                    Console.Write("   in to "); ColorsLines.WriteC(newPath+'\\', Yellow); ColorsLines.WriteC(fi.Name, Cyan);
                    fi.MoveTo(Path.Combine(newPath, fi.Name), false);
                }
                Console.Write(" ... "); ColorsLines.WriteLineC("Done!\r\n", Green);
            } catch (Exception e) {
                Console.Write(" ... "); ColorsLines.WriteLineC("ERROR: \r\n", Red);
                errorList.Add($"Error with file N:{numFile} - {fi.FullName} MSG:\r\n {e}");
            }
            //return newPath;
        }
        public static void PrintErrors() {
            Console.Write("Do you want print the error files?"); ColorsLines.WriteC("Y", Green);Console.Write('/');ColorsLines.WriteC("AnyKey", Red);
            if(errorList.Count > 0 && Console.ReadKey().KeyChar.ToString().ToLower().Equals("y"))
                foreach (var errorFile in errorList)
                {
                    Console.WriteLine(errorFile);
                }
        }
        public static void LineFase(string text)
        {
            Console.BackgroundColor = ConsoleColor.White; Console.Write("::::::::::::::::::::::");
            ColorsLines.WriteC(text, Black);
            Console.BackgroundColor = ConsoleColor.White; Console.Write("::::::::::::::::::::::");
            Console.ResetColor(); Console.WriteLine();
        }
        public static string NameAdaptingToNotOvveride(string name, string destinationPath, string fiExtention)
        {
            string ret = name;
            if(File.Exists(Path.Combine(destinationPath, ret+fiExtention)))
            {
                if(ret.Contains("-c"))
                {
                    try {
                        uint n = uint.Parse(ret.Substring(ret.IndexOf("-c")+1, ret.Length));
                        ret.Replace($"-c{n}",$"-c{n+1}");
                    } catch { Console.WriteLine("Non è stato possibile spostare questo file."); }
                }
                else
                {
                    ret = ret + "-c1";
                }
                NameAdaptingToNotOvveride(ret, destinationPath, fiExtention);
            }
            return ret;
        }
    }
}