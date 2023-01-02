using CSharpSample.AbstractClassDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSample
{
    public class StudentSample : BookAbstractBase
    {
        public StudentSample(string name) : base(name)
        {
            Name = name;
        }
        public override void AddGrade(double grade)
        {
            Console.WriteLine("Add Grade method");
        }

        public override void ComputeAverage()
        {
            Console.WriteLine("Compute Average method");
        }
    }
}
