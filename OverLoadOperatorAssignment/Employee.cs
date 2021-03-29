using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadOperatorAssignment
{
     class Employee
    {
        public int Id { get; set; } // declare prperty must be inside the class

        public static bool operator ==(Employee x, Employee y) //overload operater "==", checks to see of employee ids are equal or not
        {
            return x.Id == y.Id;
        }

        public static bool operator !=(Employee x, Employee y)
        {
            return x.Id != y.Id;
        }

        public override bool Equals(object obj)
        {
            Employee Id = obj as Employee;
            if (Id != null)
            {
                return Id == this;
            }
            return false;
        }
        public override int GetHashCode() // when using Equals in your methods or class its important to include GetHashCode
        {
            return base.GetHashCode();
        }
    }
}
