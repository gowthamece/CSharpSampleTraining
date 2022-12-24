using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSample
{
    public class BookSample
    {
        public List<double> grades;  // class memeber or Field

        public string name;

        public BookSample( string name)
        {
            grades = new List<double>();

            this.name = name;
        }

        public void displayName()
        {
            Console.WriteLine(name);
            Console.ReadKey();
             
        }
        public void AddGrade(double grade) //Class member function 
        {
            grades.Add(grade);

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
    }
}
