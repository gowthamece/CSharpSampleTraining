using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSample
{
    public abstract class BookBase: BaseModel, IBook
    {
       
        public BookBase(string name):base(name)
        {

        }
        public abstract void AddGrade(double grade);
        public abstract void ComputeAverage();

       

    }
}
