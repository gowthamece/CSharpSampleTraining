using CSharpSample.AbstractClassDemo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharpSample
{
    public class BookSample: BookAbstractBase
    {
        public delegate string  WriteLogDelegate(string name); // Delegate
         
        public List<double> grades;  // class memeber or Field
        public const string CATEGORY="I'm Const Category";

     //   public string name; 
        public  readonly string category="I'm readonly category";

        public BookSample(string name) : base(name)
        {
            grades = new List<double>();
             Name = name;
        }

        

        //public BookSample(string name)
        //{
        //    grades = new List<double>();
        //    category = "Constructor Category";
        //    Name = name;
        //}

        public string ReturnMessage(string message)
        {
            return message;
        }

        public string AdditionalLog(string message)
        {
            return message.ToLower();
        }
        public string AdditionalLog1(string message)
        {
            return message.ToLower();
        }
        public void displayName()
        {

            Console.WriteLine(Name);
            Console.ReadKey();

        }
        public override void AddGrade(double grade) //Class member function 
        {
            if (grade <= 100 && grade > 0) 
            {
               
                grades.Add(grade);
                //WriteLogDelegate log;
                //log = new WriteLogDelegate(ReturnMessage);
                //var result = log("I'm log");

                WriteLogDelegate log = ReturnMessage;
                log += AdditionalLog;
                log += AdditionalLog1;
                var result = log("I'm log");

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
        public override void ComputeAverage()
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

            Console.WriteLine($"Book Name: {Name}");
            Console.WriteLine($"Lowest Number: {lowestNumber}");
            Console.WriteLine($"Highest Number: {highestNumber}");
            Console.WriteLine($"The average:  {(listResult / grades.Count):N3}");
            Console.ReadKey();

        }
    }
}
