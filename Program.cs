﻿using System;
using System.IO;
using Newtonsoft.Json;

namespace AuthorSerialize
{
    public class Program
    {
        static void Main(string[] args)
        {
            AuthorFactory factory = new AuthorFactory();
            Author author = new Author();

            author = factory.CreateAuthor();

            string str = JsonConvert.SerializeObject(author,Formatting.Indented);
            System.Console.WriteLine(str);

            //serialize to a file --> serialize means to convert an object 
            //representation in memory to a representation on disk/wire. In this casse the 
            //object representation is being stored on disk as a file

            //Serialization is differnt than converting the properties of a type to string
            //and writing them to a file. Here the responsibility of storing the memory based
            //representation of the object to disk belongs to the object itself. 
            using (StreamWriter file = File.CreateText(@".\author.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, author);
            }


        }
    }
}
