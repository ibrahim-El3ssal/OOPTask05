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
            
            #region Question06
            Console.WriteLine("\nQuestion6 : ");
            Console.WriteLine("\n OOP 01 - Smart Delivery Management System  :Theoretical Questions ");
            // Question01 : 
            /// a)  What happens when a DeliveryAddress variable is copied into another variable and the copy is modified ?
            //result a : When a DeliveryAddress variable is copied into another variable, a completely independent copy of the value is created in memory (Value Copy).
            //Modifying the copied variable will NOT affect the original variable .


            /// b)  What happens when a Customer variable is copied into another variable and one variable modifies the object 

            // result B: 
            //Both variables will point to the same object in the Heap. Therefore,
            //modifying the object through either variable will affect the original object,
            //and the changes will be reflected in both variables.   


            //Question 02 : 
            //Result A : Three problems with ( Encapsulation ):
            //Anyone can modify data directly with invalid values.
            //Renaming a field breaks all external code.
            //Exposes internal implementation details.

            //Result B :Private Fields with Properties
            // Restricts direct access to internal fields.

            #endregion

            #region Question07
            Console.WriteLine("\nQuestion7 : ");

            DeliveryAddress D01 = new DeliveryAddress("Giza" , "Orabi" , 1 );

            DeliveryAddress D02 = D01;
            Console.WriteLine($"before (D01): {D01.GetFullAddress()}");

            D02.City = "Alexandria";
            D02.BuildingNumber = 25;

            Console.WriteLine($" after(D01): {D01.GetFullAddress()}");
            Console.WriteLine($" (D02): {D02.GetFullAddress()}");

            #endregion

            #region Question08
            /// 2.Ceate a Shipment struct 
            /// 
            #endregion

            #region Question09
            /// 3.Add constructor overloading to Shipment:

            #endregion

            #region Question10
            // 4. Add the following methods to Shipment: 

            #endregion
            // Pause screen execution
            Console.ReadLine();

        }
    }
}
