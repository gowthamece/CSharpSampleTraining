using CSharpSample.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http.Headers;
//using System.Runtime.Remoting.Services;
//using System.Text;
//using System.Threading.Tasks;

namespace CSharpSample
{

    internal class Program
    {
        static void Main(string[] args)  // Caluclating the average for a students --> behaviour of the class 
        {
            //double x  = 21.10;
            //var y = 20.22;

            // VairableEx vairableEx = new VairableEx("bob","jose"); //object creation in C#
            //  vairableEx.FirstName = "bob"; 
            //   vairableEx.LastName = "jose";
            //  Console.WriteLine(vairableEx.FirstName);
            //  Console.WriteLine(vairableEx.LastName);
            //  vairableEx.PrintName();
            // Console.ReadKey();
            //  Console.WriteLine(vairableEx.LastName);





            ////float c = 10.00F;

            //var c = x + y;
            //Console.WriteLine(c);

            // Array Example 

            //double[] numbers;  /Declaring the array 
            //numbers[0] = 14.7;
            //numbers[1] = 20.7;

            //assign Values to array 

            //double[] number = new double[3]; // Intializing the array 
            //number[0] = 10.4;   //Set value to array 
            //number[1] = 11.4;
            //number[2] = 12.4;

            ////Adding values 
            //var result = number[0];
            //result += number[1];           
            //result += number[2];
            //var result1 = result;
            //Console.WriteLine(result1);

            //var resultConvection = number[0] + number[1] + number[2];
            //Console.WriteLine(resultConvection);
            //Console.ReadKey();

            //Better syntaxing 

            //double[] numbers = new double[3] { 10.4, 11.4, 12.4 };

            //Console.WriteLine(numbers[0]);
            //Console.ReadKey();


            //C# Compiler Job 

            // double[] numberTemp = new double[] { 10.4, 11.4, 12.4, 10.4 };

            //more better 

            //    var finalArray = new[] { 10.4, 11.4, 12.4, 10.4 };



            //looping 

            //var result = 0.0;

            //foreach(double num in finalArray)
            //{
            //    result += num;
            //}
            //var avg=result/finalArray.Length;
            //Console.WriteLine($"Average:{avg}");   // String Interpolation 
            //Console.ReadKey();

            // -------------------Collections-------------------------------------//


            //List grades;

            //C# Collection Intialization

            //List<double> grades = new List<double>();  // Intialization - Memory allocation 

            //List<double> gradesInt = new List<double>() { 10.4, 11.4, 12.4, 10.4 };
            //gradesInt.Add(12.12);
            //gradesInt.Add(10.6);
            //gradesInt.Add(11.3);

            //var listResult = 0.0;
            //foreach (double num in gradesInt)
            //{

            //    listResult = listResult + num;
            //}
            //Console.WriteLine(listResult / gradesInt.Count);

            //Console.WriteLine($"The avaerage:  {(listResult / gradesInt.Count):N3}");
            //Console.ReadKey();

            //------------------------------------------------------------------------------//

            //Caluate the lowest score for the student 
            // and the highest score of the student 


            // ------------------------ Classes and Object ----------------------------//

            //var book = new BookSample();

            //book.AddGrade(10.13);

            //string bookName = "Sachin's book"; //similar to ""

            //var book = new BookSample(bookName);

            //book.AddGrade(10);
            //book.AddGrade(20);
            //book.AddGrade(30);

            //book.AddGrade(100);
            //book.Name = "Hello Property";
            //Console.WriteLine(book.Name);
            //while (true)
            //{
            //    Console.WriteLine("Enter a Grade or q to quit");
            //    Console.WriteLine("Enter A or B to get the value");

            //    var input = Console.ReadLine(); // Get a input from a user
            //    if (input == "q")
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        try
            //        {
            //            var grade = double.Parse(input);
            //            book.AddGrade(grade);


            //        }
            //        catch (Exception ex)
            //        {
            //            book.AddGrade(char.Parse(input));
            //            // Console.WriteLine(ex.Message);
            //        }
            //    }
            //    //{
            //    break;
            //}
            //var grade = double.Parse(input);
            //book.AddGrade(grade);
            //try
            //{
            //    var grade = double.Parse(input);
            //    book.AddGrade(grade);
            //}
            //catch (ArgumentException ex)
            //{ Console.WriteLine(ex.Message); }
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally // Code will always execute
            //{
            //    Console.WriteLine("***");
            //}

            //  }
            //book.ComputeAverage();
            //--------------------------------------------------------------------------------------------//

            //--------------------------------------Abstract Class ----------------------------------------//

            //var bookSample = new BookSample("Sachin book");

            //EnterGrade(bookSample);
            //bookSample.ComputeAverage();
            //Console.ReadKey();

            //var studentSample = new StudentSample("Sachin book");
            //studentSample.AddGrade(10);
            //studentSample.ComputeAverage();
            //Console.ReadKey();

           // var diskBook = new DiskBook("Sachin");
           // diskBook.AddGrade(50);
           // var result= diskBook.ListofNumbers();
           // Displayint(result);
           // Console.ReadKey();

            IBookBase diskBook = new DiskBook("Sachin");
      
            var result = diskBook.ListofNumbers();
            Displayint(result);
            Console.ReadKey();

            // diskBook.AddGrade(20);




            //---------------------------------------- Interface -------------------------------------------// 

            //IBook book2 = new DiskBook("Sachin book");
            //EnterGrade(book2);
            //book2.ComputeAverage();
            //Console.ReadKey();

            //-------------------------------------------------------------------------------------------------//

            //Reference Type 

            // var book = new Book("My books");
            // var book1 = new Book("My book1");

            //copying a object 

            //var  book1 = book;
            //var result = object.ReferenceEquals(book, book1);
            //Console.WriteLine(book1.name);
            //Console.ReadKey();

            //Passing parameter by Value 

            //var book = new Book("My books");
            //book.SetName(book, "My old book");
            //Console.WriteLine(book.name);
            //Console.ReadKey();

            //Passing paremeter by Reference 
            //var bookRef = new Book("My books");
            //bookRef.SetNameByReference(ref bookRef, "My old book");
            //Console.WriteLine(bookRef.name);
            //Console.ReadKey();

            //--------------------------------------------------------------------------------------//


            //  }


        }

        public static void Displayint(List<int> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        public async static void EnterGrade(BookSample book)
        {
            while (true)
            {
                Console.WriteLine("Enter a Grade or q to quit");
                Console.WriteLine("Enter A or B to get the value");

                var input = Console.ReadLine(); // Get a input from a user
                if (input == "q")
                {
                    break;
                }
                else
                {
                    try
                    {
                        var grade = double.Parse(input);
                        book.AddGrade(grade);


                    }
                    catch (Exception ex)
                    {
                        book.AddGrade(char.Parse(input));
                        // Console.WriteLine(ex.Message);
                    }
                }
            }

        }
    }
}
