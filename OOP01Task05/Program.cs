using C_BasicsTask04;
using System.Drawing;

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


            // Pause screen execution
            Console.ReadLine();
        }
    }
}
