using System.Collections.Generic;
using System.Text.Json;

namespace AuthorSerialize
{
    public class Author
    {
        
        public string FirstName {get; set;}        
        public string LastName {get;set;}       
        public Address Address{get;set;}        
        public List<Book> Books {get;set;}
        public Author()
        {
            Address = new Address();
            Books = new List<Book>();
        } 
    }

}