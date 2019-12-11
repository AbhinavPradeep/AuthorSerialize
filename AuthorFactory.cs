namespace AuthorSerialize
{
    class AuthorFactory
    {
        public Author CreateAuthor()
        {
            Author Kishimoto = new Author();
            Kishimoto.FirstName = "Mashashi";
            Kishimoto.LastName = "Kishimoto";

            Address KishimotoAddress = new Address();
            KishimotoAddress.Country="Japan";
            KishimotoAddress.State="Okoyama Prefecture";
            KishimotoAddress.Street="Nagi";
            KishimotoAddress.HouseNum = 4269;

            Kishimoto.Address = KishimotoAddress;

            Book Naruto = new Book();
            Book Boruto = new Book("Boruto Uzumaki", "Shounen", "343434");

            Naruto.BookName = "Naruto";
            Naruto.Genre = "Shounen";
            Naruto.ISBNcode="1212212";

            Kishimoto.Books.Add(Naruto);
            Kishimoto.Books.Add(Boruto);

            return Kishimoto;
        }

        /* Create a saveauthor methodwhich takes a author as parameter and 
        saves the author to a file of his first name.
        Call save author from program , after moving the jsonserializer
        */


        /* stretch goal -- Create a loadauthor method which takes a author name
        and deserializes the author from file
        */
    }
}