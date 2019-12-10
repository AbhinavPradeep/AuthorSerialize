namespace AuthorSerialize
{
    public class Book
    {
        public string BookName;
        public string Genre;
        public string ISBNcode;

        public Book()
        {
            
        }
        public Book(string BookName, string Genre, string ISBNCode)
        {
            this.BookName = BookName;
            this.Genre = Genre;
            this.ISBNcode = ISBNCode;
        }
    }
}