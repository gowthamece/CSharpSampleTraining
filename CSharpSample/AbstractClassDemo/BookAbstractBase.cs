using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSample.AbstractClassDemo
{
    public abstract class BookAbstractBase : BaseModel
    {
        public BookAbstractBase(string name) : base(name)
        {

        }
        public abstract void AddGrade(double grade);
                
        public abstract void ComputeAverage();
    }
}
