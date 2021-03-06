﻿using System;
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

    //"albumId": 1,
    //"id": 1,
    //"title": "accusamus beatae ad facilis cum similique qui sunt",
    //"url": "http://placehold.it/600/92c952",
    //"thumbnailUrl": "http://placehold.it/150/30ac17"

    public class album
    {
        static string baseUrl = "https://jsonplaceholder.typicode.com/photos";

        public int albumID;
        public int ID;
        public string title;
        public string url;
        public string thumbnailUrl;

        public string getAlbums(string command)
        {

            int result = 0;
            string url = baseUrl;

            if (int.TryParse(command, out result) || command == "")
            {
                if(command != "")
                {
                    url = url + "?albumId=" + command;
                }

                //Send webRequest
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                //Get the Web Response
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                //Now, create the Stream
                Stream responseStream = response.GetResponseStream();
                //Seting Up the Stream Reader
                StreamReader readerStream = new StreamReader(responseStream, System.Text.Encoding.GetEncoding("utf-8"));

                //Get in a STring
                string json = readerStream.ReadToEnd();

                //Close the Stream
                readerStream.Close();

                var albums = JsonConvert.DeserializeObject<List<album>>(json);
                if (albums.Count() > 0)
                {
                    foreach (album album in albums)
                    {
                        Console.WriteLine("[{0}] \t{1}", album.ID, album.title);
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, we did not find any albums under that Id.");
                }
            }
            else
            {
                if (command == null)
                {
                    Console.WriteLine("You get nothin' 4 nothin' . . .  ");
                }
                else if (command != "quit")
                {
                    Console.WriteLine("Sorry, we only accept Integers or cash!");
                }
            }
            return command;
        }
    }


}
