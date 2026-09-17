using C_BasicsTask04;
using System.Drawing;
using System.Reflection;

namespace OOP01Task05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question01
            /// 4-Declare an enum Genre { Fiction, NonFiction, Science }. 
            /// Add a Genre  property to Book,  assign it Genre.Science, and print it.  
            Console.WriteLine("Question01 : ");
            /// 
            Book book01 = new Book();
            book01.Genre = Genre.Science;  

            Console.WriteLine(book01.Genre);
            #endregion

            #region Question02
            /// 5-Using the Genre enum above, print the underlying int value of Genre.Fiction,
            /// Genre.NonFiction, and Genre.Science by casting each to int.
            /// 
            Console.WriteLine("\nQuestion02 : ");

            Console.WriteLine((int)Genre.Fiction); 
            Console.WriteLine((int)Genre.NonFiction);
            Console.WriteLine((int)Genre.Science);

            #endregion

            #region Question03
            /// 6-Given int genreNumber = 1;, cast it into a Genre value and print the result.  
            Console.WriteLine("\nQuestion03 : ");

            int genreNumber = 1;
            Genre genreName = (Genre)genreNumber;
            Console.WriteLine(genreName);
            //Console.WriteLine((Genre)genreNumber);

            #endregion

            #region Question04
            ///   7 - Given string genreText = "Science";, convert it into a Genre value using Enum.Parse() and print the result. 
            ///
            Console.WriteLine("\nQuestion04 : ");

            string genreText = "Science";
            Genre value = (Genre) Enum.Parse(typeof(Genre), genreText );
            Console.WriteLine(value);

            #endregion



            #region Question05
            /// -Given string genreText = "Mystery"; (not a valid Genre value), use 
            /// Enum.TryParse() to attempt the conversion.  Print "Unknown genre"  if it  fails.
            Console.WriteLine("\nQuestion05 : ");

            string genreText2 = "Mystery";
            object  result  ; 

            if (!Enum.TryParse(typeof(Genre), genreText2, true, out result))
            {
                Console.WriteLine("Unknown genre"); 
            }
            
            #endregion
            // Pause screen execution
            Console.ReadLine();

        }
    }
}
