using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSample.Interface
{
    public interface IBook
    {
        void AddGrade(double grade);
        void GetStatistics();
        string Name { get; set; }

    }
}
