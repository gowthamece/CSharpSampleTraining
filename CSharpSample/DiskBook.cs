using CSharpSample.AbstractClassDemo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSample
{
    public class DiskBook : BookAbstractBase
    {
        public DiskBook(string name) : base(name)
        {
        }

        public override void AddGrade(double grade)
        {
            var writer = File.AppendText($"{Name}.txt");
            
            writer.WriteLine(grade);
            writer.Close();
            
            //----------using statement -------------------------//
            //using (var writer = File.AppendText($"{Name}.txt"))
            //{
            //    writer.WriteLine(grade);
            //}
           
        }

        public override void ComputeAverage()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Hello");
        }
    }
}
