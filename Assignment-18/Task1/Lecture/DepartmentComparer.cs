using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    public class DepartmentComparer : IEqualityComparer<Department>
    {
        public bool Equals(Department x, Department y)
        {
            if (ReferenceEquals(x, y)) return true;
            if (ReferenceEquals(x, null)) return false;
            if (ReferenceEquals(y, null)) return false;
            if (x.GetType() != y.GetType()) return false;
            return x.Id == y.Id && x.Name == y.Name;
        }

        public int GetHashCode(Department obj)
        {
            return HashCode.Combine(obj.Id, obj.Name, obj.Employees);
        }
    }
}
