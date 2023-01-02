using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSample
{
    public class BaseModel
    {
        public string Name { get; set; }
        public BaseModel(string name)
        {
            Name = name;
        }

    }
}
