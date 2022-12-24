using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSample
{
    public class Book
    {
        List<double> grades;
        public string name;

        //Constructor 
          
          public Book()
            {
            grades = new List<double>();
            }
        //parameterized contructor
        public Book(string name )
        {
            grades = new List<double>();
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);

        }

        
        public void SetName(Book book,string name)
        {
            book = new Book(name);
            Console.WriteLine(book.name);
          
        }

        public void ComputeAverage()
        {
            var listResult = 0.0;
            foreach (double num in grades)
            {
                listResult = listResult + num;
            }
            Console.WriteLine(listResult / grades.Count);

            Console.WriteLine($"The avaerage:  {(listResult / grades.Count):N3}");
            Console.ReadKey();
        }

        public void SetNameByReference(ref Book book, string name)
        {
            book = new Book(name);
            Console.WriteLine(book.name);
        }
    }
}
