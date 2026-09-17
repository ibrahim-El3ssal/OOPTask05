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
            Book book01 = new Book();
            book01.Genre = Genre.Science;  

            Console.WriteLine(book01.Genre);
            #endregion

            #region Question02
            /// 5-Using the Genre enum above, print the underlying int value of Genre.Fiction,
            /// Genre.NonFiction, and Genre.Science by casting each to int.
            /// 

            Console.WriteLine((int)Genre.Fiction); 
            Console.WriteLine((int)Genre.NonFiction);
            Console.WriteLine((int)Genre.Science);


            #endregion
            // Pause screen execution
            Console.ReadLine();
        }
    }
}
