using System;
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


        }
    }
}
