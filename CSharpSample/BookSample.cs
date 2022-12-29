using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpSample
{
    public class BookSample
    {
        public List<double> grades;  // class memeber or Field

        public string name; 
        public string Name
        {
            get;set;
        }

        public BookSample(string name)
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
            if (grade <= 100 && grade > 0) 
            {
                grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid Grade");
            }
        }

        public void AddGrade(char grade) //Class member function  'A' 'B' '1'
        {
           switch(grade)
            {
                case 'A':
                    Console.WriteLine("Highest Grade");
                    break;
                case 'B':
                    Console.WriteLine("Average");
                    break;
                default:
                    Console.WriteLine("failed");
                    break;
            }
        }

        public void AddGrade(char grade,int numberGrade) //Class member function  'A' 'B' '1'
        {
            //
        }
        public void ComputeAverage()
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

            //for(int index = 0; index < grades.Count; index++)
            //{
            //    listResult = listResult + grades[index];
            //    lowestNumber = Math.Min(grades[index], lowestNumber);
            //    highestNumber = Math.Max(grades[index], highestNumber);
            //}
            //var index = 0;
            //do
            //{
            //    listResult = listResult + grades[index];
            //    lowestNumber = Math.Min(grades[index], lowestNumber);
            //    highestNumber = Math.Max(grades[index], highestNumber);
            //    index++;
            //} while(index<grades.Count);

            Console.WriteLine($"Book Name: {name}");
            Console.WriteLine($"Lowest Number: {lowestNumber}");
            Console.WriteLine($"Highest Number: {highestNumber}");
            Console.WriteLine($"The average:  {(listResult / grades.Count):N3}");
            Console.ReadKey();

        }
    }
}
