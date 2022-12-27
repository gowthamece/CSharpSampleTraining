using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CSharpSample
{
    public class Book : BookBase
    {
        List<double> grades;
        //  public string name;

        //Constructor 

        //public Book()
        //  {
        //  grades = new List<double>();
        //  }
        //parameterized contructor
        public Book(string name) : base(name)
        {
            grades = new List<double>();
            Name = name;
        }

        public  void AddGrade(char  letter)
        {
            switch(letter)
            {
                case 'A':
                    grades.Add(90);
                    break;
                case 'B':
                    grades.Add(80);
                    break;
                default:
                    grades.Add(0);
                    break;
            }    


        }
        public override void  AddGrade(double grade)
        {
            if(grade<100 && grade>0)
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid Grade");
            }
           
        }


        public void SetName(Book book, string name)
        {
            book = new Book(name);
            Console.WriteLine(book.Name);

        }

        public  override void ComputeAverage()
        {
            var listResult = 0.0;
            var lowestNumber = double.MaxValue;
            var highestNumber = double.MinValue;
            foreach (double num in grades)
            {
                listResult = listResult + num;
                lowestNumber = Math.Min(num, lowestNumber);
                highestNumber = Math.Max(num, highestNumber);
            }
            // do While 
            //var index = 0;
            //do
            //{
            //    listResult = listResult + grades[index];
            //    lowestNumber = Math.Min(grades[index], lowestNumber);
            //    highestNumber = Math.Max(grades[index], highestNumber);
            //    index++;

            //} while (index < grades.Count);
           
            //for loop 
            //for(var index=0;index<grades.Count; index++)
            //{
            //    listResult = listResult + grades[index];
            //    lowestNumber = Math.Min(grades[index], lowestNumber);
            //    highestNumber = Math.Max(grades[index], highestNumber);
            //}

            
            Console.WriteLine($"Book Name: {Name}");
            Console.WriteLine($"Lowest Number: {lowestNumber}");
            Console.WriteLine($"Highest Number: {highestNumber}");
            Console.WriteLine($"The average:  {(listResult / grades.Count):N3}");
            Console.ReadKey();
        }

        public void SetNameByReference(ref Book book, string name)
        {
            book = new Book(name);
            Console.WriteLine(book.Name);
        }

        public static void EnterGrades(Book book)
        {
            while (true)
            {
                Console.WriteLine("Enter Grade q to quit");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                } 

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }
    }
    public abstract class BookBase: NamedObject, IBook
    {
        public BookBase(string name) : base(name)
        {
        }

        public abstract void AddGrade(double grade);
        public abstract void ComputeAverage();
        
       
    }

    public interface IBook
    {
        void AddGrade(double grade);
        string Name { get; }
        void ComputeAverage();

    }
}
