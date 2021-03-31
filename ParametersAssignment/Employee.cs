using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    class Employee<T>
    {
        public List<T> Things { get; set; }// property is a genric list called Things
    }
}
