using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            album a = new album();

            while (command != "quit")
            {
                Console.Write("> Photo-Album : ");
                command = Console.ReadLine();
                command = a.getAlbums(command);
            }
        }

        
    }
}
