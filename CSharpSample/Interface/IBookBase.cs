using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSample.Interface
{
    public interface IBookBase
    {
        void AddGrade(double grade);
        void ComputeAverage();
        List<int> ListofNumbers();
        string Name
        {
            get;set;
        }
    }
}
