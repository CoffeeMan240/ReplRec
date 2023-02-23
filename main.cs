using System;
using System.IO;

class Program {
    public static string d = Path.DirectorySeparatorChar.ToString();
    public static string DataPath = Environment.CurrentDirectory + d + "ServerData" + d;
    public static void Main (string[] args) {
    Console.WriteLine ("RepelRec- an experimental replit server for RR");
        new APIWSServer();
  }
}