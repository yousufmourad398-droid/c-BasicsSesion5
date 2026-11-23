namespace c_BasicsSesion5
{
    enum Genre
    {
        Fiction,
        NonFiction,
        Science
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Access Modifiers
            //Book book = new Book();
            // // Console.WriteLine(book.password);
            // // يسبب خطأ وقت الترجمة (Compile-time error)
            //Console.WriteLine(book.copiesInStock);
            // // print 5
            //book.Title = "C# Basics";
            //Console.WriteLine(book.Title);
            // // print C# Basics

            #endregion 


            #region enum
            //4
            //Book book = new Book();
            //book.Genre = Genre.Science;
            //5
            //Console.WriteLine(book.Genre);
            //Console.WriteLine((int)Genre.Fiction);    // 0
            //Console.WriteLine((int)Genre.NonFiction); // 1
            //Console.WriteLine((int)Genre.Science);    // 2
            //6
            //int genreNumber = 1;
            //Genre genreFromNumber = (Genre)genreNumber;
            //Console.WriteLine(genreFromNumber); // NonFiction
            //7
            //string genreText = "Science";
            //Genre parsedGenre = (Genre)Enum.Parse(typeof(Genre), genreText);
            //Console.WriteLine(parsedGenre); // Science
            //8
           // string genreText = "Mystery";
           //bool isParsed =   Enum.TryParse(genreText, out Genre result);
           // if (isParsed)
           // {
           //     Console.WriteLine(result);
           // }
           // else
           // {
           //     Console.WriteLine("Unknown genre");
           // }
            #endregion
        }
    }
}
