using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Core.Exceptions
{
    public class ClasroomNotFoundException : Exception
    {
        public ClasroomNotFoundException(string? message) : base(message)
        {
        }
    }
}
